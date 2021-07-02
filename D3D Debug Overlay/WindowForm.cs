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
        //Process _process;
        //int basePtr;
        int xPtr;
        int yPtr;
        int zPtr;
        int posX;
        int posY;
        int size;
        Color color;
        Color doorColor;

        /// <summary>
        /// Instantialize the Form.
        /// </summary>
        #region Initialize

        public WindowForm()
        {
            if (!Directory.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "D3D Debug Overlay")))
            {
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "D3D Debug Overlay"));
            }
            if (!File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "D3D Debug Overlay\\Presets.txt")))
            {
                File.CreateText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "D3D Debug Overlay\\Presets.txt"));
            }
            if (File.ReadAllLines(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "D3D Debug Overlay\\Presets.txt")).Length != 5)
            {
                string[] saves = new string[5];
                for (int i = 0; i < 5; i++)
                {
                    saves[i] = "Slot " + (i+1) + ";" +
                        200 + ";" +
                        "00000000" + ";" +
                        70 + ";" +
                        74 + ";" +
                        78 + ";" +
                        20 + ";" +
                        "FFFF0000" + ";" +
                        25 + ";" +
                        25 + ";" +
                        "FF00FF00";
                }
                File.WriteAllLines(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "D3D Debug Overlay\\Presets.txt"), saves);
            }
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
                bwHotkeys.RunWorkerAsync();
            }
            else
            {
                bwHotkeys.CancelAsync();
                bwOverlayDrawer.CancelAsync();
                HookManager.RemoveHookedProcess(_captureProcess.Process.Id);
                _captureProcess.CaptureInterface.Disconnect();
                _captureProcess = null;
            }
            if (_captureProcess != null)
            {
                btnInject.Text = "Detach";
                btnInject.Enabled = true;
                btnDisplayOverlay.Enabled = true;
                btnStopDisplay.Enabled = true;
            }
            else
            {
                btnInject.Text = "Inject";
                btnInject.Enabled = true;
                btnDisplayOverlay.Enabled = false;
                btnStopDisplay.Enabled = false;
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
                //_process = process;
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
        /// modes {0, 1, 2, 3} correspond to {false, true, cbDrawOverlay.Checked, !cbDrawOverlay.Checked}.
        /// </summary>
        
        private void SwitchDisplay()
        {
            if (bwOverlayDrawer.IsBusy)
            {
                BtnStopDisplay_Click(null, null);
            }
            else
            {
                DisplayOverlay();
            }
        }

        /// <summary>
        /// Determines what is drawn in the overlay.
        /// modes {0, 1, 2, 3} correspond to {false, true, cbDrawOverlay.Checked, !cbDrawOverlay.Checked}.
        /// </summary>
        private void DrawOverlay(int mode)
        {
            if (mode == 0)
            {
                DrawOverlay(false);
            }
            if (mode == 1)
            {
                DrawOverlay(true);
            }
            if (mode == 2)
            {
                DrawOverlay(cbDrawOverlay.Checked);
            }
            if (mode == 3)
            {
                DrawOverlay(!cbDrawOverlay.Checked);
            }
        }
        private void DrawOverlay(bool hide)
        {
            Color colorX = color;
            Color colorY = color;
            Color colorZ = color;
            float X = Memory.ManageMemory.ReadMemory<float>(xPtr);
            float Y = Memory.ManageMemory.ReadMemory<float>(yPtr);
            float Z = Memory.ManageMemory.ReadMemory<float>(zPtr);
            if (cbDoor.Checked)
            {
                if (!cbList.Checked)
                {
                    if (float.Parse(boxXMargin1.Text) <= X &&
                        float.Parse(boxXMargin2.Text) >= X)
                    {
                        colorX = doorColor;
                    }
                    if (float.Parse(boxYMargin1.Text) <= Y &&
                        float.Parse(boxYMargin2.Text) >= Y)
                    {
                        colorY = doorColor;
                    }
                    if (float.Parse(boxZMargin1.Text) <= Z &&
                        float.Parse(boxZMargin2.Text) >= Z)
                    {
                        colorZ = doorColor;
                    }
                }
            }
            _captureProcess.CaptureInterface.DrawOverlayInGame(new Capture.Hook.Common.Overlay
            {
                Elements = new List<Capture.Hook.Common.IOverlayElement>
                {
                    new Capture.Hook.Common.TextElement(new System.Drawing.Font("Arial", size, FontStyle.Bold)) {
                            Location = new Point(posX, posY),
                            Color = colorX,
                            AntiAliased = true,
                            Text = "X: " + X
                        },
                    new Capture.Hook.Common.TextElement(new System.Drawing.Font("Arial", size, FontStyle.Bold)) {
                            Location = new Point(posX, posY + size + 5),
                            Color = colorY,
                            AntiAliased = true,
                            Text = "Y: " + Y
                        },
                    new Capture.Hook.Common.TextElement(new System.Drawing.Font("Arial", size, FontStyle.Bold)) {
                            Location = new Point(posX, posY + (2 * size) + 10),
                            Color = colorZ,
                            AntiAliased = true,
                            Text = "Z: " + Z
                        },
                },
                Hidden = hide
            });
        }

        /// <summary>
        /// Button to display overlay, this also assigns variables (including memory pointer).
        /// </summary>
        private void BtnDisplayOverlay_Click(object sender, EventArgs e)
        {
            DisplayOverlay();
            _captureProcess.BringProcessWindowToFront();
        }
        private void DisplayOverlay()
        {
            //btnDisplayOverlay.Enabled = false;
            if (!bwOverlayDrawer.IsBusy)
            {
                int basePtr = (int)IntPtr.Add(Memory.ManageMemory.m_Process.MainModule.BaseAddress, (int)Convert.ToInt64(boxAddress.Text, 16)).ToInt64();
                xPtr = (int)IntPtr.Add(Memory.ManageMemory.ReadMemory<IntPtr>(basePtr), (int)Convert.ToInt64(boxX.Text, 16)).ToInt64();
                yPtr = (int)IntPtr.Add(Memory.ManageMemory.ReadMemory<IntPtr>(basePtr), (int)Convert.ToInt64(boxY.Text, 16)).ToInt64();
                zPtr = (int)IntPtr.Add(Memory.ManageMemory.ReadMemory<IntPtr>(basePtr), (int)Convert.ToInt64(boxZ.Text, 16)).ToInt64();
                posX = int.Parse(boxPosX.Text);
                posY = int.Parse(boxPosY.Text);
                size = int.Parse(boxSize.Text);
                color = Color.FromArgb(Convert.ToInt32(boxColour.Text, 16));
                doorColor = Color.FromArgb(Convert.ToInt32(boxDoorColour.Text, 16));
                this.bwOverlayDrawer.RunWorkerAsync();
            }
            //btnStopDisplay.Enabled = true;
        }

        /// <summary>
        /// Button to stop background thread that updates the overlay.
        /// </summary>
        private void BtnStopDisplay_Click(object sender, EventArgs e)
        {
            //btnStopDisplay.Enabled = false;
            if (bwOverlayDrawer.IsBusy)
            {
                this.bwOverlayDrawer.CancelAsync();
                Thread.Sleep(int.Parse(boxRefresh.Text));
                DrawOverlay(1);
                Thread.Sleep(int.Parse(boxRefresh.Text));
            }
            //btnDisplayOverlay.Enabled = true;
        }

        /// <summary>
        /// Background thread that updates the overlay.
        /// </summary>
        #region Background Overlay Thread
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
                //MessageBox.Show("Operation was canceled");
            }
            else if (e.Error != null)
            {
                // There was an error during the operation.
                string msg = String.Format("An error occurred: {0}", e.Error.Message);
                MessageBox.Show(msg);
            }
            /*
            else if ((int)e.Result == 2)
            {
                bwOverlayDrawer.CancelAsync();
                Thread.Sleep(int.Parse(boxRefresh.Text));
                BtnInject_Click(null, null);
            }
            */
            else
            {
                // The operation completed normally.
                //string msg = String.Format("Result = {0}", e.Result);
                //MessageBox.Show(msg);
            }
        }

        private int UpdateOverlay(BackgroundWorker bw)
        {
            while (!bw.CancellationPending)
            {
                Thread.Sleep(int.Parse(boxRefresh.Text));
                DrawOverlay(3);
            }
            return 1;
        }
        #endregion

        /// <summary>
        /// Background thread that keeps track of hotkeys.
        /// </summary>
        #region Background Hotkey Thread
        private void BwHotkeys_DoWork(object sender, DoWorkEventArgs e)
        {
            // Do not access the form's BackgroundWorker reference directly.
            // Instead, use the reference provided by the sender parameter.
            BackgroundWorker bw = sender as BackgroundWorker;

            // Start the time-consuming operation.
            e.Result = ReadHotkeys(bw);

            // If the operation was canceled by the user,
            // set the DoWorkEventArgs.Cancel property to true.
            if (bw.CancellationPending)
            {
                e.Cancel = true;
            }
        }

        private void BwHotkeys_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                // The user canceled the operation.
                //MessageBox.Show("Operation was canceled");
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
                //string msg = String.Format("Result = {0}", e.Result);
                //MessageBox.Show(msg);
            }
        }

        private int ReadHotkeys(BackgroundWorker bw)
        {
            while (!bw.CancellationPending)
            {
                if (Control.ModifierKeys == Keys.Control)
                {
                    SwitchDisplay();
                    Thread.Sleep(300);
                }
                Thread.Sleep(10);
            }
            return 1;
        }
        #endregion

        /// <summary>
        /// Save settings in presets for future use.
        /// </summary>
        #region Save Presets
        private void SavePreset(int slot)
        {
            txtDebugLog.Text += "Saving Slot " + slot + "...\r\n";
            string[] saves = File.ReadAllLines(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "D3D Debug Overlay\\Presets.txt"));
            string name;
            if (boxApp.Text.Equals(""))
            {
                name = "Slot " + slot;
            }
            else
            {
                name = boxApp.Text;
            }
            saves[slot - 1] = 
                name + ";" + 
                boxRefresh.Text + ";" + 
                boxAddress.Text + ";" + 
                boxX.Text + ";" + 
                boxY.Text + ";" + 
                boxZ.Text + ";" + 
                boxSize.Text + ";" + 
                boxColour.Text + ";" + 
                boxPosX.Text + ";" + 
                boxPosY.Text + ";" + 
                boxDoorColour.Text;
            File.WriteAllLines(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "D3D Debug Overlay\\Presets.txt"), saves);
            txtDebugLog.Text += "Finished Saving Slot " + slot + ".\r\n";
        }

        private void BtnSave1_Click(object sender, EventArgs e)
        {
            SavePreset(1);
        }

        private void BtnSave2_Click(object sender, EventArgs e)
        {
            SavePreset(2);
        }

        private void BtnSave3_Click(object sender, EventArgs e)
        {
            SavePreset(3);
        }

        private void BtnSave4_Click(object sender, EventArgs e)
        {
            SavePreset(4);
        }

        private void BtnSave5_Click(object sender, EventArgs e)
        {
            SavePreset(5);
        }

        #endregion

        /// <summary>
        /// Save settings in presets for future use.
        /// </summary>
        #region Load Presets
        private void LoadPreset(int slot) 
        {
            txtDebugLog.Text += "Loading Slot " + slot + "...\r\n";
            string[] save = File.ReadAllLines(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "D3D Debug Overlay\\Presets.txt"))[slot-1].Split(';');
            if (save.Length == 11)
            {
                boxApp.Text = save[0];
                boxRefresh.Text = save[1];
                boxAddress.Text = save[2];
                boxX.Text = save[3];
                boxY.Text = save[4];
                boxZ.Text = save[5];
                boxSize.Text = save[6];
                boxColour.Text = save[7];
                boxPosX.Text = save[8];
                boxPosY.Text = save[9];
                boxDoorColour.Text = save[10];
                txtDebugLog.Text += "Finished Loading Slot " + slot + ".\r\n";
            }
            else
            {
                txtDebugLog.Text += "Loading failed: Slot " + slot + " is corrupted.\r\n";
            }
        }

        private void BtnLoad1_Click(object sender, EventArgs e)
        {
            LoadPreset(1);
        }

        private void BtnLoad2_Click(object sender, EventArgs e)
        {
            LoadPreset(2);
        }

        private void BtnLoad3_Click(object sender, EventArgs e)
        {
            LoadPreset(3);
        }

        private void BtnLoad4_Click(object sender, EventArgs e)
        {
            LoadPreset(4);
        }

        private void BtnLoad5_Click(object sender, EventArgs e)
        {
            LoadPreset(5);
        }

        #endregion
    }
}
