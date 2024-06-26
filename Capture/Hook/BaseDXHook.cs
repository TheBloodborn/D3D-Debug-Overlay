﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using EasyHook;
using System.IO;
using System.Runtime.Remoting;
using System.Diagnostics;
using Capture.Interface;

namespace Capture.Hook
{
    internal abstract class BaseDXHook: SharpDX.Component, IDXHook
    {
        protected readonly ClientCaptureInterfaceEventProxy InterfaceEventProxy = new ClientCaptureInterfaceEventProxy();

        public BaseDXHook(CaptureInterface ssInterface)
        {
            this.Interface = ssInterface;
            this.Timer = new Stopwatch();
            this.Timer.Start();
            this.FPS = new FramesPerSecond();

            Interface.DisplayText += InterfaceEventProxy.DisplayTextProxyHandler;
            Interface.DrawOverlay += InterfaceEventProxy.DrawOverlayProxyHandler;
            InterfaceEventProxy.DisplayText += new DisplayTextEvent(InterfaceEventProxy_DisplayText);
            InterfaceEventProxy.DrawOverlay += InterfaceEventProxy_DrawOverlay;
        }

        ~BaseDXHook()
        {
            Dispose(false);
        }

        void InterfaceEventProxy_DisplayText(DisplayTextEventArgs args)
        {
            TextDisplay = new TextDisplay()
            {
                Text = args.Text,
                Duration = args.Duration
            };
        }

        private void InterfaceEventProxy_DrawOverlay(DrawOverlayEventArgs args)
        {
            if (args.Overlay != null)
                Overlay = args.Overlay;
            IsOverlayUpdatePending = true;
        }

        protected Stopwatch Timer { get; set; }

        /// <summary>
        /// Frames Per second counter, FPS.Frame() must be called each frame
        /// </summary>
        protected FramesPerSecond FPS { get; set; }

        protected TextDisplay TextDisplay { get; set; }

        protected Common.IOverlay Overlay { get; set; }
 
        protected bool IsOverlayUpdatePending { get; set; }

        int _processId = 0;
        protected int ProcessId
        {
            get
            {
                if (_processId == 0)
                {
                    _processId = RemoteHooking.GetCurrentProcessId();
                }
                return _processId;
            }
        }

        protected virtual string HookName
        {
            get
            {
                return "BaseDXHook";
            }
        }

        protected void Frame()
        {
            FPS.Frame();
            if (TextDisplay != null && TextDisplay.Display) 
                TextDisplay.Frame();
        }

        protected void DebugMessage(string message)
        {
#if DEBUG
            try
            {
                Interface.Message(MessageType.Debug, HookName + ": " + message);
            }
            catch (RemotingException)
            {
                // Ignore remoting exceptions
            }
            catch (Exception)
            {
                // Ignore all other exceptions
            }
#endif
        }

        protected IntPtr[] GetVTblAddresses(IntPtr pointer, int numberOfMethods)
        {
            return GetVTblAddresses(pointer, 0, numberOfMethods);
        }

        protected IntPtr[] GetVTblAddresses(IntPtr pointer, int startIndex, int numberOfMethods)
        {
            List<IntPtr> vtblAddresses = new List<IntPtr>();

            IntPtr vTable = Marshal.ReadIntPtr(pointer);
            for (int i = startIndex; i < startIndex + numberOfMethods; i++)
                vtblAddresses.Add(Marshal.ReadIntPtr(vTable, i * IntPtr.Size)); // using IntPtr.Size allows us to support both 32 and 64-bit processes

            return vtblAddresses.ToArray();
        }

        protected static void CopyStream(Stream input, Stream output)
        {
            int bufferSize = 32768;
            byte[] buffer = new byte[bufferSize];
            while (true)
            {
                int read = input.Read(buffer, 0, buffer.Length);
                if (read <= 0)
                {
                    return;
                }
                output.Write(buffer, 0, read);
            }
        }

        /// <summary>
        /// Reads data from a stream until the end is reached. The
        /// data is returned as a byte array. An IOException is
        /// thrown if any of the underlying IO calls fail.
        /// </summary>
        /// <param name="stream">The stream to read data from</param>
        protected static byte[] ReadFullStream(Stream stream)
        {
            if (stream is MemoryStream stream1)
            {
                return stream1.ToArray();
            }
            else
            {
                byte[] buffer = new byte[32768];
                using (MemoryStream ms = new MemoryStream())
                {
                    while (true)
                    {
                        int read = stream.Read(buffer, 0, buffer.Length);
                        if (read > 0)
                            ms.Write(buffer, 0, read);
                        if (read < buffer.Length)
                        {
                            return ms.ToArray();
                        }
                    }
                }
            }
        }

        protected TimeSpan LastCaptureTime
        {
            get;
            set;
        }

        protected bool CaptureThisFrame
        {
            get
            {
                return ((Timer.Elapsed - LastCaptureTime) > CaptureDelay);
            }
        }
        protected TimeSpan CaptureDelay { get; set; }

        #region IDXHook Members

        public CaptureInterface Interface
        {
            get;
            set;
        }
        
        private CaptureConfig _config;
        public CaptureConfig Config
        {
            get { return _config; }
            set
            {
                _config = value;
                CaptureDelay = new TimeSpan(0, 0, 0, 0, (int)((1.0 / (double)_config.TargetFramesPerSecond) * 1000.0));
            }
        }

        protected List<Hook> Hooks = new List<Hook>();
        public abstract void Hook();

        public abstract void Cleanup();

        #endregion

        #region IDispose Implementation

        protected override void Dispose(bool disposeManagedResources)
        {
            // Only clean up managed objects if disposing (i.e. not called from destructor)
            if (disposeManagedResources)
            {
                try
                {
                    Cleanup();
                }
                catch { }

                try
                {
                    // Uninstall Hooks
                    if (Hooks.Count > 0)
                    {
                        // First disable the hook (by excluding all threads) and wait long enough to ensure that all hooks are not active
                        foreach (var hook in Hooks)
                        {
                            // Lets ensure that no threads will be intercepted again
                            hook.Deactivate();
                        }

                        System.Threading.Thread.Sleep(100);

                        // Now we can dispose of the hooks (which triggers the removal of the hook)
                        foreach (var hook in Hooks)
                        {
                            hook.Dispose();
                        }

                        Hooks.Clear();
                    }

                    try
                    {
                        Interface.DisplayText -= InterfaceEventProxy.DisplayTextProxyHandler;
                        Interface.DrawOverlay -= InterfaceEventProxy_DrawOverlay;
                    }
                    catch (RemotingException) { } // Ignore remoting exceptions (host process may have been closed)
                }
                catch
                {
                }
            }

            base.Dispose(disposeManagedResources);
        }

        #endregion
    }
}
