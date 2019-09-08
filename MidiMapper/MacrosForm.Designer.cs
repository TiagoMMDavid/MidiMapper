namespace MidiMapper
{
    partial class MacrosForm
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
            this.components = new System.ComponentModel.Container();
            this.macrosList = new System.Windows.Forms.ListBox();
            this.newMacroButton = new System.Windows.Forms.Button();
            this.delMacroButton = new System.Windows.Forms.Button();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.keybindTxtBox = new System.Windows.Forms.TextBox();
            this.pitchTxtBox = new System.Windows.Forms.TextBox();
            this.createMacroButton = new System.Windows.Forms.Button();
            this.refreshButtonTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // macrosList
            // 
            this.macrosList.FormattingEnabled = true;
            this.macrosList.Items.AddRange(new object[] {
            "No macros"});
            this.macrosList.Location = new System.Drawing.Point(12, 173);
            this.macrosList.Name = "macrosList";
            this.macrosList.ScrollAlwaysVisible = true;
            this.macrosList.Size = new System.Drawing.Size(432, 225);
            this.macrosList.TabIndex = 0;
            this.macrosList.SelectedIndexChanged += new System.EventHandler(this.MacrosList_SelectedIndexChanged);
            // 
            // newMacroButton
            // 
            this.newMacroButton.Location = new System.Drawing.Point(12, 12);
            this.newMacroButton.Name = "newMacroButton";
            this.newMacroButton.Size = new System.Drawing.Size(75, 23);
            this.newMacroButton.TabIndex = 1;
            this.newMacroButton.Text = "New";
            this.newMacroButton.UseVisualStyleBackColor = true;
            this.newMacroButton.Click += new System.EventHandler(this.NewMacroButton_Click);
            // 
            // delMacroButton
            // 
            this.delMacroButton.Enabled = false;
            this.delMacroButton.Location = new System.Drawing.Point(460, 182);
            this.delMacroButton.Name = "delMacroButton";
            this.delMacroButton.Size = new System.Drawing.Size(105, 23);
            this.delMacroButton.TabIndex = 2;
            this.delMacroButton.Text = "Delete Macro";
            this.delMacroButton.UseVisualStyleBackColor = true;
            this.delMacroButton.Click += new System.EventHandler(this.DelMacroButton_Click);
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(12, 53);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(231, 20);
            this.nameTxtBox.TabIndex = 3;
            this.nameTxtBox.Visible = false;
            // 
            // keybindTxtBox
            // 
            this.keybindTxtBox.Location = new System.Drawing.Point(12, 88);
            this.keybindTxtBox.Name = "keybindTxtBox";
            this.keybindTxtBox.Size = new System.Drawing.Size(231, 20);
            this.keybindTxtBox.TabIndex = 4;
            this.keybindTxtBox.Visible = false;
            // 
            // pitchTxtBox
            // 
            this.pitchTxtBox.Location = new System.Drawing.Point(12, 124);
            this.pitchTxtBox.Name = "pitchTxtBox";
            this.pitchTxtBox.Size = new System.Drawing.Size(231, 20);
            this.pitchTxtBox.TabIndex = 5;
            this.pitchTxtBox.Visible = false;
            // 
            // createMacroButton
            // 
            this.createMacroButton.Location = new System.Drawing.Point(273, 88);
            this.createMacroButton.Name = "createMacroButton";
            this.createMacroButton.Size = new System.Drawing.Size(75, 23);
            this.createMacroButton.TabIndex = 6;
            this.createMacroButton.Text = "Create";
            this.createMacroButton.UseVisualStyleBackColor = true;
            this.createMacroButton.Visible = false;
            this.createMacroButton.Click += new System.EventHandler(this.CreateMacroButton_Click);
            // 
            // refreshButtonTimer
            // 
            this.refreshButtonTimer.Enabled = true;
            this.refreshButtonTimer.Interval = 10;
            this.refreshButtonTimer.Tick += new System.EventHandler(this.RefreshButtonTimer_Tick);
            // 
            // MacrosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 410);
            this.Controls.Add(this.createMacroButton);
            this.Controls.Add(this.pitchTxtBox);
            this.Controls.Add(this.keybindTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.delMacroButton);
            this.Controls.Add(this.newMacroButton);
            this.Controls.Add(this.macrosList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MacrosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Macros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox macrosList;
        private System.Windows.Forms.Button newMacroButton;
        private System.Windows.Forms.Button delMacroButton;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.TextBox keybindTxtBox;
        private System.Windows.Forms.TextBox pitchTxtBox;
        private System.Windows.Forms.Button createMacroButton;
        private System.Windows.Forms.Timer refreshButtonTimer;
    }
}