namespace MidiMapper.Source.Forms
{
    partial class PianoForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.octaveListBox = new System.Windows.Forms.ComboBox();
            this.pitchLabel = new System.Windows.Forms.Label();
            this.noteNameListBox = new System.Windows.Forms.ComboBox();
            this.octaveLabel = new System.Windows.Forms.Label();
            this.noteNameLabel = new System.Windows.Forms.Label();
            this.pianoKeyboardPanel = new System.Windows.Forms.Panel();
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
            this.pianoKeyboardPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.octaveListBox.Location = new System.Drawing.Point(181, 5);
            this.octaveListBox.MaxLength = 2;
            this.octaveListBox.Name = "octaveListBox";
            this.octaveListBox.Size = new System.Drawing.Size(56, 26);
            this.octaveListBox.TabIndex = 30;
            this.octaveListBox.SelectedIndexChanged += new System.EventHandler(this.OctaveListBox_SelectedIndexChanged);
            // 
            // pitchLabel
            // 
            this.pitchLabel.AutoSize = true;
            this.pitchLabel.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pitchLabel.Location = new System.Drawing.Point(9, 9);
            this.pitchLabel.Name = "pitchLabel";
            this.pitchLabel.Size = new System.Drawing.Size(44, 21);
            this.pitchLabel.TabIndex = 29;
            this.pitchLabel.Text = "Note";
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
            this.noteNameListBox.Location = new System.Drawing.Point(56, 6);
            this.noteNameListBox.MaxLength = 2;
            this.noteNameListBox.Name = "noteNameListBox";
            this.noteNameListBox.Size = new System.Drawing.Size(56, 26);
            this.noteNameListBox.TabIndex = 28;
            this.noteNameListBox.SelectedIndexChanged += new System.EventHandler(this.NoteNameListBox_SelectedIndexChanged);
            // 
            // octaveLabel
            // 
            this.octaveLabel.AutoSize = true;
            this.octaveLabel.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.octaveLabel.Location = new System.Drawing.Point(121, 8);
            this.octaveLabel.Name = "octaveLabel";
            this.octaveLabel.Size = new System.Drawing.Size(58, 21);
            this.octaveLabel.TabIndex = 27;
            this.octaveLabel.Text = "Octave";
            // 
            // noteNameLabel
            // 
            this.noteNameLabel.AutoSize = true;
            this.noteNameLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteNameLabel.Location = new System.Drawing.Point(400, 6);
            this.noteNameLabel.Name = "noteNameLabel";
            this.noteNameLabel.Size = new System.Drawing.Size(34, 26);
            this.noteNameLabel.TabIndex = 26;
            this.noteNameLabel.Text = "C4";
            // 
            // pianoKeyboardPanel
            // 
            this.pianoKeyboardPanel.Controls.Add(this.aSharpButton);
            this.pianoKeyboardPanel.Controls.Add(this.gSharpButton);
            this.pianoKeyboardPanel.Controls.Add(this.fSharpButton);
            this.pianoKeyboardPanel.Controls.Add(this.dSharpButton);
            this.pianoKeyboardPanel.Controls.Add(this.cSharpButton);
            this.pianoKeyboardPanel.Controls.Add(this.bButton);
            this.pianoKeyboardPanel.Controls.Add(this.aButton);
            this.pianoKeyboardPanel.Controls.Add(this.gButton);
            this.pianoKeyboardPanel.Controls.Add(this.fButton);
            this.pianoKeyboardPanel.Controls.Add(this.eButton);
            this.pianoKeyboardPanel.Controls.Add(this.dButton);
            this.pianoKeyboardPanel.Controls.Add(this.cButton);
            this.pianoKeyboardPanel.Location = new System.Drawing.Point(4, 37);
            this.pianoKeyboardPanel.Name = "pianoKeyboardPanel";
            this.pianoKeyboardPanel.Size = new System.Drawing.Size(441, 200);
            this.pianoKeyboardPanel.TabIndex = 25;
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
            // PianoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.octaveListBox);
            this.Controls.Add(this.pitchLabel);
            this.Controls.Add(this.noteNameListBox);
            this.Controls.Add(this.octaveLabel);
            this.Controls.Add(this.noteNameLabel);
            this.Controls.Add(this.pianoKeyboardPanel);
            this.Name = "PianoForm";
            this.Size = new System.Drawing.Size(450, 245);
            this.pianoKeyboardPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox octaveListBox;
        private System.Windows.Forms.Label pitchLabel;
        private System.Windows.Forms.ComboBox noteNameListBox;
        private System.Windows.Forms.Label octaveLabel;
        private System.Windows.Forms.Label noteNameLabel;
        private System.Windows.Forms.Panel pianoKeyboardPanel;
        private System.Windows.Forms.Button aSharpButton;
        private System.Windows.Forms.Button gSharpButton;
        private System.Windows.Forms.Button fSharpButton;
        private System.Windows.Forms.Button dSharpButton;
        private System.Windows.Forms.Button cSharpButton;
        private System.Windows.Forms.Button bButton;
        private System.Windows.Forms.Button aButton;
        private System.Windows.Forms.Button gButton;
        private System.Windows.Forms.Button fButton;
        private System.Windows.Forms.Button eButton;
        private System.Windows.Forms.Button dButton;
        private System.Windows.Forms.Button cButton;
    }
}
