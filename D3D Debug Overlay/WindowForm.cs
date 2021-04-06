using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.IO;
using Capture;
using Capture.Interface;
using Capture.Hook;
using System.Collections.Generic;
using System.Drawing;

namespace D3D_Debug_Overlay
{
    public partial class WindowForm : Form
    {
        /// <summary>
        /// Global Variables.
        /// </summary>
        CaptureProcess _captureProcess;
        IntPtr xPtr;
        IntPtr yPtr;
        IntPtr zPtr;

        /// <summary>
        /// Instantialize the Form.
        /// </summary>
        #region Initialize

        public WindowForm()
        {
            InitializeComponent();
        }

        private void WindowForm_Load(object sender, EventArgs e)
        {
        }
        #endregion

        /// <summary>
        /// Inject DLL into the EXE.
        /// </summary>
        # region Inject
        private void BtnInject_Click(object sender, EventArgs e)
        {
            if (_captureProcess == null)
            {
                btnInject.Enabled = false;
                AttachProcess();
            }
            else
            {
                HookManager.RemoveHookedProcess(_captureProcess.Process.Id);
                _captureProcess.CaptureInterface.Disconnect();
                _captureProcess = null;
            }
            if (_captureProcess != null)
            {
                btnInject.Text = "Detach";
                btnInject.Enabled = true;
            }
            else
            {
                btnInject.Text = "Inject";
                btnInject.Enabled = true;
            }
        }

        private void AttachProcess()
        {
            string exeName = Path.GetFileNameWithoutExtension(boxApp.Text);
            Memory.ManageMemory.Initialize(exeName);
            Process[] processes = Process.GetProcessesByName(exeName);
            foreach (Process process in processes)
            {
                // Simply attach to the first one found.

                // If the process doesn't have a mainwindowhandle yet, skip it (we need to be able to get the hwnd to set foreground etc)
                if (process.MainWindowHandle == IntPtr.Zero)
                {
                    continue;
                }

                // Skip if the process is already hooked (and we want to hook multiple applications)
                if (HookManager.IsHooked(process.Id))
                {
                    continue;
                }

                Direct3DVersion direct3DVersion = Direct3DVersion.Direct3D10;

                if (rbDirect3D11.Checked)
                {
                    direct3DVersion = Direct3DVersion.Direct3D11;
                }
                else if (rbDirect3D10_1.Checked)
                {
                    direct3DVersion = Direct3DVersion.Direct3D10_1;
                }
                else if (rbDirect3D10.Checked)
                {
                    direct3DVersion = Direct3DVersion.Direct3D10;
                }
                else if (rbDirect3D9.Checked)
                {
                    direct3DVersion = Direct3DVersion.Direct3D9;
                }
                else if (rbAutodetect.Checked)
                {
                    direct3DVersion = Direct3DVersion.AutoDetect;
                }

                CaptureConfig cc = new CaptureConfig()
                {
                    Direct3DVersion = direct3DVersion,
                    ShowOverlay = cbDrawOverlay.Checked
                };

                var captureInterface = new CaptureInterface();
                captureInterface.RemoteMessage += new MessageReceivedEvent(CaptureInterface_RemoteMessage);
                _captureProcess = new CaptureProcess(process, cc, captureInterface);

                break;
            }
            Thread.Sleep(10);

            if (_captureProcess == null)
            {
                MessageBox.Show("No executable found matching: '" + exeName + "'");
            }
        }
        #endregion

        /// <summary>
        /// Display messages from the target process
        /// </summary>
        /// <param name="message"></param>
        void CaptureInterface_RemoteMessage(MessageReceivedEventArgs message)
        {
            txtDebugLog.Invoke(new MethodInvoker(delegate ()
            {
                txtDebugLog.Text = String.Format("{0}\r\n{1}", message, txtDebugLog.Text);
            })
            );
        }

        /// <summary>
        /// Determines what is drawn in the overlay.
        /// </summary>
        private void DrawOverlay()
        {
            _captureProcess.CaptureInterface.DrawOverlayInGame(new Capture.Hook.Common.Overlay
            {
                Elements = new List<Capture.Hook.Common.IOverlayElement>
                {
                    new Capture.Hook.Common.TextElement(new System.Drawing.Font("Arial", 16, FontStyle.Bold)) {
                            Location = new Point(25, 25),
                            Color = Color.Red,
                            AntiAliased = true,
                            Text = "X: " + Memory.ManageMemory.ReadMemory<float>(xPtr.ToInt32())
                        },
                    new Capture.Hook.Common.TextElement(new System.Drawing.Font("Arial", 16, FontStyle.Bold)) {
                            Location = new Point(25, 55),
                            Color = Color.Red,
                            AntiAliased = true,
                            Text = "Y: " + Memory.ManageMemory.ReadMemory<float>(yPtr.ToInt32())
                        },
                    new Capture.Hook.Common.TextElement(new System.Drawing.Font("Arial", 16, FontStyle.Bold)) {
                            Location = new Point(25, 85),
                            Color = Color.Red,
                            AntiAliased = true,
                            Text = "Z: " + Memory.ManageMemory.ReadMemory<float>(zPtr.ToInt32())
                        },
                },
                Hidden = !cbDrawOverlay.Checked
            });
        }

        /// <summary>
        /// Button to display overlay, this also assigns memory pointers.
        /// </summary>
        private void BtnDisplayOverlay_Click(object sender, EventArgs e)
        {
            IntPtr basePtr = IntPtr.Add(Memory.ManageMemory.m_Process.MainModule.BaseAddress, Convert.ToInt32(boxAddress.Text, 16));
            xPtr = IntPtr.Add(Memory.ManageMemory.ReadMemory<IntPtr>(basePtr.ToInt32()), Convert.ToInt32(boxX.Text, 16));
            yPtr = IntPtr.Add(Memory.ManageMemory.ReadMemory<IntPtr>(basePtr.ToInt32()), Convert.ToInt32(boxY.Text, 16));
            zPtr = IntPtr.Add(Memory.ManageMemory.ReadMemory<IntPtr>(basePtr.ToInt32()), Convert.ToInt32(boxZ.Text, 16));
            this.bwOverlayDrawer.RunWorkerAsync();
            _captureProcess.BringProcessWindowToFront();
        }
        
        /// <summary>
        /// Background thread that updates the overlay.
        /// </summary>
        #region Background Thread
        private void BwOverlayDrawer_DoWork(object sender, DoWorkEventArgs e)
        {
            // Do not access the form's BackgroundWorker reference directly.
            // Instead, use the reference provided by the sender parameter.
            BackgroundWorker bw = sender as BackgroundWorker;

            // Start the time-consuming operation.
            e.Result = UpdateOverlay(bw);

            // If the operation was canceled by the user,
            // set the DoWorkEventArgs.Cancel property to true.
            if (bw.CancellationPending)
            {
                e.Cancel = true;
            }
        }

        private void BwOverlayDrawer_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                // The user canceled the operation.
                MessageBox.Show("Operation was canceled");
            }
            else if (e.Error != null)
            {
                // There was an error during the operation.
                string msg = String.Format("An error occurred: {0}", e.Error.Message);
                MessageBox.Show(msg);
            }
            else
            {
                // The operation completed normally.
                string msg = String.Format("Result = {0}", e.Result);
                MessageBox.Show(msg);
            }
        }

        private int UpdateOverlay(BackgroundWorker bw)
        {
            while (!bw.CancellationPending)
            {
                Thread.Sleep(int.Parse(boxRefresh.Text));
                DrawOverlay();
            }
            return 1;
        }
#endregion
    }
}
