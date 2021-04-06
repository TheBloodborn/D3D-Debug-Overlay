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
            this.labelApp = new System.Windows.Forms.Label();
            this.boxApp = new System.Windows.Forms.TextBox();
            this.btnInject = new System.Windows.Forms.Button();
            this.labelAddress = new System.Windows.Forms.Label();
            this.boxAddress = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.boxX = new System.Windows.Forms.TextBox();
            this.labelY = new System.Windows.Forms.Label();
            this.boxY = new System.Windows.Forms.TextBox();
            this.labelZ = new System.Windows.Forms.Label();
            this.boxZ = new System.Windows.Forms.TextBox();
            this.labelRefresh = new System.Windows.Forms.Label();
            this.boxRefresh = new System.Windows.Forms.TextBox();
            this.btnDisplayOverlay = new System.Windows.Forms.Button();
            this.bwOverlayDrawer = new System.ComponentModel.BackgroundWorker();
            this.rbAutodetect = new System.Windows.Forms.RadioButton();
            this.rbDirect3D9 = new System.Windows.Forms.RadioButton();
            this.rbDirect3D10 = new System.Windows.Forms.RadioButton();
            this.rbDirect3D10_1 = new System.Windows.Forms.RadioButton();
            this.rbDirect3D11 = new System.Windows.Forms.RadioButton();
            this.cbDrawOverlay = new System.Windows.Forms.CheckBox();
            this.txtDebugLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelApp
            // 
            this.labelApp.AutoSize = true;
            this.labelApp.Location = new System.Drawing.Point(7, 7);
            this.labelApp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelApp.Name = "labelApp";
            this.labelApp.Size = new System.Drawing.Size(228, 17);
            this.labelApp.TabIndex = 17;
            this.labelApp.Text = "EXE Name of Direct3D Application:";
            // 
            // boxApp
            // 
            this.boxApp.Location = new System.Drawing.Point(11, 28);
            this.boxApp.Margin = new System.Windows.Forms.Padding(4);
            this.boxApp.Name = "boxApp";
            this.boxApp.Size = new System.Drawing.Size(129, 22);
            this.boxApp.TabIndex = 6;
            // 
            // btnInject
            // 
            this.btnInject.Location = new System.Drawing.Point(149, 25);
            this.btnInject.Margin = new System.Windows.Forms.Padding(4);
            this.btnInject.Name = "btnInject";
            this.btnInject.Size = new System.Drawing.Size(99, 28);
            this.btnInject.TabIndex = 0;
            this.btnInject.Text = "Inject";
            this.btnInject.UseVisualStyleBackColor = true;
            this.btnInject.Click += new System.EventHandler(this.BtnInject_Click);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(8, 54);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(200, 17);
            this.labelAddress.TabIndex = 37;
            this.labelAddress.Text = "Hex Offset From Base Module:";
            // 
            // boxAddress
            // 
            this.boxAddress.Location = new System.Drawing.Point(10, 75);
            this.boxAddress.Margin = new System.Windows.Forms.Padding(4);
            this.boxAddress.Name = "boxAddress";
            this.boxAddress.Size = new System.Drawing.Size(129, 22);
            this.boxAddress.TabIndex = 36;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(8, 102);
            this.labelX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(63, 17);
            this.labelX.TabIndex = 40;
            this.labelX.Text = "X Offset:";
            // 
            // boxX
            // 
            this.boxX.Location = new System.Drawing.Point(10, 122);
            this.boxX.Margin = new System.Windows.Forms.Padding(4);
            this.boxX.Name = "boxX";
            this.boxX.Size = new System.Drawing.Size(73, 22);
            this.boxX.TabIndex = 43;
            this.boxX.Text = "70";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(88, 102);
            this.labelY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(63, 17);
            this.labelY.TabIndex = 41;
            this.labelY.Text = "Y Offset:";
            // 
            // boxY
            // 
            this.boxY.Location = new System.Drawing.Point(91, 122);
            this.boxY.Margin = new System.Windows.Forms.Padding(4);
            this.boxY.Name = "boxY";
            this.boxY.Size = new System.Drawing.Size(74, 22);
            this.boxY.TabIndex = 44;
            this.boxY.Text = "74";
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.Location = new System.Drawing.Point(170, 102);
            this.labelZ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(63, 17);
            this.labelZ.TabIndex = 42;
            this.labelZ.Text = "Z Offset:";
            // 
            // boxZ
            // 
            this.boxZ.Location = new System.Drawing.Point(173, 122);
            this.boxZ.Margin = new System.Windows.Forms.Padding(4);
            this.boxZ.Name = "boxZ";
            this.boxZ.Size = new System.Drawing.Size(72, 22);
            this.boxZ.TabIndex = 45;
            this.boxZ.Text = "78";
            // 
            // labelRefresh
            // 
            this.labelRefresh.AutoSize = true;
            this.labelRefresh.Location = new System.Drawing.Point(5, 152);
            this.labelRefresh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRefresh.Name = "labelRefresh";
            this.labelRefresh.Size = new System.Drawing.Size(149, 17);
            this.labelRefresh.TabIndex = 38;
            this.labelRefresh.Text = "Overlay Refresh Rate:";
            // 
            // boxRefresh
            // 
            this.boxRefresh.Location = new System.Drawing.Point(154, 150);
            this.boxRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.boxRefresh.Name = "boxRefresh";
            this.boxRefresh.Size = new System.Drawing.Size(91, 22);
            this.boxRefresh.TabIndex = 39;
            this.boxRefresh.Text = "200";
            // 
            // btnDisplayOverlay
            // 
            this.btnDisplayOverlay.Location = new System.Drawing.Point(149, 73);
            this.btnDisplayOverlay.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisplayOverlay.Name = "btnDisplayOverlay";
            this.btnDisplayOverlay.Size = new System.Drawing.Size(100, 28);
            this.btnDisplayOverlay.TabIndex = 35;
            this.btnDisplayOverlay.Text = "Display";
            this.btnDisplayOverlay.UseVisualStyleBackColor = true;
            this.btnDisplayOverlay.Click += new System.EventHandler(this.BtnDisplayOverlay_Click);
            // 
            // bwOverlayDrawer
            // 
            this.bwOverlayDrawer.WorkerSupportsCancellation = true;
            this.bwOverlayDrawer.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BwOverlayDrawer_DoWork);
            this.bwOverlayDrawer.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BwOverlayDrawer_RunWorkerCompleted);
            // 
            // rbAutodetect
            // 
            this.rbAutodetect.AutoSize = true;
            this.rbAutodetect.Checked = true;
            this.rbAutodetect.Location = new System.Drawing.Point(11, 175);
            this.rbAutodetect.Margin = new System.Windows.Forms.Padding(4);
            this.rbAutodetect.Name = "rbAutodetect";
            this.rbAutodetect.Size = new System.Drawing.Size(97, 21);
            this.rbAutodetect.TabIndex = 20;
            this.rbAutodetect.TabStop = true;
            this.rbAutodetect.Text = "Autodetect";
            this.rbAutodetect.UseVisualStyleBackColor = true;
            // 
            // rbDirect3D9
            // 
            this.rbDirect3D9.AutoSize = true;
            this.rbDirect3D9.Location = new System.Drawing.Point(122, 175);
            this.rbDirect3D9.Margin = new System.Windows.Forms.Padding(4);
            this.rbDirect3D9.Name = "rbDirect3D9";
            this.rbDirect3D9.Size = new System.Drawing.Size(96, 21);
            this.rbDirect3D9.TabIndex = 21;
            this.rbDirect3D9.Text = "Direct3D 9";
            this.rbDirect3D9.UseVisualStyleBackColor = true;
            // 
            // rbDirect3D10
            // 
            this.rbDirect3D10.AutoSize = true;
            this.rbDirect3D10.Location = new System.Drawing.Point(11, 204);
            this.rbDirect3D10.Margin = new System.Windows.Forms.Padding(4);
            this.rbDirect3D10.Name = "rbDirect3D10";
            this.rbDirect3D10.Size = new System.Drawing.Size(104, 21);
            this.rbDirect3D10.TabIndex = 22;
            this.rbDirect3D10.Text = "Direct3D 10";
            this.rbDirect3D10.UseVisualStyleBackColor = true;
            // 
            // rbDirect3D10_1
            // 
            this.rbDirect3D10_1.AutoSize = true;
            this.rbDirect3D10_1.Location = new System.Drawing.Point(122, 204);
            this.rbDirect3D10_1.Margin = new System.Windows.Forms.Padding(4);
            this.rbDirect3D10_1.Name = "rbDirect3D10_1";
            this.rbDirect3D10_1.Size = new System.Drawing.Size(116, 21);
            this.rbDirect3D10_1.TabIndex = 23;
            this.rbDirect3D10_1.Text = "Direct3D 10.1";
            this.rbDirect3D10_1.UseVisualStyleBackColor = true;
            // 
            // rbDirect3D11
            // 
            this.rbDirect3D11.AutoSize = true;
            this.rbDirect3D11.Location = new System.Drawing.Point(11, 232);
            this.rbDirect3D11.Margin = new System.Windows.Forms.Padding(4);
            this.rbDirect3D11.Name = "rbDirect3D11";
            this.rbDirect3D11.Size = new System.Drawing.Size(104, 21);
            this.rbDirect3D11.TabIndex = 24;
            this.rbDirect3D11.Text = "Direct3D 11";
            this.rbDirect3D11.UseVisualStyleBackColor = true;
            // 
            // cbDrawOverlay
            // 
            this.cbDrawOverlay.AutoSize = true;
            this.cbDrawOverlay.Checked = true;
            this.cbDrawOverlay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDrawOverlay.Location = new System.Drawing.Point(122, 232);
            this.cbDrawOverlay.Margin = new System.Windows.Forms.Padding(4);
            this.cbDrawOverlay.Name = "cbDrawOverlay";
            this.cbDrawOverlay.Size = new System.Drawing.Size(115, 21);
            this.cbDrawOverlay.TabIndex = 26;
            this.cbDrawOverlay.Text = "Draw Overlay";
            this.cbDrawOverlay.UseVisualStyleBackColor = true;
            // 
            // txtDebugLog
            // 
            this.txtDebugLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDebugLog.Location = new System.Drawing.Point(257, 7);
            this.txtDebugLog.Margin = new System.Windows.Forms.Padding(4);
            this.txtDebugLog.Multiline = true;
            this.txtDebugLog.Name = "txtDebugLog";
            this.txtDebugLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDebugLog.Size = new System.Drawing.Size(652, 243);
            this.txtDebugLog.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 258);
            this.Controls.Add(this.boxZ);
            this.Controls.Add(this.boxY);
            this.Controls.Add(this.boxX);
            this.Controls.Add(this.labelZ);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.boxRefresh);
            this.Controls.Add(this.labelRefresh);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.boxAddress);
            this.Controls.Add(this.btnDisplayOverlay);
            this.Controls.Add(this.rbDirect3D10_1);
            this.Controls.Add(this.rbAutodetect);
            this.Controls.Add(this.cbDrawOverlay);
            this.Controls.Add(this.rbDirect3D11);
            this.Controls.Add(this.rbDirect3D10);
            this.Controls.Add(this.rbDirect3D9);
            this.Controls.Add(this.labelApp);
            this.Controls.Add(this.txtDebugLog);
            this.Controls.Add(this.boxApp);
            this.Controls.Add(this.btnInject);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "3D3 Debug Overlay";
            this.Load += new System.EventHandler(this.WindowForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
    }
}

