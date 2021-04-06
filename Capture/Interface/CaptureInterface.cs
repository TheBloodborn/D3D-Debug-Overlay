﻿using System;
using Capture.Hook.Common;

namespace Capture.Interface
{
    [Serializable]
    public delegate void RecordingStartedEvent(CaptureConfig config);
    [Serializable]
    public delegate void RecordingStoppedEvent();
    [Serializable]
    public delegate void MessageReceivedEvent(MessageReceivedEventArgs message);
    [Serializable]
    public delegate void DisconnectedEvent();
    [Serializable]
    public delegate void DisplayTextEvent(DisplayTextEventArgs args);
    [Serializable]
    public delegate void DrawOverlayEvent(DrawOverlayEventArgs args);

    [Serializable]
    public class CaptureInterface : MarshalByRefObject
    {
        /// <summary>
        /// The client process Id
        /// </summary>
        public int ProcessId { get; set; }

        #region Events

        #region Server-side Events
        
        /// <summary>
        /// Server event for sending debug and error information from the client to server
        /// </summary>
        public event MessageReceivedEvent RemoteMessage;
       
        #endregion

        #region Client-side Events
        
        /// <summary>
        /// Client event used to communicate to the client that it is time to start recording
        /// </summary>
        public event RecordingStartedEvent RecordingStarted;

        /// <summary>
        /// Client event used to communicate to the client that it is time to stop recording
        /// </summary>
        public event RecordingStoppedEvent RecordingStopped;

        /// <summary>
        /// Client event used to notify the hook to exit
        /// </summary>
        public event DisconnectedEvent Disconnected;

        /// <summary>
        /// Client event used to display a piece of text in-game
        /// </summary>
        public event DisplayTextEvent DisplayText;
        
        /// <summary>
        ///     Client event used to (re-)draw an overlay in-game.
        /// </summary>
        public event DrawOverlayEvent DrawOverlay;

        #endregion

        #endregion

        public bool IsRecording { get; set; }

        #region Public Methods

        #region Video Capture

        /// <summary>
        /// If not <see cref="IsRecording"/> will invoke the <see cref="RecordingStarted"/> event, starting a new recording. 
        /// </summary>
        /// <param name="config">The configuration for the recording</param>
        /// <remarks>Handlers in the server and remote process will be be invoked.</remarks>
        public void StartRecording(CaptureConfig config)
        {
            if (IsRecording)
                return;
            SafeInvokeRecordingStarted(config);
            IsRecording = true;
        }

        /// <summary>
        /// If <see cref="IsRecording"/>, will invoke the <see cref="RecordingStopped"/> event, finalising any existing recording.
        /// </summary>
        /// <remarks>Handlers in the server and remote process will be be invoked.</remarks>
        public void StopRecording()
        {
            if (!IsRecording)
                return;
            SafeInvokeRecordingStopped();
            IsRecording = false;
        }

        #endregion

        /// <summary>
        /// Tell the client process to disconnect
        /// </summary>
        public void Disconnect()
        {
            SafeInvokeDisconnected();
        }

        /// <summary>
        /// Send a message to all handlers of <see cref="CaptureInterface.RemoteMessage"/>.
        /// </summary>
        /// <param name="messageType"></param>
        /// <param name="format"></param>
        /// <param name="args"></param>
        public void Message(MessageType messageType, string format, params object[] args)
        {
            Message(messageType, String.Format(format, args));
        }

        public void Message(MessageType messageType, string message)
        {
            SafeInvokeMessageRecevied(new MessageReceivedEventArgs(messageType, message));
        }

