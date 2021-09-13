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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageMacroForm));
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.macroNameTextBox = new System.Windows.Forms.TextBox();
            this.macroNameLabel = new System.Windows.Forms.Label();
            this.deleteMacroButton = new System.Windows.Forms.Button();
            this.keyboardPressRadioButton = new System.Windows.Forms.RadioButton();
            this.mousePressRadioButton = new System.Windows.Forms.RadioButton();
            this.mouseMoveRadioButton = new System.Windows.Forms.RadioButton();
            this.macroTypePanel = new System.Windows.Forms.Panel();
            this.midiTipLabel = new System.Windows.Forms.Label();
            this.macroTypeLabel = new System.Windows.Forms.Label();
            this.keyboardForm = new MidiMapper.Source.Forms.KeyboardForm();
            this.pianoForm = new MidiMapper.Source.Forms.PianoForm();
            this.mousePressForm = new MidiMapper.Source.Forms.MousePressForm();
            this.mouseMoveForm = new MidiMapper.Source.Forms.MouseMoveForm();
            this.macroTypePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(142, 723);
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
            this.okButton.Location = new System.Drawing.Point(18, 723);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(114, 47);
            this.okButton.TabIndex = 15;
            this.okButton.Text = "Create Macro";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // macroNameTextBox
            // 
            this.macroNameTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macroNameTextBox.Location = new System.Drawing.Point(48, 62);
            this.macroNameTextBox.Name = "macroNameTextBox";
            this.macroNameTextBox.Size = new System.Drawing.Size(270, 31);
            this.macroNameTextBox.TabIndex = 17;
            this.macroNameTextBox.Text = "New Macro";
            // 
            // macroNameLabel
            // 
            this.macroNameLabel.AutoSize = true;
            this.macroNameLabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macroNameLabel.Location = new System.Drawing.Point(94, 24);
            this.macroNameLabel.Name = "macroNameLabel";
            this.macroNameLabel.Size = new System.Drawing.Size(156, 33);
            this.macroNameLabel.TabIndex = 18;
            this.macroNameLabel.Text = "Macro Name";
            // 
            // deleteMacroButton
            // 
            this.deleteMacroButton.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteMacroButton.Location = new System.Drawing.Point(737, 723);
            this.deleteMacroButton.Name = "deleteMacroButton";
            this.deleteMacroButton.Size = new System.Drawing.Size(114, 47);
            this.deleteMacroButton.TabIndex = 25;
            this.deleteMacroButton.Text = "Delete Macro";
            this.deleteMacroButton.UseVisualStyleBackColor = true;
            this.deleteMacroButton.Visible = false;
            this.deleteMacroButton.Click += new System.EventHandler(this.DeleteMacroButton_Click);
            // 
            // keyboardPressRadioButton
            // 
            this.keyboardPressRadioButton.AutoSize = true;
            this.keyboardPressRadioButton.Checked = true;
            this.keyboardPressRadioButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyboardPressRadioButton.Location = new System.Drawing.Point(40, 3);
            this.keyboardPressRadioButton.Name = "keyboardPressRadioButton";
            this.keyboardPressRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.keyboardPressRadioButton.Size = new System.Drawing.Size(126, 23);
            this.keyboardPressRadioButton.TabIndex = 27;
            this.keyboardPressRadioButton.TabStop = true;
            this.keyboardPressRadioButton.Text = "Keyboard Press";
            this.keyboardPressRadioButton.UseVisualStyleBackColor = true;
            this.keyboardPressRadioButton.CheckedChanged += new System.EventHandler(this.KeyboardPressRadioButton_CheckedChanged);
            // 
            // mousePressRadioButton
            // 
            this.mousePressRadioButton.AutoSize = true;
            this.mousePressRadioButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mousePressRadioButton.Location = new System.Drawing.Point(179, 3);
            this.mousePressRadioButton.Name = "mousePressRadioButton";
            this.mousePressRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mousePressRadioButton.Size = new System.Drawing.Size(110, 23);
            this.mousePressRadioButton.TabIndex = 28;
            this.mousePressRadioButton.Text = "Mouse Press";
            this.mousePressRadioButton.UseVisualStyleBackColor = true;
            this.mousePressRadioButton.CheckedChanged += new System.EventHandler(this.MousePressRadioButton_CheckedChanged);
            // 
            // mouseMoveRadioButton
            // 
            this.mouseMoveRadioButton.AutoSize = true;
            this.mouseMoveRadioButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mouseMoveRadioButton.Location = new System.Drawing.Point(300, 3);
            this.mouseMoveRadioButton.Name = "mouseMoveRadioButton";
            this.mouseMoveRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mouseMoveRadioButton.Size = new System.Drawing.Size(111, 23);
            this.mouseMoveRadioButton.TabIndex = 29;
            this.mouseMoveRadioButton.Text = "Mouse Move";
            this.mouseMoveRadioButton.UseVisualStyleBackColor = true;
            this.mouseMoveRadioButton.CheckedChanged += new System.EventHandler(this.MouseMoveRadioButton_CheckedChanged);
            // 
            // macroTypePanel
            // 
            this.macroTypePanel.Controls.Add(this.mousePressRadioButton);
            this.macroTypePanel.Controls.Add(this.keyboardPressRadioButton);
            this.macroTypePanel.Controls.Add(this.mouseMoveRadioButton);
            this.macroTypePanel.Location = new System.Drawing.Point(393, 60);
            this.macroTypePanel.Name = "macroTypePanel";
            this.macroTypePanel.Size = new System.Drawing.Size(418, 33);
            this.macroTypePanel.TabIndex = 35;
            // 
            // midiTipLabel
            // 
            this.midiTipLabel.AutoSize = true;
            this.midiTipLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midiTipLabel.Location = new System.Drawing.Point(404, 668);
            this.midiTipLabel.Name = "midiTipLabel";
            this.midiTipLabel.Size = new System.Drawing.Size(240, 14);
            this.midiTipLabel.TabIndex = 32;
            this.midiTipLabel.Text = "Tip: Press your MIDI device to select a note";
            // 
            // macroTypeLabel
            // 
            this.macroTypeLabel.AutoSize = true;
            this.macroTypeLabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macroTypeLabel.Location = new System.Drawing.Point(559, 24);
            this.macroTypeLabel.Name = "macroTypeLabel";
            this.macroTypeLabel.Size = new System.Drawing.Size(142, 33);
            this.macroTypeLabel.TabIndex = 38;
            this.macroTypeLabel.Text = "Macro Type";
            // 
            // keyboardForm
            // 
            this.keyboardForm.Location = new System.Drawing.Point(12, 119);
            this.keyboardForm.Name = "keyboardForm";
            this.keyboardForm.Size = new System.Drawing.Size(829, 306);
            this.keyboardForm.TabIndex = 37;
            // 
            // pianoForm
            // 
            this.pianoForm.Location = new System.Drawing.Point(206, 431);
            this.pianoForm.Name = "pianoForm";
            this.pianoForm.Size = new System.Drawing.Size(450, 245);
            this.pianoForm.TabIndex = 36;
            // 
            // mousePressForm
            // 
            this.mousePressForm.Location = new System.Drawing.Point(187, 119);
            this.mousePressForm.Name = "mousePressForm";
            this.mousePressForm.Size = new System.Drawing.Size(519, 352);
            this.mousePressForm.TabIndex = 39;
            this.mousePressForm.Visible = false;
            // 
            // mouseMoveForm
            // 
            this.mouseMoveForm.Location = new System.Drawing.Point(187, 119);
            this.mouseMoveForm.Name = "mouseMoveForm";
            this.mouseMoveForm.Size = new System.Drawing.Size(519, 352);
            this.mouseMoveForm.TabIndex = 40;
            this.mouseMoveForm.Visible = false;
            // 
            // ManageMacroForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(868, 787);
            this.Controls.Add(this.keyboardForm);
            this.Controls.Add(this.macroTypeLabel);
            this.Controls.Add(this.midiTipLabel);
            this.Controls.Add(this.pianoForm);
            this.Controls.Add(this.macroNameTextBox);
            this.Controls.Add(this.deleteMacroButton);
            this.Controls.Add(this.macroNameLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.macroTypePanel);
            this.Controls.Add(this.mousePressForm);
            this.Controls.Add(this.mouseMoveForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ManageMacroForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MidiMapper - Customize Macro";
            this.macroTypePanel.ResumeLayout(false);
            this.macroTypePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;

        #endregion

        private System.Windows.Forms.TextBox macroNameTextBox;
        private System.Windows.Forms.Label macroNameLabel;
        private System.Windows.Forms.Button deleteMacroButton;
        private System.Windows.Forms.RadioButton keyboardPressRadioButton;
        private System.Windows.Forms.RadioButton mousePressRadioButton;
        private System.Windows.Forms.RadioButton mouseMoveRadioButton;
        private System.Windows.Forms.Panel macroTypePanel;
        private Source.Forms.PianoForm pianoForm;
        private System.Windows.Forms.Label midiTipLabel;
        private Source.Forms.KeyboardForm keyboardForm;
        private System.Windows.Forms.Label macroTypeLabel;
        private Source.Forms.MousePressForm mousePressForm;
        private Source.Forms.MouseMoveForm mouseMoveForm;
    }
}