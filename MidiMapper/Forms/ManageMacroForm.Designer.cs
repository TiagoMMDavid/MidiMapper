namespace MidiMapper.Forms
{
    partial class ManageMacroForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.aSharpButton = new System.Windows.Forms.Button();
            this.gSharpButton = new System.Windows.Forms.Button();
            this.fSharpButton = new System.Windows.Forms.Button();
            this.dSharpButton = new System.Windows.Forms.Button();
            this.cSharpButton = new System.Windows.Forms.Button();
            this.bButton = new System.Windows.Forms.Button();
            this.aButton = new System.Windows.Forms.Button();
            this.gButton = new System.Windows.Forms.Button();
            this.fButton = new System.Windows.Forms.Button();
            this.eButton = new System.Windows.Forms.Button();
            this.dButton = new System.Windows.Forms.Button();
            this.cButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.macroNameTextBox = new System.Windows.Forms.TextBox();
            this.macroNameLabel = new System.Windows.Forms.Label();
            this.noteNameLabel = new System.Windows.Forms.Label();
            this.octaveLabel = new System.Windows.Forms.Label();
            this.noteNameListBox = new System.Windows.Forms.ComboBox();
            this.pitchLabel = new System.Windows.Forms.Label();
            this.octaveListBox = new System.Windows.Forms.ComboBox();
            this.deleteMacroButton = new System.Windows.Forms.Button();
            this.keyboardKeysListBox = new System.Windows.Forms.ComboBox();
            this.keyboardPressRadioButton = new System.Windows.Forms.RadioButton();
            this.macroTypePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.mousePressRadioButton = new System.Windows.Forms.RadioButton();
            this.mouseMoveRadioButton = new System.Windows.Forms.RadioButton();
            this.mouseMoveX = new System.Windows.Forms.NumericUpDown();
            this.mouseMoveY = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.macroTypePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mouseMoveX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouseMoveY)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.aSharpButton);
            this.panel1.Controls.Add(this.gSharpButton);
            this.panel1.Controls.Add(this.fSharpButton);
            this.panel1.Controls.Add(this.dSharpButton);
            this.panel1.Controls.Add(this.cSharpButton);
            this.panel1.Controls.Add(this.bButton);
            this.panel1.Controls.Add(this.aButton);
            this.panel1.Controls.Add(this.gButton);
            this.panel1.Controls.Add(this.fButton);
            this.panel1.Controls.Add(this.eButton);
            this.panel1.Controls.Add(this.dButton);
            this.panel1.Controls.Add(this.cButton);
            this.panel1.Location = new System.Drawing.Point(225, 469);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 200);
            this.panel1.TabIndex = 2;
            // 
            // aSharpButton
            // 
            this.aSharpButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.aSharpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aSharpButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.aSharpButton.Location = new System.Drawing.Point(362, 0);
            this.aSharpButton.Name = "aSharpButton";
            this.aSharpButton.Size = new System.Drawing.Size(41, 120);
            this.aSharpButton.TabIndex = 14;
            this.aSharpButton.Text = "A#";
            this.aSharpButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.aSharpButton.UseVisualStyleBackColor = false;
            this.aSharpButton.Click += new System.EventHandler(this.ASharpButton_Click);
            // 
            // gSharpButton
            // 
            this.gSharpButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gSharpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gSharpButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gSharpButton.Location = new System.Drawing.Point(295, 0);
            this.gSharpButton.Name = "gSharpButton";
            this.gSharpButton.Size = new System.Drawing.Size(42, 120);
            this.gSharpButton.TabIndex = 13;
            this.gSharpButton.Text = "G#";
            this.gSharpButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gSharpButton.UseVisualStyleBackColor = false;
            this.gSharpButton.Click += new System.EventHandler(this.GSharpButton_Click);
            // 
            // fSharpButton
            // 
            this.fSharpButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fSharpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fSharpButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fSharpButton.Location = new System.Drawing.Point(232, 0);
            this.fSharpButton.Name = "fSharpButton";
            this.fSharpButton.Size = new System.Drawing.Size(41, 120);
            this.fSharpButton.TabIndex = 12;
            this.fSharpButton.Text = "F#";
            this.fSharpButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.fSharpButton.UseVisualStyleBackColor = false;
            this.fSharpButton.Click += new System.EventHandler(this.FSharpButton_Click);
            // 
            // dSharpButton
            // 
            this.dSharpButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dSharpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dSharpButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dSharpButton.Location = new System.Drawing.Point(105, 0);
            this.dSharpButton.Name = "dSharpButton";
            this.dSharpButton.Size = new System.Drawing.Size(41, 120);
            this.dSharpButton.TabIndex = 11;
            this.dSharpButton.Text = "D#";
            this.dSharpButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dSharpButton.UseVisualStyleBackColor = false;
            this.dSharpButton.Click += new System.EventHandler(this.DSharpButton_Click);
            // 
            // cSharpButton
            // 
            this.cSharpButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cSharpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cSharpButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cSharpButton.Location = new System.Drawing.Point(40, 0);
            this.cSharpButton.Name = "cSharpButton";
            this.cSharpButton.Size = new System.Drawing.Size(41, 120);
            this.cSharpButton.TabIndex = 10;
            this.cSharpButton.Text = "C#";
            this.cSharpButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cSharpButton.UseVisualStyleBackColor = false;
            this.cSharpButton.Click += new System.EventHandler(this.CSharpButton_Click);
            // 
            // bButton
            // 
            this.bButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bButton.Location = new System.Drawing.Point(381, 0);
            this.bButton.Name = "bButton";
            this.bButton.Size = new System.Drawing.Size(57, 199);
            this.bButton.TabIndex = 9;
            this.bButton.Text = "B";
            this.bButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bButton.UseVisualStyleBackColor = false;
            this.bButton.Click += new System.EventHandler(this.BButton_Click);
            // 
            // aButton
            // 
            this.aButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.aButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aButton.Location = new System.Drawing.Point(318, 0);
            this.aButton.Name = "aButton";
            this.aButton.Size = new System.Drawing.Size(57, 199);
            this.aButton.TabIndex = 8;
            this.aButton.Text = "A";
            this.aButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.aButton.UseVisualStyleBackColor = false;
            this.aButton.Click += new System.EventHandler(this.AButton_Click);
            // 
            // gButton
            // 
            this.gButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gButton.Location = new System.Drawing.Point(255, 0);
            this.gButton.Name = "gButton";
            this.gButton.Size = new System.Drawing.Size(57, 199);
            this.gButton.TabIndex = 7;
            this.gButton.Text = "G";
            this.gButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gButton.UseVisualStyleBackColor = false;
            this.gButton.Click += new System.EventHandler(this.GButton_Click);
            // 
            // fButton
            // 
            this.fButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fButton.Location = new System.Drawing.Point(192, 0);
            this.fButton.Name = "fButton";
            this.fButton.Size = new System.Drawing.Size(57, 199);
            this.fButton.TabIndex = 6;
            this.fButton.Text = "F";
            this.fButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.fButton.UseVisualStyleBackColor = false;
            this.fButton.Click += new System.EventHandler(this.FButton_Click);
            // 
            // eButton
            // 
            this.eButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.eButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eButton.Location = new System.Drawing.Point(129, 0);
            this.eButton.Name = "eButton";
            this.eButton.Size = new System.Drawing.Size(57, 199);
            this.eButton.TabIndex = 5;
            this.eButton.Text = "E";
            this.eButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.eButton.UseVisualStyleBackColor = false;
            this.eButton.Click += new System.EventHandler(this.EButton_Click);
            // 
            // dButton
            // 
            this.dButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dButton.Location = new System.Drawing.Point(66, 0);
            this.dButton.Name = "dButton";
            this.dButton.Size = new System.Drawing.Size(57, 199);
            this.dButton.TabIndex = 4;
            this.dButton.Text = "D";
            this.dButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dButton.UseVisualStyleBackColor = false;
            this.dButton.Click += new System.EventHandler(this.DButton_Click);
            // 
            // cButton
            // 
            this.cButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cButton.Location = new System.Drawing.Point(3, 0);
            this.cButton.Name = "cButton";
            this.cButton.Size = new System.Drawing.Size(57, 199);
            this.cButton.TabIndex = 3;
            this.cButton.Text = "C";
            this.cButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cButton.UseVisualStyleBackColor = false;
            this.cButton.Click += new System.EventHandler(this.CButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(170, 734);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(114, 47);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(50, 734);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(114, 47);
            this.okButton.TabIndex = 15;
            this.okButton.Text = "Create Macro";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // macroNameTextBox
            // 
            this.macroNameTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macroNameTextBox.Location = new System.Drawing.Point(237, 86);
            this.macroNameTextBox.Name = "macroNameTextBox";
            this.macroNameTextBox.Size = new System.Drawing.Size(221, 26);
            this.macroNameTextBox.TabIndex = 17;
            this.macroNameTextBox.Text = "New Macro";
            // 
            // macroNameLabel
            // 
            this.macroNameLabel.AutoSize = true;
            this.macroNameLabel.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macroNameLabel.Location = new System.Drawing.Point(135, 88);
            this.macroNameLabel.Name = "macroNameLabel";
            this.macroNameLabel.Size = new System.Drawing.Size(100, 21);
            this.macroNameLabel.TabIndex = 18;
            this.macroNameLabel.Text = "Macro Name";
            // 
            // noteNameLabel
            // 
            this.noteNameLabel.AutoSize = true;
            this.noteNameLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteNameLabel.Location = new System.Drawing.Point(621, 438);
            this.noteNameLabel.Name = "noteNameLabel";
            this.noteNameLabel.Size = new System.Drawing.Size(34, 26);
            this.noteNameLabel.TabIndex = 20;
            this.noteNameLabel.Text = "C4";
            // 
            // octaveLabel
            // 
            this.octaveLabel.AutoSize = true;
            this.octaveLabel.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.octaveLabel.Location = new System.Drawing.Point(342, 440);
            this.octaveLabel.Name = "octaveLabel";
            this.octaveLabel.Size = new System.Drawing.Size(58, 21);
            this.octaveLabel.TabIndex = 21;
            this.octaveLabel.Text = "Octave";
            // 
            // noteNameListBox
            // 
            this.noteNameListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.noteNameListBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteNameListBox.FormattingEnabled = true;
            this.noteNameListBox.Items.AddRange(new object[] {
            "C",
            "C#",
            "D",
            "D#",
            "E",
            "F",
            "F#",
            "G",
            "G#",
            "A",
            "A#",
            "B"});
            this.noteNameListBox.Location = new System.Drawing.Point(277, 438);
            this.noteNameListBox.MaxLength = 2;
            this.noteNameListBox.Name = "noteNameListBox";
            this.noteNameListBox.Size = new System.Drawing.Size(56, 26);
            this.noteNameListBox.TabIndex = 22;
            // 
            // pitchLabel
            // 
            this.pitchLabel.AutoSize = true;
            this.pitchLabel.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pitchLabel.Location = new System.Drawing.Point(230, 441);
            this.pitchLabel.Name = "pitchLabel";
            this.pitchLabel.Size = new System.Drawing.Size(44, 21);
            this.pitchLabel.TabIndex = 23;
            this.pitchLabel.Text = "Note";
            // 
            // octaveListBox
            // 
            this.octaveListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.octaveListBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.octaveListBox.FormattingEnabled = true;
            this.octaveListBox.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.octaveListBox.Location = new System.Drawing.Point(402, 437);
            this.octaveListBox.MaxLength = 2;
            this.octaveListBox.Name = "octaveListBox";
            this.octaveListBox.Size = new System.Drawing.Size(56, 26);
            this.octaveListBox.TabIndex = 24;
            this.octaveListBox.SelectedIndexChanged += new System.EventHandler(this.OctaveListBox_SelectedIndexChanged);
            // 
            // deleteMacroButton
            // 
            this.deleteMacroButton.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteMacroButton.Location = new System.Drawing.Point(678, 734);
            this.deleteMacroButton.Name = "deleteMacroButton";
            this.deleteMacroButton.Size = new System.Drawing.Size(114, 47);
            this.deleteMacroButton.TabIndex = 25;
            this.deleteMacroButton.Text = "Delete Macro";
            this.deleteMacroButton.UseVisualStyleBackColor = true;
            this.deleteMacroButton.Visible = false;
            this.deleteMacroButton.Click += new System.EventHandler(this.DeleteMacroButton_Click);
            // 
            // keyboardKeysListBox
            // 
            this.keyboardKeysListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.keyboardKeysListBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyboardKeysListBox.FormattingEnabled = true;
            this.keyboardKeysListBox.IntegralHeight = false;
            this.keyboardKeysListBox.Location = new System.Drawing.Point(291, 166);
            this.keyboardKeysListBox.MaxDropDownItems = 15;
            this.keyboardKeysListBox.MaxLength = 2;
            this.keyboardKeysListBox.Name = "keyboardKeysListBox";
            this.keyboardKeysListBox.Size = new System.Drawing.Size(256, 26);
            this.keyboardKeysListBox.TabIndex = 26;
            // 
            // keyboardPressRadioButton
            // 
            this.keyboardPressRadioButton.AutoSize = true;
            this.keyboardPressRadioButton.Checked = true;
            this.keyboardPressRadioButton.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyboardPressRadioButton.Location = new System.Drawing.Point(3, 3);
            this.keyboardPressRadioButton.Name = "keyboardPressRadioButton";
            this.keyboardPressRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.keyboardPressRadioButton.Size = new System.Drawing.Size(135, 25);
            this.keyboardPressRadioButton.TabIndex = 27;
            this.keyboardPressRadioButton.TabStop = true;
            this.keyboardPressRadioButton.Text = "Keyboard Press";
            this.keyboardPressRadioButton.UseVisualStyleBackColor = true;
            this.keyboardPressRadioButton.CheckedChanged += new System.EventHandler(this.KeyboardPressRadioButton_CheckedChanged);
            // 
            // macroTypePanel
            // 
            this.macroTypePanel.Controls.Add(this.keyboardPressRadioButton);
            this.macroTypePanel.Controls.Add(this.mousePressRadioButton);
            this.macroTypePanel.Controls.Add(this.mouseMoveRadioButton);
            this.macroTypePanel.Location = new System.Drawing.Point(74, 164);
            this.macroTypePanel.Name = "macroTypePanel";
            this.macroTypePanel.Size = new System.Drawing.Size(200, 104);
            this.macroTypePanel.TabIndex = 29;
            // 
            // mousePressRadioButton
            // 
            this.mousePressRadioButton.AutoSize = true;
            this.mousePressRadioButton.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mousePressRadioButton.Location = new System.Drawing.Point(3, 34);
            this.mousePressRadioButton.Name = "mousePressRadioButton";
            this.mousePressRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mousePressRadioButton.Size = new System.Drawing.Size(117, 25);
            this.mousePressRadioButton.TabIndex = 28;
            this.mousePressRadioButton.Text = "Mouse Press";
            this.mousePressRadioButton.UseVisualStyleBackColor = true;
            this.mousePressRadioButton.CheckedChanged += new System.EventHandler(this.MousePressRadioButton_CheckedChanged);
            // 
            // mouseMoveRadioButton
            // 
            this.mouseMoveRadioButton.AutoSize = true;
            this.mouseMoveRadioButton.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mouseMoveRadioButton.Location = new System.Drawing.Point(3, 65);
            this.mouseMoveRadioButton.Name = "mouseMoveRadioButton";
            this.mouseMoveRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mouseMoveRadioButton.Size = new System.Drawing.Size(157, 25);
            this.mouseMoveRadioButton.TabIndex = 29;
            this.mouseMoveRadioButton.Text = "Mouse Movement";
            this.mouseMoveRadioButton.UseVisualStyleBackColor = true;
            this.mouseMoveRadioButton.CheckedChanged += new System.EventHandler(this.MouseMoveRadioButton_CheckedChanged);
            // 
            // mouseMoveX
            // 
            this.mouseMoveX.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mouseMoveX.Location = new System.Drawing.Point(330, 228);
            this.mouseMoveX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.mouseMoveX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.mouseMoveX.Name = "mouseMoveX";
            this.mouseMoveX.Size = new System.Drawing.Size(65, 26);
            this.mouseMoveX.TabIndex = 30;
            this.mouseMoveX.Visible = false;
            // 
            // mouseMoveY
            // 
            this.mouseMoveY.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mouseMoveY.Location = new System.Drawing.Point(409, 228);
            this.mouseMoveY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.mouseMoveY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.mouseMoveY.Name = "mouseMoveY";
            this.mouseMoveY.Size = new System.Drawing.Size(65, 26);
            this.mouseMoveY.TabIndex = 31;
            this.mouseMoveY.Visible = false;
            // 
            // ManageMacroForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(822, 806);
            this.Controls.Add(this.mouseMoveY);
            this.Controls.Add(this.mouseMoveX);
            this.Controls.Add(this.macroTypePanel);
            this.Controls.Add(this.keyboardKeysListBox);
            this.Controls.Add(this.deleteMacroButton);
            this.Controls.Add(this.octaveListBox);
            this.Controls.Add(this.pitchLabel);
            this.Controls.Add(this.noteNameListBox);
            this.Controls.Add(this.octaveLabel);
            this.Controls.Add(this.noteNameLabel);
            this.Controls.Add(this.macroNameLabel);
            this.Controls.Add(this.macroNameTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ManageMacroForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MidiMapper - Customize Macro";
            this.panel1.ResumeLayout(false);
            this.macroTypePanel.ResumeLayout(false);
            this.macroTypePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mouseMoveX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouseMoveY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button aButton;
        private System.Windows.Forms.Button aSharpButton;
        private System.Windows.Forms.Button bButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button cButton;
        private System.Windows.Forms.Button cSharpButton;
        private System.Windows.Forms.Button dButton;
        private System.Windows.Forms.Button dSharpButton;
        private System.Windows.Forms.Button eButton;
        private System.Windows.Forms.Button fButton;
        private System.Windows.Forms.Button fSharpButton;
        private System.Windows.Forms.Button gButton;
        private System.Windows.Forms.Button gSharpButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Panel panel1;

        #endregion

        private System.Windows.Forms.TextBox macroNameTextBox;
        private System.Windows.Forms.Label macroNameLabel;
        private System.Windows.Forms.Label noteNameLabel;
        private System.Windows.Forms.Label octaveLabel;
        private System.Windows.Forms.ComboBox noteNameListBox;
        private System.Windows.Forms.Label pitchLabel;
        private System.Windows.Forms.ComboBox octaveListBox;
        private System.Windows.Forms.Button deleteMacroButton;
        private System.Windows.Forms.ComboBox keyboardKeysListBox;
        private System.Windows.Forms.RadioButton keyboardPressRadioButton;
        private System.Windows.Forms.FlowLayoutPanel macroTypePanel;
        private System.Windows.Forms.RadioButton mousePressRadioButton;
        private System.Windows.Forms.RadioButton mouseMoveRadioButton;
        private System.Windows.Forms.NumericUpDown mouseMoveX;
        private System.Windows.Forms.NumericUpDown mouseMoveY;
    }
}