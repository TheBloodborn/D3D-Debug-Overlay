namespace D3D_Debug_Overlay
{
    partial class WindowForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelOverlay = new System.Windows.Forms.Panel();
            this.btnStopDisplay = new System.Windows.Forms.Button();
            this.boxRefresh = new System.Windows.Forms.TextBox();
            this.labelRefresh = new System.Windows.Forms.Label();
            this.btnDisplayOverlay = new System.Windows.Forms.Button();
            this.rbDirect3D10_1 = new System.Windows.Forms.RadioButton();
            this.rbAutodetect = new System.Windows.Forms.RadioButton();
            this.cbDrawOverlay = new System.Windows.Forms.CheckBox();
            this.rbDirect3D11 = new System.Windows.Forms.RadioButton();
            this.rbDirect3D10 = new System.Windows.Forms.RadioButton();
            this.rbDirect3D9 = new System.Windows.Forms.RadioButton();
            this.labelApp = new System.Windows.Forms.Label();
            this.boxApp = new System.Windows.Forms.TextBox();
            this.btnInject = new System.Windows.Forms.Button();
            this.labelOverlay = new System.Windows.Forms.Label();
            this.panelCoords = new System.Windows.Forms.Panel();
            this.boxColour = new System.Windows.Forms.TextBox();
            this.boxSize = new System.Windows.Forms.TextBox();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelColour = new System.Windows.Forms.Label();
            this.boxPosX = new System.Windows.Forms.TextBox();
            this.boxPosY = new System.Windows.Forms.TextBox();
            this.labelPos = new System.Windows.Forms.Label();
            this.labelCoords = new System.Windows.Forms.Label();
            this.boxZ = new System.Windows.Forms.TextBox();
            this.boxY = new System.Windows.Forms.TextBox();
            this.boxX = new System.Windows.Forms.TextBox();
            this.labelZ = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.boxAddress = new System.Windows.Forms.TextBox();
            this.bwOverlayDrawer = new System.ComponentModel.BackgroundWorker();
            this.txtDebugLog = new System.Windows.Forms.TextBox();
            this.panelOverlay.SuspendLayout();
            this.panelCoords.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOverlay
            // 
            this.panelOverlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOverlay.Controls.Add(this.btnStopDisplay);
            this.panelOverlay.Controls.Add(this.boxRefresh);
            this.panelOverlay.Controls.Add(this.labelRefresh);
            this.panelOverlay.Controls.Add(this.btnDisplayOverlay);
            this.panelOverlay.Controls.Add(this.rbDirect3D10_1);
            this.panelOverlay.Controls.Add(this.rbAutodetect);
            this.panelOverlay.Controls.Add(this.cbDrawOverlay);
            this.panelOverlay.Controls.Add(this.rbDirect3D11);
            this.panelOverlay.Controls.Add(this.rbDirect3D10);
            this.panelOverlay.Controls.Add(this.rbDirect3D9);
            this.panelOverlay.Controls.Add(this.labelApp);
            this.panelOverlay.Controls.Add(this.boxApp);
            this.panelOverlay.Controls.Add(this.btnInject);
            this.panelOverlay.Controls.Add(this.labelOverlay);
            this.panelOverlay.Location = new System.Drawing.Point(6, 6);
            this.panelOverlay.Name = "panelOverlay";
            this.panelOverlay.Size = new System.Drawing.Size(251, 217);
            this.panelOverlay.TabIndex = 46;
            // 
            // btnStopDisplay
            // 
            this.btnStopDisplay.Enabled = false;
            this.btnStopDisplay.Location = new System.Drawing.Point(8, 183);
            this.btnStopDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.btnStopDisplay.Name = "btnStopDisplay";
            this.btnStopDisplay.Size = new System.Drawing.Size(127, 28);
            this.btnStopDisplay.TabIndex = 47;
            this.btnStopDisplay.Text = "Stop Display";
            this.btnStopDisplay.UseVisualStyleBackColor = true;
            this.btnStopDisplay.Click += new System.EventHandler(this.BtnStopDisplay_Click);
            // 
            // boxRefresh
            // 
            this.boxRefresh.Location = new System.Drawing.Point(151, 76);
            this.boxRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.boxRefresh.Name = "boxRefresh";
            this.boxRefresh.Size = new System.Drawing.Size(91, 22);
            this.boxRefresh.TabIndex = 39;
            this.boxRefresh.Text = "200";
            // 
            // labelRefresh
            // 
            this.labelRefresh.AutoSize = true;
            this.labelRefresh.Location = new System.Drawing.Point(3, 78);
            this.labelRefresh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRefresh.Name = "labelRefresh";
            this.labelRefresh.Size = new System.Drawing.Size(149, 17);
            this.labelRefresh.TabIndex = 38;
            this.labelRefresh.Text = "Overlay Refresh Rate:";
            // 
            // btnDisplayOverlay
            // 
            this.btnDisplayOverlay.Enabled = false;
            this.btnDisplayOverlay.Location = new System.Drawing.Point(143, 183);
            this.btnDisplayOverlay.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisplayOverlay.Name = "btnDisplayOverlay";
            this.btnDisplayOverlay.Size = new System.Drawing.Size(100, 28);
            this.btnDisplayOverlay.TabIndex = 35;
            this.btnDisplayOverlay.Text = "Display";
            this.btnDisplayOverlay.UseVisualStyleBackColor = true;
            this.btnDisplayOverlay.Click += new System.EventHandler(this.BtnDisplayOverlay_Click);
            // 
            // rbDirect3D10_1
            // 
            this.rbDirect3D10_1.AutoSize = true;
            this.rbDirect3D10_1.Location = new System.Drawing.Point(120, 130);
            this.rbDirect3D10_1.Margin = new System.Windows.Forms.Padding(4);
            this.rbDirect3D10_1.Name = "rbDirect3D10_1";
            this.rbDirect3D10_1.Size = new System.Drawing.Size(116, 21);
            this.rbDirect3D10_1.TabIndex = 23;
            this.rbDirect3D10_1.Text = "Direct3D 10.1";
            this.rbDirect3D10_1.UseVisualStyleBackColor = true;
            // 
            // rbAutodetect
            // 
            this.rbAutodetect.AutoSize = true;
            this.rbAutodetect.Checked = true;
            this.rbAutodetect.Location = new System.Drawing.Point(9, 101);
            this.rbAutodetect.Margin = new System.Windows.Forms.Padding(4);
            this.rbAutodetect.Name = "rbAutodetect";
            this.rbAutodetect.Size = new System.Drawing.Size(97, 21);
            this.rbAutodetect.TabIndex = 20;
            this.rbAutodetect.TabStop = true;
            this.rbAutodetect.Text = "Autodetect";
            this.rbAutodetect.UseVisualStyleBackColor = true;
            // 
            // cbDrawOverlay
            // 
            this.cbDrawOverlay.AutoSize = true;
            this.cbDrawOverlay.Checked = true;
            this.cbDrawOverlay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDrawOverlay.Location = new System.Drawing.Point(120, 158);
            this.cbDrawOverlay.Margin = new System.Windows.Forms.Padding(4);
            this.cbDrawOverlay.Name = "cbDrawOverlay";
            this.cbDrawOverlay.Size = new System.Drawing.Size(115, 21);
            this.cbDrawOverlay.TabIndex = 26;
            this.cbDrawOverlay.Text = "Draw Overlay";
            this.cbDrawOverlay.UseVisualStyleBackColor = true;
            // 
            // rbDirect3D11
            // 
            this.rbDirect3D11.AutoSize = true;
            this.rbDirect3D11.Location = new System.Drawing.Point(9, 158);
            this.rbDirect3D11.Margin = new System.Windows.Forms.Padding(4);
            this.rbDirect3D11.Name = "rbDirect3D11";
            this.rbDirect3D11.Size = new System.Drawing.Size(104, 21);
            this.rbDirect3D11.TabIndex = 24;
            this.rbDirect3D11.Text = "Direct3D 11";
            this.rbDirect3D11.UseVisualStyleBackColor = true;
            // 
            // rbDirect3D10
            // 
            this.rbDirect3D10.AutoSize = true;
            this.rbDirect3D10.Location = new System.Drawing.Point(9, 130);
            this.rbDirect3D10.Margin = new System.Windows.Forms.Padding(4);
            this.rbDirect3D10.Name = "rbDirect3D10";
            this.rbDirect3D10.Size = new System.Drawing.Size(104, 21);
            this.rbDirect3D10.TabIndex = 22;
            this.rbDirect3D10.Text = "Direct3D 10";
            this.rbDirect3D10.UseVisualStyleBackColor = true;
            // 
            // rbDirect3D9
            // 
            this.rbDirect3D9.AutoSize = true;
            this.rbDirect3D9.Location = new System.Drawing.Point(120, 101);
            this.rbDirect3D9.Margin = new System.Windows.Forms.Padding(4);
            this.rbDirect3D9.Name = "rbDirect3D9";
            this.rbDirect3D9.Size = new System.Drawing.Size(96, 21);
            this.rbDirect3D9.TabIndex = 21;
            this.rbDirect3D9.Text = "Direct3D 9";
            this.rbDirect3D9.UseVisualStyleBackColor = true;
            // 
            // labelApp
            // 
            this.labelApp.AutoSize = true;
            this.labelApp.Location = new System.Drawing.Point(3, 26);
            this.labelApp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelApp.Name = "labelApp";
            this.labelApp.Size = new System.Drawing.Size(228, 17);
            this.labelApp.TabIndex = 17;
            this.labelApp.Text = "EXE Name of Direct3D Application:";
            // 
            // boxApp
            // 
            this.boxApp.Location = new System.Drawing.Point(7, 47);
            this.boxApp.Margin = new System.Windows.Forms.Padding(4);
            this.boxApp.Name = "boxApp";
            this.boxApp.Size = new System.Drawing.Size(129, 22);
            this.boxApp.TabIndex = 6;
            // 
            // btnInject
            // 
            this.btnInject.Location = new System.Drawing.Point(145, 44);
            this.btnInject.Margin = new System.Windows.Forms.Padding(4);
            this.btnInject.Name = "btnInject";
            this.btnInject.Size = new System.Drawing.Size(99, 28);
            this.btnInject.TabIndex = 0;
            this.btnInject.Text = "Inject";
            this.btnInject.UseVisualStyleBackColor = true;
            this.btnInject.Click += new System.EventHandler(this.BtnInject_Click);
            // 
            // labelOverlay
            // 
            this.labelOverlay.AutoSize = true;
            this.labelOverlay.Location = new System.Drawing.Point(50, 3);
            this.labelOverlay.Name = "labelOverlay";
            this.labelOverlay.Size = new System.Drawing.Size(150, 17);
            this.labelOverlay.TabIndex = 46;
            this.labelOverlay.Text = "OVERLAY SETTINGS:";
            // 
            // panelCoords
            // 
            this.panelCoords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCoords.Controls.Add(this.boxColour);
            this.panelCoords.Controls.Add(this.boxSize);
            this.panelCoords.Controls.Add(this.labelSize);
            this.panelCoords.Controls.Add(this.labelColour);
            this.panelCoords.Controls.Add(this.boxPosX);
            this.panelCoords.Controls.Add(this.boxPosY);
            this.panelCoords.Controls.Add(this.labelPos);
            this.panelCoords.Controls.Add(this.labelCoords);
            this.panelCoords.Controls.Add(this.boxZ);
            this.panelCoords.Controls.Add(this.boxY);
            this.panelCoords.Controls.Add(this.boxX);
            this.panelCoords.Controls.Add(this.labelZ);
            this.panelCoords.Controls.Add(this.labelY);
            this.panelCoords.Controls.Add(this.labelX);
            this.panelCoords.Controls.Add(this.labelAddress);
            this.panelCoords.Controls.Add(this.boxAddress);
            this.panelCoords.Location = new System.Drawing.Point(262, 6);
            this.panelCoords.Name = "panelCoords";
            this.panelCoords.Size = new System.Drawing.Size(211, 217);
            this.panelCoords.TabIndex = 47;
            // 
            // boxColour
            // 
            this.boxColour.Location = new System.Drawing.Point(88, 156);
            this.boxColour.Margin = new System.Windows.Forms.Padding(4);
            this.boxColour.Name = "boxColour";
            this.boxColour.Size = new System.Drawing.Size(114, 22);
            this.boxColour.TabIndex = 58;
            this.boxColour.Text = "FFFF0000";
            // 
            // boxSize
            // 
            this.boxSize.Location = new System.Drawing.Point(75, 127);
            this.boxSize.Margin = new System.Windows.Forms.Padding(4);
            this.boxSize.Name = "boxSize";
            this.boxSize.Size = new System.Drawing.Size(127, 22);
            this.boxSize.TabIndex = 57;
            this.boxSize.Text = "20";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(4, 130);
            this.labelSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(70, 17);
            this.labelSize.TabIndex = 56;
            this.labelSize.Text = "Text Size:";
            // 
            // labelColour
            // 
            this.labelColour.AutoSize = true;
            this.labelColour.Location = new System.Drawing.Point(4, 160);
            this.labelColour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelColour.Name = "labelColour";
            this.labelColour.Size = new System.Drawing.Size(84, 17);
            this.labelColour.TabIndex = 55;
            this.labelColour.Text = "Text Colour:";
            // 
            // textBox6
            // 
            this.boxPosX.Location = new System.Drawing.Point(97, 186);
            this.boxPosX.Margin = new System.Windows.Forms.Padding(4);
            this.boxPosX.Name = "textBox6";
            this.boxPosX.Size = new System.Drawing.Size(50, 22);
            this.boxPosX.TabIndex = 54;
            this.boxPosX.Text = "25";
            // 
            // boxPosY
            // 
            this.boxPosY.Location = new System.Drawing.Point(152, 186);
            this.boxPosY.Margin = new System.Windows.Forms.Padding(4);
            this.boxPosY.Name = "boxPosY";
            this.boxPosY.Size = new System.Drawing.Size(50, 22);
            this.boxPosY.TabIndex = 51;
            this.boxPosY.Text = "25";
            // 
            // labelPos
            // 
            this.labelPos.AutoSize = true;
            this.labelPos.Location = new System.Drawing.Point(4, 189);
            this.labelPos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPos.Name = "labelPos";
            this.labelPos.Size = new System.Drawing.Size(93, 17);
            this.labelPos.TabIndex = 48;
            this.labelPos.Text = "Text Position:";
            // 
            // labelCoords
            // 
            this.labelCoords.AutoSize = true;
            this.labelCoords.Location = new System.Drawing.Point(16, 3);
            this.labelCoords.Name = "labelCoords";
            this.labelCoords.Size = new System.Drawing.Size(176, 17);
            this.labelCoords.TabIndex = 47;
            this.labelCoords.Text = "COORDINATE SETTINGS:";
            // 
            // boxZ
            // 
            this.boxZ.Location = new System.Drawing.Point(142, 95);
            this.boxZ.Margin = new System.Windows.Forms.Padding(4);
            this.boxZ.Name = "boxZ";
            this.boxZ.Size = new System.Drawing.Size(60, 22);
            this.boxZ.TabIndex = 45;
            this.boxZ.Text = "78";
            // 
            // boxY
            // 
            this.boxY.Location = new System.Drawing.Point(75, 95);
            this.boxY.Margin = new System.Windows.Forms.Padding(4);
            this.boxY.Name = "boxY";
            this.boxY.Size = new System.Drawing.Size(60, 22);
            this.boxY.TabIndex = 44;
            this.boxY.Text = "74";
            // 
            // boxX
            // 
            this.boxX.Location = new System.Drawing.Point(7, 95);
            this.boxX.Margin = new System.Windows.Forms.Padding(4);
            this.boxX.Name = "boxX";
            this.boxX.Size = new System.Drawing.Size(61, 22);
            this.boxX.TabIndex = 43;
            this.boxX.Text = "70";
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.Location = new System.Drawing.Point(139, 75);
            this.labelZ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(63, 17);
            this.labelZ.TabIndex = 42;
            this.labelZ.Text = "Z Offset:";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(72, 75);
            this.labelY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(63, 17);
            this.labelY.TabIndex = 41;
            this.labelY.Text = "Y Offset:";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(5, 75);
            this.labelX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(63, 17);
            this.labelX.TabIndex = 40;
            this.labelX.Text = "X Offset:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(4, 26);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(200, 17);
            this.labelAddress.TabIndex = 37;
            this.labelAddress.Text = "Hex Offset From Base Module:";
            // 
            // boxAddress
            // 
            this.boxAddress.Location = new System.Drawing.Point(7, 47);
            this.boxAddress.Margin = new System.Windows.Forms.Padding(4);
            this.boxAddress.Name = "boxAddress";
            this.boxAddress.Size = new System.Drawing.Size(195, 22);
            this.boxAddress.TabIndex = 36;
            // 
            // bwOverlayDrawer
            // 
            this.bwOverlayDrawer.WorkerSupportsCancellation = true;
            this.bwOverlayDrawer.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BwOverlayDrawer_DoWork);
            this.bwOverlayDrawer.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BwOverlayDrawer_RunWorkerCompleted);
            // 
            // txtDebugLog
            // 
            this.txtDebugLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDebugLog.Location = new System.Drawing.Point(478, 6);
            this.txtDebugLog.Margin = new System.Windows.Forms.Padding(4);
            this.txtDebugLog.Multiline = true;
            this.txtDebugLog.Name = "txtDebugLog";
            this.txtDebugLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDebugLog.Size = new System.Drawing.Size(481, 217);
            this.txtDebugLog.TabIndex = 16;
            // 
            // WindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 229);
            this.Controls.Add(this.panelCoords);
            this.Controls.Add(this.panelOverlay);
            this.Controls.Add(this.txtDebugLog);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WindowForm";
            this.Text = "3D3 Debug Overlay";
            this.Load += new System.EventHandler(this.WindowForm_Load);
            this.panelOverlay.ResumeLayout(false);
            this.panelOverlay.PerformLayout();
            this.panelCoords.ResumeLayout(false);
            this.panelCoords.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelOverlay;
        private System.Windows.Forms.Panel panelCoords;
        private System.Windows.Forms.Label labelApp;
        private System.Windows.Forms.TextBox boxApp;
        private System.Windows.Forms.Button btnInject;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox boxAddress;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox boxX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.TextBox boxY;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.TextBox boxZ;
        private System.Windows.Forms.Label labelRefresh;
        private System.Windows.Forms.TextBox boxRefresh;
        private System.Windows.Forms.Button btnDisplayOverlay;
        private System.ComponentModel.BackgroundWorker bwOverlayDrawer;
        private System.Windows.Forms.RadioButton rbAutodetect;
        private System.Windows.Forms.RadioButton rbDirect3D9;
        private System.Windows.Forms.RadioButton rbDirect3D10;
        private System.Windows.Forms.RadioButton rbDirect3D10_1;
        private System.Windows.Forms.RadioButton rbDirect3D11;
        private System.Windows.Forms.CheckBox cbDrawOverlay;
        private System.Windows.Forms.TextBox txtDebugLog;
        private System.Windows.Forms.Label labelCoords;
        private System.Windows.Forms.Label labelOverlay;
        private System.Windows.Forms.Button btnStopDisplay;
        private System.Windows.Forms.TextBox boxPosX;
        private System.Windows.Forms.Label labelPos;
        private System.Windows.Forms.TextBox boxPosY;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelColour;
        private System.Windows.Forms.TextBox boxColour;
        private System.Windows.Forms.TextBox boxSize;
    }
}

