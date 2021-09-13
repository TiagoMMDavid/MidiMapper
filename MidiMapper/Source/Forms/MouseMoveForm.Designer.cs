namespace MidiMapper.Source.Forms
{
    partial class MouseMoveForm
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
            this.mouseMoveLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mousePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mouseYLabel = new System.Windows.Forms.Label();
            this.mouseXLabel = new System.Windows.Forms.Label();
            this.mouseMoveY = new System.Windows.Forms.NumericUpDown();
            this.mouseMoveX = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mouseMoveY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouseMoveX)).BeginInit();
            this.SuspendLayout();
            // 
            // mouseMoveLabel
            // 
            this.mouseMoveLabel.AutoSize = true;
            this.mouseMoveLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mouseMoveLabel.Location = new System.Drawing.Point(29, 72);
            this.mouseMoveLabel.Name = "mouseMoveLabel";
            this.mouseMoveLabel.Size = new System.Drawing.Size(195, 29);
            this.mouseMoveLabel.TabIndex = 28;
            this.mouseMoveLabel.Text = "Mouse Movement";
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
            this.panel1.Controls.Add(this.mouseYLabel);
            this.panel1.Controls.Add(this.mouseXLabel);
            this.panel1.Controls.Add(this.mouseMoveY);
            this.panel1.Controls.Add(this.mouseMoveX);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 277);
            this.panel1.TabIndex = 29;
            // 
            // mouseYLabel
            // 
            this.mouseYLabel.AutoSize = true;
            this.mouseYLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mouseYLabel.Location = new System.Drawing.Point(39, 140);
            this.mouseYLabel.Name = "mouseYLabel";
            this.mouseYLabel.Size = new System.Drawing.Size(54, 23);
            this.mouseYLabel.TabIndex = 38;
            this.mouseYLabel.Text = "Y Axis";
            // 
            // mouseXLabel
            // 
            this.mouseXLabel.AutoSize = true;
            this.mouseXLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mouseXLabel.Location = new System.Drawing.Point(38, 108);
            this.mouseXLabel.Name = "mouseXLabel";
            this.mouseXLabel.Size = new System.Drawing.Size(55, 23);
            this.mouseXLabel.TabIndex = 37;
            this.mouseXLabel.Text = "X Axis";
            // 
            // mouseMoveY
            // 
            this.mouseMoveY.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mouseMoveY.Location = new System.Drawing.Point(99, 139);
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
            this.mouseMoveY.Size = new System.Drawing.Size(65, 27);
            this.mouseMoveY.TabIndex = 36;
            this.mouseMoveY.ValueChanged += new System.EventHandler(this.MouseMoveY_ValueChanged);
            // 
            // mouseMoveX
            // 
            this.mouseMoveX.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mouseMoveX.Location = new System.Drawing.Point(99, 107);
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
            this.mouseMoveX.Size = new System.Drawing.Size(65, 27);
            this.mouseMoveX.TabIndex = 35;
            this.mouseMoveX.ValueChanged += new System.EventHandler(this.MouseMoveX_ValueChanged);
            // 
            // MouseMoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mouseMoveLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mousePanel);
            this.Name = "MouseMoveForm";
            this.Size = new System.Drawing.Size(495, 286);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mouseMoveY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouseMoveX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label mouseMoveLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel mousePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label mouseYLabel;
        private System.Windows.Forms.Label mouseXLabel;
        private System.Windows.Forms.NumericUpDown mouseMoveY;
        private System.Windows.Forms.NumericUpDown mouseMoveX;
    }
}
