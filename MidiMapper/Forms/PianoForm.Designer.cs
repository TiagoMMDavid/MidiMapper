namespace MidiMapper.Forms
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.octaveTrackBar = new System.Windows.Forms.TrackBar();
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
            this.pitchTxtBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.octaveTrackBar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // octaveTrackBar
            // 
            this.octaveTrackBar.LargeChange = 1;
            this.octaveTrackBar.Location = new System.Drawing.Point(104, 72);
            this.octaveTrackBar.Maximum = 8;
            this.octaveTrackBar.Minimum = 1;
            this.octaveTrackBar.Name = "octaveTrackBar";
            this.octaveTrackBar.Size = new System.Drawing.Size(554, 45);
            this.octaveTrackBar.TabIndex = 0;
            this.octaveTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.octaveTrackBar.Value = 1;
            this.octaveTrackBar.Scroll += new System.EventHandler(this.OctaveTrackBar_Scroll);
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
            this.panel1.Location = new System.Drawing.Point(180, 141);
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
            // pitchTxtBox
            // 
            this.pitchTxtBox.Location = new System.Drawing.Point(312, 37);
            this.pitchTxtBox.MaxLength = 7;
            this.pitchTxtBox.Name = "pitchTxtBox";
            this.pitchTxtBox.Size = new System.Drawing.Size(120, 20);
            this.pitchTxtBox.TabIndex = 3;
            this.pitchTxtBox.TextChanged += new System.EventHandler(this.PitchTxtBox_TextChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(372, 380);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(114, 47);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Enabled = false;
            this.okButton.Location = new System.Drawing.Point(252, 380);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(114, 47);
            this.okButton.TabIndex = 15;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // PianoForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.pitchTxtBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.octaveTrackBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PianoForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Pitch";
            ((System.ComponentModel.ISupportInitialize)(this.octaveTrackBar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar octaveTrackBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cButton;
        private System.Windows.Forms.Button bButton;
        private System.Windows.Forms.Button aButton;
        private System.Windows.Forms.Button gButton;
        private System.Windows.Forms.Button fButton;
        private System.Windows.Forms.Button eButton;
        private System.Windows.Forms.Button dButton;
        private System.Windows.Forms.Button aSharpButton;
        private System.Windows.Forms.Button gSharpButton;
        private System.Windows.Forms.Button fSharpButton;
        private System.Windows.Forms.Button dSharpButton;
        private System.Windows.Forms.Button cSharpButton;
        private System.Windows.Forms.TextBox pitchTxtBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
    }
}