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
            this.bwHotkeys = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbFullList = new System.Windows.Forms.CheckBox();
            this.dropdownDoors = new System.Windows.Forms.ComboBox();
            this.cbDoor = new System.Windows.Forms.CheckBox();
            this.cbList = new System.Windows.Forms.CheckBox();
            this.boxZMargin2 = new System.Windows.Forms.TextBox();
            this.boxYMargin2 = new System.Windows.Forms.TextBox();
            this.boxXMargin2 = new System.Windows.Forms.TextBox();
            this.boxDoorColour = new System.Windows.Forms.TextBox();
            this.labelDoorColour = new System.Windows.Forms.Label();
            this.labelDoors = new System.Windows.Forms.Label();
            this.boxZMargin1 = new System.Windows.Forms.TextBox();
            this.boxYMargin1 = new System.Windows.Forms.TextBox();
            this.boxXMargin1 = new System.Windows.Forms.TextBox();
            this.labelDoorZ = new System.Windows.Forms.Label();
            this.labelDoorY = new System.Windows.Forms.Label();
            this.labelDoorX = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelLoad = new System.Windows.Forms.Label();
            this.labelSave = new System.Windows.Forms.Label();
            this.btnSave5 = new System.Windows.Forms.Button();
            this.btnLoad5 = new System.Windows.Forms.Button();
            this.btnSave4 = new System.Windows.Forms.Button();
            this.btnLoad4 = new System.Windows.Forms.Button();
            this.btnSave3 = new System.Windows.Forms.Button();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.btnLoad3 = new System.Windows.Forms.Button();
            this.btnLoad2 = new System.Windows.Forms.Button();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.btnLoad1 = new System.Windows.Forms.Button();
            this.labelPresets = new System.Windows.Forms.Label();
            this.panelOverlay.SuspendLayout();
            this.panelCoords.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.boxApp.TextChanged += new System.EventHandler(this.boxApp_TextChanged);
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
            // boxPosX
            // 
            this.boxPosX.Location = new System.Drawing.Point(97, 186);
            this.boxPosX.Margin = new System.Windows.Forms.Padding(4);
            this.boxPosX.Name = "boxPosX";
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
            this.boxAddress.Text = "00000000";
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
            this.txtDebugLog.Location = new System.Drawing.Point(6, 226);
            this.txtDebugLog.Margin = new System.Windows.Forms.Padding(4);
            this.txtDebugLog.Multiline = true;
            this.txtDebugLog.Name = "txtDebugLog";
            this.txtDebugLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDebugLog.Size = new System.Drawing.Size(862, 123);
            this.txtDebugLog.TabIndex = 16;
            // 
            // bwHotkeys
            // 
            this.bwHotkeys.WorkerSupportsCancellation = true;
            this.bwHotkeys.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BwHotkeys_DoWork);
            this.bwHotkeys.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BwHotkeys_RunWorkerCompleted);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbFullList);
            this.panel1.Controls.Add(this.dropdownDoors);
            this.panel1.Controls.Add(this.cbDoor);
            this.panel1.Controls.Add(this.cbList);
            this.panel1.Controls.Add(this.boxZMargin2);
            this.panel1.Controls.Add(this.boxYMargin2);
            this.panel1.Controls.Add(this.boxXMargin2);
            this.panel1.Controls.Add(this.boxDoorColour);
            this.panel1.Controls.Add(this.labelDoorColour);
            this.panel1.Controls.Add(this.labelDoors);
            this.panel1.Controls.Add(this.boxZMargin1);
            this.panel1.Controls.Add(this.boxYMargin1);
            this.panel1.Controls.Add(this.boxXMargin1);
            this.panel1.Controls.Add(this.labelDoorZ);
            this.panel1.Controls.Add(this.labelDoorY);
            this.panel1.Controls.Add(this.labelDoorX);
            this.panel1.Location = new System.Drawing.Point(479, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 217);
            this.panel1.TabIndex = 59;
            // 
            // cbFullList
            // 
            this.cbFullList.AutoSize = true;
            this.cbFullList.Enabled = false;
            this.cbFullList.Location = new System.Drawing.Point(86, 101);
            this.cbFullList.Margin = new System.Windows.Forms.Padding(4);
            this.cbFullList.Name = "cbFullList";
            this.cbFullList.Size = new System.Drawing.Size(122, 21);
            this.cbFullList.TabIndex = 64;
            this.cbFullList.Text = "Use Entire List";
            this.cbFullList.UseVisualStyleBackColor = true;
            this.cbFullList.CheckedChanged += new System.EventHandler(this.cbFullList_CheckedChanged);
            // 
            // dropdownDoors
            // 
            this.dropdownDoors.Enabled = false;
            this.dropdownDoors.FormattingEnabled = true;
            this.dropdownDoors.Location = new System.Drawing.Point(7, 129);
            this.dropdownDoors.Name = "dropdownDoors";
            this.dropdownDoors.Size = new System.Drawing.Size(195, 24);
            this.dropdownDoors.TabIndex = 63;
            this.dropdownDoors.SelectedIndexChanged += new System.EventHandler(this.dropdownDoors_SelectedIndexChanged);
            // 
            // cbDoor
            // 
            this.cbDoor.AutoSize = true;
            this.cbDoor.Location = new System.Drawing.Point(7, 160);
            this.cbDoor.Margin = new System.Windows.Forms.Padding(4);
            this.cbDoor.Name = "cbDoor";
            this.cbDoor.Size = new System.Drawing.Size(172, 21);
            this.cbDoor.TabIndex = 62;
            this.cbDoor.Text = "Use Door Finding Tool";
            this.cbDoor.UseVisualStyleBackColor = true;
            this.cbDoor.CheckedChanged += new System.EventHandler(this.cbDoor_CheckedChanged);
            // 
            // cbList
            // 
            this.cbList.Enabled = false;
            this.cbList.AutoSize = true;
            this.cbList.Location = new System.Drawing.Point(7, 102);
            this.cbList.Margin = new System.Windows.Forms.Padding(4);
            this.cbList.Name = "cbList";
            this.cbList.Size = new System.Drawing.Size(81, 21);
            this.cbList.TabIndex = 48;
            this.cbList.Text = "Use List";
            this.cbList.UseVisualStyleBackColor = true;
            this.cbList.CheckedChanged += new System.EventHandler(this.cbList_CheckedChanged);
            // 
            // boxZMargin2
            // 
            this.boxZMargin2.Enabled = false;
            this.boxZMargin2.Location = new System.Drawing.Point(142, 72);
            this.boxZMargin2.Margin = new System.Windows.Forms.Padding(4);
            this.boxZMargin2.Name = "boxZMargin2";
            this.boxZMargin2.Size = new System.Drawing.Size(60, 22);
            this.boxZMargin2.TabIndex = 61;
            this.boxZMargin2.Text = "0";
            // 
            // boxYMargin2
            // 
            this.boxYMargin2.Enabled = false;
            this.boxYMargin2.Location = new System.Drawing.Point(75, 72);
            this.boxYMargin2.Margin = new System.Windows.Forms.Padding(4);
            this.boxYMargin2.Name = "boxYMargin2";
            this.boxYMargin2.Size = new System.Drawing.Size(60, 22);
            this.boxYMargin2.TabIndex = 60;
            this.boxYMargin2.Text = "0";
            // 
            // boxXMargin2
            // 
            this.boxXMargin2.Enabled = false;
            this.boxXMargin2.Location = new System.Drawing.Point(7, 72);
            this.boxXMargin2.Margin = new System.Windows.Forms.Padding(4);
            this.boxXMargin2.Name = "boxXMargin2";
            this.boxXMargin2.Size = new System.Drawing.Size(61, 22);
            this.boxXMargin2.TabIndex = 59;
            this.boxXMargin2.Text = "0";
            // 
            // boxDoorColour
            // 
            this.boxDoorColour.Location = new System.Drawing.Point(88, 186);
            this.boxDoorColour.Margin = new System.Windows.Forms.Padding(4);
            this.boxDoorColour.Name = "boxDoorColour";
            this.boxDoorColour.Size = new System.Drawing.Size(114, 22);
            this.boxDoorColour.TabIndex = 58;
            this.boxDoorColour.Text = "FF00FF00";
            // 
            // labelDoorColour
            // 
            this.labelDoorColour.AutoSize = true;
            this.labelDoorColour.Location = new System.Drawing.Point(4, 189);
            this.labelDoorColour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDoorColour.Name = "labelDoorColour";
            this.labelDoorColour.Size = new System.Drawing.Size(84, 17);
            this.labelDoorColour.TabIndex = 55;
            this.labelDoorColour.Text = "Text Colour:";
            // 
            // labelDoors
            // 
            this.labelDoors.AutoSize = true;
            this.labelDoors.Location = new System.Drawing.Point(26, 3);
            this.labelDoors.Name = "labelDoors";
            this.labelDoors.Size = new System.Drawing.Size(156, 17);
            this.labelDoors.TabIndex = 47;
            this.labelDoors.Text = "DOOR FINDING TOOL:";
            // 
            // boxZMargin1
            // 
            this.boxZMargin1.Enabled = false;
            this.boxZMargin1.Location = new System.Drawing.Point(142, 47);
            this.boxZMargin1.Margin = new System.Windows.Forms.Padding(4);
            this.boxZMargin1.Name = "boxZMargin1";
            this.boxZMargin1.Size = new System.Drawing.Size(60, 22);
            this.boxZMargin1.TabIndex = 45;
            this.boxZMargin1.Text = "0";
            // 
            // boxYMargin1
            // 
            this.boxYMargin1.Enabled = false;
            this.boxYMargin1.Location = new System.Drawing.Point(75, 47);
            this.boxYMargin1.Margin = new System.Windows.Forms.Padding(4);
            this.boxYMargin1.Name = "boxYMargin1";
            this.boxYMargin1.Size = new System.Drawing.Size(60, 22);
            this.boxYMargin1.TabIndex = 44;
            this.boxYMargin1.Text = "0";
            // 
            // boxXMargin1
            // 
            this.boxXMargin1.Enabled = false;
            this.boxXMargin1.Location = new System.Drawing.Point(7, 47);
            this.boxXMargin1.Margin = new System.Windows.Forms.Padding(4);
            this.boxXMargin1.Name = "boxXMargin1";
            this.boxXMargin1.Size = new System.Drawing.Size(61, 22);
            this.boxXMargin1.TabIndex = 43;
            this.boxXMargin1.Text = "0";
            // 
            // labelDoorZ
            // 
            this.labelDoorZ.AutoSize = true;
            this.labelDoorZ.Location = new System.Drawing.Point(139, 27);
            this.labelDoorZ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDoorZ.Name = "labelDoorZ";
            this.labelDoorZ.Size = new System.Drawing.Size(68, 17);
            this.labelDoorZ.TabIndex = 42;
            this.labelDoorZ.Text = "Z Margin:";
            // 
            // labelDoorY
            // 
            this.labelDoorY.AutoSize = true;
            this.labelDoorY.Location = new System.Drawing.Point(72, 27);
            this.labelDoorY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDoorY.Name = "labelDoorY";
            this.labelDoorY.Size = new System.Drawing.Size(68, 17);
            this.labelDoorY.TabIndex = 41;
            this.labelDoorY.Text = "Y Margin:";
            // 
            // labelDoorX
            // 
            this.labelDoorX.AutoSize = true;
            this.labelDoorX.Location = new System.Drawing.Point(5, 27);
            this.labelDoorX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDoorX.Name = "labelDoorX";
            this.labelDoorX.Size = new System.Drawing.Size(68, 17);
            this.labelDoorX.TabIndex = 40;
            this.labelDoorX.Text = "X Margin:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labelLoad);
            this.panel2.Controls.Add(this.labelSave);
            this.panel2.Controls.Add(this.btnSave5);
            this.panel2.Controls.Add(this.btnLoad5);
            this.panel2.Controls.Add(this.btnSave4);
            this.panel2.Controls.Add(this.btnLoad4);
            this.panel2.Controls.Add(this.btnSave3);
            this.panel2.Controls.Add(this.btnSave2);
            this.panel2.Controls.Add(this.btnLoad3);
            this.panel2.Controls.Add(this.btnLoad2);
            this.panel2.Controls.Add(this.btnSave1);
            this.panel2.Controls.Add(this.btnLoad1);
            this.panel2.Controls.Add(this.labelPresets);
            this.panel2.Location = new System.Drawing.Point(696, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(172, 217);
            this.panel2.TabIndex = 59;
            // 
            // labelLoad
            // 
            this.labelLoad.AutoSize = true;
            this.labelLoad.Location = new System.Drawing.Point(34, 26);
            this.labelLoad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoad.Name = "labelLoad";
            this.labelLoad.Size = new System.Drawing.Size(44, 17);
            this.labelLoad.TabIndex = 66;
            this.labelLoad.Text = "Load:";
            // 
            // labelSave
            // 
            this.labelSave.AutoSize = true;
            this.labelSave.Location = new System.Drawing.Point(115, 26);
            this.labelSave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSave.Name = "labelSave";
            this.labelSave.Size = new System.Drawing.Size(44, 17);
            this.labelSave.TabIndex = 59;
            this.labelSave.Text = "Save:";
            // 
            // btnSave5
            // 
            this.btnSave5.Location = new System.Drawing.Point(108, 183);
            this.btnSave5.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave5.Name = "btnSave5";
            this.btnSave5.Size = new System.Drawing.Size(58, 28);
            this.btnSave5.TabIndex = 65;
            this.btnSave5.Text = "Save";
            this.btnSave5.UseVisualStyleBackColor = true;
            this.btnSave5.Click += new System.EventHandler(this.BtnSave5_Click);
            // 
            // btnLoad5
            // 
            this.btnLoad5.Location = new System.Drawing.Point(4, 183);
            this.btnLoad5.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoad5.Name = "btnLoad5";
            this.btnLoad5.Size = new System.Drawing.Size(100, 28);
            this.btnLoad5.TabIndex = 64;
            this.btnLoad5.Text = "Slot 5";
            this.btnLoad5.UseVisualStyleBackColor = true;
            this.btnLoad5.Click += new System.EventHandler(this.BtnLoad5_Click);
            // 
            // btnSave4
            // 
            this.btnSave4.Location = new System.Drawing.Point(108, 149);
            this.btnSave4.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave4.Name = "btnSave4";
            this.btnSave4.Size = new System.Drawing.Size(58, 28);
            this.btnSave4.TabIndex = 63;
            this.btnSave4.Text = "Save";
            this.btnSave4.UseVisualStyleBackColor = true;
            this.btnSave4.Click += new System.EventHandler(this.BtnSave4_Click);
            // 
            // btnLoad4
            // 
            this.btnLoad4.Location = new System.Drawing.Point(4, 149);
            this.btnLoad4.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoad4.Name = "btnLoad4";
            this.btnLoad4.Size = new System.Drawing.Size(100, 28);
            this.btnLoad4.TabIndex = 62;
            this.btnLoad4.Text = "Slot 4";
            this.btnLoad4.UseVisualStyleBackColor = true;
            this.btnLoad4.Click += new System.EventHandler(this.BtnLoad4_Click);
            // 
            // btnSave3
            // 
            this.btnSave3.Location = new System.Drawing.Point(108, 115);
            this.btnSave3.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave3.Name = "btnSave3";
            this.btnSave3.Size = new System.Drawing.Size(58, 28);
            this.btnSave3.TabIndex = 61;
            this.btnSave3.Text = "Save";
            this.btnSave3.UseVisualStyleBackColor = true;
            this.btnSave3.Click += new System.EventHandler(this.BtnSave3_Click);
            // 
            // btnSave2
            // 
            this.btnSave2.Location = new System.Drawing.Point(108, 81);
            this.btnSave2.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(58, 28);
            this.btnSave2.TabIndex = 51;
            this.btnSave2.Text = "Save";
            this.btnSave2.UseVisualStyleBackColor = true;
            this.btnSave2.Click += new System.EventHandler(this.BtnSave2_Click);
            // 
            // btnLoad3
            // 
            this.btnLoad3.Location = new System.Drawing.Point(4, 115);
            this.btnLoad3.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoad3.Name = "btnLoad3";
            this.btnLoad3.Size = new System.Drawing.Size(100, 28);
            this.btnLoad3.TabIndex = 60;
            this.btnLoad3.Text = "Slot 3";
            this.btnLoad3.UseVisualStyleBackColor = true;
            this.btnLoad3.Click += new System.EventHandler(this.BtnLoad3_Click);
            // 
            // btnLoad2
            // 
            this.btnLoad2.Location = new System.Drawing.Point(4, 81);
            this.btnLoad2.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoad2.Name = "btnLoad2";
            this.btnLoad2.Size = new System.Drawing.Size(100, 28);
            this.btnLoad2.TabIndex = 50;
            this.btnLoad2.Text = "Slot 2";
            this.btnLoad2.UseVisualStyleBackColor = true;
            this.btnLoad2.Click += new System.EventHandler(this.BtnLoad2_Click);
            // 
            // btnSave1
            // 
            this.btnSave1.Location = new System.Drawing.Point(108, 47);
            this.btnSave1.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(58, 28);
            this.btnSave1.TabIndex = 49;
            this.btnSave1.Text = "Save";
            this.btnSave1.UseVisualStyleBackColor = true;
            this.btnSave1.Click += new System.EventHandler(this.BtnSave1_Click);
            // 
            // btnLoad1
            // 
            this.btnLoad1.Location = new System.Drawing.Point(4, 47);
            this.btnLoad1.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoad1.Name = "btnLoad1";
            this.btnLoad1.Size = new System.Drawing.Size(100, 28);
            this.btnLoad1.TabIndex = 48;
            this.btnLoad1.Text = "Slot 1";
            this.btnLoad1.UseVisualStyleBackColor = true;
            this.btnLoad1.Click += new System.EventHandler(this.BtnLoad1_Click);
            // 
            // labelPresets
            // 
            this.labelPresets.AutoSize = true;
            this.labelPresets.Location = new System.Drawing.Point(17, 3);
            this.labelPresets.Name = "labelPresets";
            this.labelPresets.Size = new System.Drawing.Size(140, 17);
            this.labelPresets.TabIndex = 47;
            this.labelPresets.Text = "SETTING PRESETS:";
            // 
            // WindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 353);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.ComponentModel.BackgroundWorker bwHotkeys;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox boxDoorColour;
        private System.Windows.Forms.Label labelDoorColour;
        private System.Windows.Forms.Label labelDoors;
        private System.Windows.Forms.TextBox boxZMargin1;
        private System.Windows.Forms.TextBox boxYMargin1;
        private System.Windows.Forms.TextBox boxXMargin1;
        private System.Windows.Forms.Label labelDoorZ;
        private System.Windows.Forms.Label labelDoorY;
        private System.Windows.Forms.Label labelDoorX;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelPresets;
        private System.Windows.Forms.TextBox boxZMargin2;
        private System.Windows.Forms.TextBox boxYMargin2;
        private System.Windows.Forms.TextBox boxXMargin2;
        private System.Windows.Forms.Label labelLoad;
        private System.Windows.Forms.Label labelSave;
        private System.Windows.Forms.Button btnSave5;
        private System.Windows.Forms.Button btnSave4;
        private System.Windows.Forms.Button btnLoad4;
        private System.Windows.Forms.Button btnSave3;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.Button btnLoad3;
        private System.Windows.Forms.Button btnLoad2;
        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.Button btnLoad1;
        private System.Windows.Forms.CheckBox cbDoor;
        private System.Windows.Forms.CheckBox cbList;
        private System.Windows.Forms.CheckBox cbFullList;
        private System.Windows.Forms.ComboBox dropdownDoors;
        private System.Windows.Forms.Button btnLoad5;
    }
}