        /// <summary>
        /// Display text in-game for the default duration of 5 seconds
        /// </summary>
        /// <param name="text"></param>
        public void DisplayInGameText(string text)
        {
            DisplayInGameText(text, new TimeSpan(0, 0, 5));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="duration"></param>
        public void DisplayInGameText(string text, TimeSpan duration)
        {
            if (duration.TotalMilliseconds <= 0)
                throw new ArgumentException("Duration must be larger than 0", "duration");
            SafeInvokeDisplayText(new DisplayTextEventArgs(text, duration));
        }

        /// <summary>
        /// Replace the in-game overlay with the one provided.
        /// 
        /// Note: this is not designed for fast updates (i.e. only a couple of times per second)
        /// </summary>
        /// <param name="overlay"></param>
        public void DrawOverlayInGame(IOverlay overlay)
        {
            SafeInvokeDrawOverlay(new DrawOverlayEventArgs()
            {
                Overlay = overlay
            });
        }

        #endregion

        #region Private: Invoke message handlers

        private void SafeInvokeRecordingStarted(CaptureConfig config)
        {
            if (RecordingStarted == null)
                return;         //No Listeners

            RecordingStartedEvent listener = null;
            Delegate[] dels = RecordingStarted.GetInvocationList();

            foreach (Delegate del in dels)
            {
                try
                {
                    listener = (RecordingStartedEvent)del;
                    listener.Invoke(config);
                }
                catch (Exception)
                {
                    //Could not reach the destination, so remove it
                    //from the list
                    RecordingStarted -= listener;
                }
            }
        }

        private void SafeInvokeRecordingStopped()
        {
            if (RecordingStopped == null)
                return;         //No Listeners

            RecordingStoppedEvent listener = null;
            Delegate[] dels = RecordingStopped.GetInvocationList();

            foreach (Delegate del in dels)
            {
                try
                {
                    listener = (RecordingStoppedEvent)del;
                    listener.Invoke();
                }
                catch (Exception)
                {
                    //Could not reach the destination, so remove it
                    //from the list
                    RecordingStopped -= listener;
                }
            }
        }

        private void SafeInvokeMessageRecevied(MessageReceivedEventArgs eventArgs)
        {
            if (RemoteMessage == null)
                return;         //No Listeners

            MessageReceivedEvent listener = null;
            Delegate[] dels = RemoteMessage.GetInvocationList();

            foreach (Delegate del in dels)
            {
                try
                {
                    listener = (MessageReceivedEvent)del;
                    listener.Invoke(eventArgs);
                }
                catch (Exception)
                {
                    //Could not reach the destination, so remove it
                    //from the list
                    RemoteMessage -= listener;
                }
            }
        }

        private void SafeInvokeDisconnected()
        {
            if (Disconnected == null)
                return;         //No Listeners

            DisconnectedEvent listener = null;
            Delegate[] dels = Disconnected.GetInvocationList();

            foreach (Delegate del in dels)
            {
                try
                {
                    listener = (DisconnectedEvent)del;
                    listener.Invoke();
                }
                catch (Exception)
                {
                    //Could not reach the destination, so remove it
                    //from the list
                    Disconnected -= listener;
                }
            }
        }

        private void SafeInvokeDisplayText(DisplayTextEventArgs displayTextEventArgs)
        {
            if (DisplayText == null)
                return;         //No Listeners

            DisplayTextEvent listener = null;
            Delegate[] dels = DisplayText.GetInvocationList();

            foreach (Delegate del in dels)
            {
                try
                {
                    listener = (DisplayTextEvent)del;
                    listener.Invoke(displayTextEventArgs);
                }
                catch (Exception)
                {
                    //Could not reach the destination, so remove it
                    //from the list
                    DisplayText -= listener;
                }
            }
        }

        private void SafeInvokeDrawOverlay(DrawOverlayEventArgs drawOverlayEventArgs)
        {
            if (DrawOverlay == null)
                return; //No Listeners

            DrawOverlayEvent listener = null;
            var dels = DrawOverlay.GetInvocationList();

            foreach (var del in dels)
            {
                try
                {
                    listener = (DrawOverlayEvent)del;
                    listener.Invoke(drawOverlayEventArgs);
                }
                catch (Exception)
                {
                    //Could not reach the destination, so remove it
                    //from the list
                    DrawOverlay -= listener;
                }
            }
        }

        #endregion

        /// <summary>
        /// Used to confirm connection to IPC server channel
        /// </summary>
        public DateTime Ping()
        {
            return DateTime.Now;
        }
    }


    /// <summary>
    /// Client event proxy for marshalling event handlers
    /// </summary>
    public class ClientCaptureInterfaceEventProxy : MarshalByRefObject
    {
        #region Event Declarations

        /// <summary>
        /// Client event used to communicate to the client that it is time to start recording
        /// </summary>
        public event RecordingStartedEvent RecordingStarted;

        /// <summary>
        /// Client event used to communicate to the client that it is time to stop recording
        /// </summary>
        public event RecordingStoppedEvent RecordingStopped;

        /// <summary>
        /// Client event used to notify the hook to exit
        /// </summary>
        public event DisconnectedEvent Disconnected;

        /// <summary>
        /// Client event used to display in-game text
        /// </summary>
        public event DisplayTextEvent DisplayText;

        /// <summary>
        ///     Client event used to (re-)draw an overlay in-game.
        /// </summary>
        public event DrawOverlayEvent DrawOverlay;

        #endregion

        #region Lifetime Services

        public override object InitializeLifetimeService()
        {
            //Returning null holds the object alive
            //until it is explicitly destroyed
            return null;
        }

        #endregion

        public void RecordingStartedProxyHandler(CaptureConfig config)
        {
            RecordingStarted?.Invoke(config);
        }

        public void RecordingStoppedProxyHandler()
        {
            RecordingStopped?.Invoke();
        }


        public void DisconnectedProxyHandler()
        {
            Disconnected?.Invoke();
        }

        public void DisplayTextProxyHandler(DisplayTextEventArgs args)
        {
            DisplayText?.Invoke(args);
        }
        
        public void DrawOverlayProxyHandler(DrawOverlayEventArgs args)
        {
            DrawOverlay?.Invoke(args);
        }
    }
}
