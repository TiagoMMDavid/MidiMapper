namespace MidiMapper.Source.Forms
{
    partial class MousePressForm
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
            this.middleButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.buttonsListBox = new System.Windows.Forms.ComboBox();
            this.mouseButtonLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mousePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // middleButton
            // 
            this.middleButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleButton.Location = new System.Drawing.Point(358, 21);
            this.middleButton.Name = "middleButton";
            this.middleButton.Size = new System.Drawing.Size(28, 35);
            this.middleButton.TabIndex = 2;
            this.middleButton.Text = "M";
            this.middleButton.UseVisualStyleBackColor = true;
            this.middleButton.Click += new System.EventHandler(this.MiddleButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightButton.Location = new System.Drawing.Point(395, 45);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(46, 46);
            this.rightButton.TabIndex = 1;
            this.rightButton.Text = "R";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // leftButton
            // 
            this.leftButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftButton.Location = new System.Drawing.Point(304, 46);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(46, 46);
            this.leftButton.TabIndex = 0;
            this.leftButton.Text = "L";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // buttonsListBox
            // 
            this.buttonsListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.buttonsListBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsListBox.FormattingEnabled = true;
            this.buttonsListBox.IntegralHeight = false;
            this.buttonsListBox.Location = new System.Drawing.Point(30, 107);
            this.buttonsListBox.MaxDropDownItems = 15;
            this.buttonsListBox.MaxLength = 2;
            this.buttonsListBox.Name = "buttonsListBox";
            this.buttonsListBox.Size = new System.Drawing.Size(188, 31);
            this.buttonsListBox.TabIndex = 27;
            // 
            // mouseButtonLabel
            // 
            this.mouseButtonLabel.AutoSize = true;
            this.mouseButtonLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mouseButtonLabel.Location = new System.Drawing.Point(21, 62);
            this.mouseButtonLabel.Name = "mouseButtonLabel";
            this.mouseButtonLabel.Size = new System.Drawing.Size(153, 29);
            this.mouseButtonLabel.TabIndex = 28;
            this.mouseButtonLabel.Text = "Mouse Button";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MidiMapper.Properties.Resources.mouse_image;
            this.pictureBox1.Location = new System.Drawing.Point(274, -15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 291);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mousePanel
            // 
            this.mousePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mousePanel.Location = new System.Drawing.Point(3, 5);
            this.mousePanel.Name = "mousePanel";
            this.mousePanel.Size = new System.Drawing.Size(489, 277);
            this.mousePanel.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.mouseButtonLabel);
            this.panel1.Controls.Add(this.rightButton);
            this.panel1.Controls.Add(this.middleButton);
            this.panel1.Controls.Add(this.leftButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 277);
            this.panel1.TabIndex = 29;
            // 
            // MousePressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonsListBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mousePanel);
            this.Name = "MousePressForm";
            this.Size = new System.Drawing.Size(495, 286);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox buttonsListBox;
        private System.Windows.Forms.Label mouseButtonLabel;
        private System.Windows.Forms.Button middleButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel mousePanel;
        private System.Windows.Forms.Panel panel1;
    }
}
