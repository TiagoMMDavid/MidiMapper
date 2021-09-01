namespace MidiMapper.Forms
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
            this.macrosList = new System.Windows.Forms.ListBox();
            this.newMacroButton = new System.Windows.Forms.Button();
            this.delMacroButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // macrosList
            // 
            this.macrosList.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.newMacroButton.Location = new System.Drawing.Point(40, 52);
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
            // MacrosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 410);
            this.Controls.Add(this.delMacroButton);
            this.Controls.Add(this.newMacroButton);
            this.Controls.Add(this.macrosList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MacrosForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Macros";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button delMacroButton;
        private System.Windows.Forms.ListBox macrosList;
        private System.Windows.Forms.Button newMacroButton;

        #endregion
    }
}