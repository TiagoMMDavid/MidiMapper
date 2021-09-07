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
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.macroNameTextBox = new System.Windows.Forms.TextBox();
            this.macroNameLabel = new System.Windows.Forms.Label();
            this.deleteMacroButton = new System.Windows.Forms.Button();
            this.keyboardPressRadioButton = new System.Windows.Forms.RadioButton();
            this.mousePressRadioButton = new System.Windows.Forms.RadioButton();
            this.mouseMoveRadioButton = new System.Windows.Forms.RadioButton();
            this.mouseMoveX = new System.Windows.Forms.NumericUpDown();
            this.mouseMoveY = new System.Windows.Forms.NumericUpDown();
            this.mouseXLabel = new System.Windows.Forms.Label();
            this.mouseYLabel = new System.Windows.Forms.Label();
            this.macroTypePanel = new System.Windows.Forms.Panel();
            this.midiTipLabel = new System.Windows.Forms.Label();
            this.pianoForm = new MidiMapper.Source.Forms.PianoForm();
            this.keyboardForm = new MidiMapper.Source.Forms.KeyboardForm();
            ((System.ComponentModel.ISupportInitialize)(this.mouseMoveX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouseMoveY)).BeginInit();
            this.macroTypePanel.SuspendLayout();
            this.SuspendLayout();
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
            this.macroNameTextBox.Location = new System.Drawing.Point(181, 27);
            this.macroNameTextBox.Name = "macroNameTextBox";
            this.macroNameTextBox.Size = new System.Drawing.Size(221, 26);
            this.macroNameTextBox.TabIndex = 17;
            this.macroNameTextBox.Text = "New Macro";
            // 
            // macroNameLabel
            // 
            this.macroNameLabel.AutoSize = true;
            this.macroNameLabel.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macroNameLabel.Location = new System.Drawing.Point(79, 29);
            this.macroNameLabel.Name = "macroNameLabel";
            this.macroNameLabel.Size = new System.Drawing.Size(100, 21);
            this.macroNameLabel.TabIndex = 18;
            this.macroNameLabel.Text = "Macro Name";
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
            // keyboardPressRadioButton
            // 
            this.keyboardPressRadioButton.AutoSize = true;
            this.keyboardPressRadioButton.Checked = true;
            this.keyboardPressRadioButton.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyboardPressRadioButton.Location = new System.Drawing.Point(15, 25);
            this.keyboardPressRadioButton.Name = "keyboardPressRadioButton";
            this.keyboardPressRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.keyboardPressRadioButton.Size = new System.Drawing.Size(135, 25);
            this.keyboardPressRadioButton.TabIndex = 27;
            this.keyboardPressRadioButton.TabStop = true;
            this.keyboardPressRadioButton.Text = "Keyboard Press";
            this.keyboardPressRadioButton.UseVisualStyleBackColor = true;
            this.keyboardPressRadioButton.CheckedChanged += new System.EventHandler(this.KeyboardPressRadioButton_CheckedChanged);
            // 
            // mousePressRadioButton
            // 
            this.mousePressRadioButton.AutoSize = true;
            this.mousePressRadioButton.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mousePressRadioButton.Location = new System.Drawing.Point(202, 25);
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
            this.mouseMoveRadioButton.Location = new System.Drawing.Point(365, 25);
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
            this.mouseMoveX.Location = new System.Drawing.Point(751, 33);
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
            this.mouseMoveY.Location = new System.Drawing.Point(751, 65);
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
            // mouseXLabel
            // 
            this.mouseXLabel.AutoSize = true;
            this.mouseXLabel.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mouseXLabel.Location = new System.Drawing.Point(698, 35);
            this.mouseXLabel.Name = "mouseXLabel";
            this.mouseXLabel.Size = new System.Drawing.Size(51, 21);
            this.mouseXLabel.TabIndex = 33;
            this.mouseXLabel.Text = "X Axis";
            this.mouseXLabel.Visible = false;
            // 
            // mouseYLabel
            // 
            this.mouseYLabel.AutoSize = true;
            this.mouseYLabel.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mouseYLabel.Location = new System.Drawing.Point(699, 67);
            this.mouseYLabel.Name = "mouseYLabel";
            this.mouseYLabel.Size = new System.Drawing.Size(50, 21);
            this.mouseYLabel.TabIndex = 34;
            this.mouseYLabel.Text = "Y Axis";
            this.mouseYLabel.Visible = false;
            // 
            // macroTypePanel
            // 
            this.macroTypePanel.Controls.Add(this.mousePressRadioButton);
            this.macroTypePanel.Controls.Add(this.keyboardPressRadioButton);
            this.macroTypePanel.Controls.Add(this.mouseMoveRadioButton);
            this.macroTypePanel.Location = new System.Drawing.Point(141, 35);
            this.macroTypePanel.Name = "macroTypePanel";
            this.macroTypePanel.Size = new System.Drawing.Size(551, 59);
            this.macroTypePanel.TabIndex = 35;
            // 
            // midiTipLabel
            // 
            this.midiTipLabel.AutoSize = true;
            this.midiTipLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midiTipLabel.Location = new System.Drawing.Point(442, 671);
            this.midiTipLabel.Name = "midiTipLabel";
            this.midiTipLabel.Size = new System.Drawing.Size(222, 14);
            this.midiTipLabel.TabIndex = 32;
            this.midiTipLabel.Text = "Tip: Press your MIDI device to pick a key";
            // 
            // pianoForm
            // 
            this.pianoForm.Location = new System.Drawing.Point(224, 433);
            this.pianoForm.Name = "pianoForm";
            this.pianoForm.Size = new System.Drawing.Size(450, 245);
            this.pianoForm.TabIndex = 36;
            // 
            // keyboardForm
            // 
            this.keyboardForm.Location = new System.Drawing.Point(12, 102);
            this.keyboardForm.Name = "keyboardForm";
            this.keyboardForm.Size = new System.Drawing.Size(853, 325);
            this.keyboardForm.TabIndex = 37;
            // 
            // ManageMacroForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(919, 806);
            this.Controls.Add(this.midiTipLabel);
            this.Controls.Add(this.pianoForm);
            this.Controls.Add(this.keyboardForm);
            this.Controls.Add(this.mouseYLabel);
            this.Controls.Add(this.mouseXLabel);
            this.Controls.Add(this.mouseMoveY);
            this.Controls.Add(this.mouseMoveX);
            this.Controls.Add(this.deleteMacroButton);
            this.Controls.Add(this.macroNameLabel);
            this.Controls.Add(this.macroNameTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.macroTypePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ManageMacroForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MidiMapper - Customize Macro";
            ((System.ComponentModel.ISupportInitialize)(this.mouseMoveX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouseMoveY)).EndInit();
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
        private System.Windows.Forms.NumericUpDown mouseMoveX;
        private System.Windows.Forms.NumericUpDown mouseMoveY;
        private System.Windows.Forms.Label mouseXLabel;
        private System.Windows.Forms.Label mouseYLabel;
        private System.Windows.Forms.Panel macroTypePanel;
        private Source.Forms.PianoForm pianoForm;
        private System.Windows.Forms.Label midiTipLabel;
        private Source.Forms.KeyboardForm keyboardForm;
    }
}