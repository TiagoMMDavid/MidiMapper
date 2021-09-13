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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MacrosForm));
            this.macrosList = new System.Windows.Forms.ListBox();
            this.newMacroButton = new System.Windows.Forms.Button();
            this.deleteMacroButton = new System.Windows.Forms.Button();
            this.editMacroButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // macrosList
            // 
            this.macrosList.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macrosList.FormattingEnabled = true;
            this.macrosList.ItemHeight = 15;
            this.macrosList.Items.AddRange(new object[] {
            "No macros"});
            this.macrosList.Location = new System.Drawing.Point(33, 84);
            this.macrosList.Name = "macrosList";
            this.macrosList.ScrollAlwaysVisible = true;
            this.macrosList.Size = new System.Drawing.Size(620, 274);
            this.macrosList.TabIndex = 0;
            this.macrosList.SelectedIndexChanged += new System.EventHandler(this.MacrosList_SelectedIndexChanged);
            // 
            // newMacroButton
            // 
            this.newMacroButton.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newMacroButton.Image = global::MidiMapper.Properties.Resources.plus_icon;
            this.newMacroButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newMacroButton.Location = new System.Drawing.Point(32, 33);
            this.newMacroButton.Name = "newMacroButton";
            this.newMacroButton.Padding = new System.Windows.Forms.Padding(3);
            this.newMacroButton.Size = new System.Drawing.Size(146, 53);
            this.newMacroButton.TabIndex = 1;
            this.newMacroButton.Text = "Create Macro";
            this.newMacroButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newMacroButton.UseVisualStyleBackColor = true;
            this.newMacroButton.Click += new System.EventHandler(this.NewMacroButton_Click);
            // 
            // deleteMacroButton
            // 
            this.deleteMacroButton.Enabled = false;
            this.deleteMacroButton.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteMacroButton.Image = global::MidiMapper.Properties.Resources.trash_icon;
            this.deleteMacroButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteMacroButton.Location = new System.Drawing.Point(509, 33);
            this.deleteMacroButton.Name = "deleteMacroButton";
            this.deleteMacroButton.Padding = new System.Windows.Forms.Padding(1);
            this.deleteMacroButton.Size = new System.Drawing.Size(145, 53);
            this.deleteMacroButton.TabIndex = 2;
            this.deleteMacroButton.Text = "Delete Macro";
            this.deleteMacroButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteMacroButton.UseVisualStyleBackColor = true;
            this.deleteMacroButton.Click += new System.EventHandler(this.DeleteMacroButton_Click);
            // 
            // editMacroButton
            // 
            this.editMacroButton.Enabled = false;
            this.editMacroButton.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editMacroButton.Image = global::MidiMapper.Properties.Resources.edit_icon;
            this.editMacroButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editMacroButton.Location = new System.Drawing.Point(357, 33);
            this.editMacroButton.Name = "editMacroButton";
            this.editMacroButton.Padding = new System.Windows.Forms.Padding(10);
            this.editMacroButton.Size = new System.Drawing.Size(145, 53);
            this.editMacroButton.TabIndex = 3;
            this.editMacroButton.Text = "Edit Macro";
            this.editMacroButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editMacroButton.UseVisualStyleBackColor = true;
            this.editMacroButton.Click += new System.EventHandler(this.EditMacroButton_Click);
            // 
            // MacrosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 390);
            this.Controls.Add(this.macrosList);
            this.Controls.Add(this.deleteMacroButton);
            this.Controls.Add(this.editMacroButton);
            this.Controls.Add(this.newMacroButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MacrosForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " MidiMapper - Macros";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button deleteMacroButton;
        private System.Windows.Forms.ListBox macrosList;
        private System.Windows.Forms.Button newMacroButton;

        #endregion

        private System.Windows.Forms.Button editMacroButton;
    }
}