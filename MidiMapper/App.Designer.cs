namespace MidiMapper
{
    partial class App
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.selectInputBox = new System.Windows.Forms.ListBox();
            this.refreshInputButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // selectInputBox
            // 
            this.selectInputBox.FormattingEnabled = true;
            this.selectInputBox.Location = new System.Drawing.Point(519, 65);
            this.selectInputBox.Name = "selectInputBox";
            this.selectInputBox.ScrollAlwaysVisible = true;
            this.selectInputBox.Size = new System.Drawing.Size(178, 43);
            this.selectInputBox.TabIndex = 2;
            this.selectInputBox.SelectedIndexChanged += new System.EventHandler(this.SelectInput_SelectedIndexChanged);
            // 
            // refreshInputButton
            // 
            this.refreshInputButton.Location = new System.Drawing.Point(703, 68);
            this.refreshInputButton.Name = "refreshInputButton";
            this.refreshInputButton.Size = new System.Drawing.Size(38, 40);
            this.refreshInputButton.TabIndex = 3;
            this.refreshInputButton.Text = "REFRESH";
            this.refreshInputButton.UseVisualStyleBackColor = true;
            this.refreshInputButton.Click += new System.EventHandler(this.RefreshInputButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Enabled = false;
            this.connectButton.Location = new System.Drawing.Point(519, 114);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(178, 34);
            this.connectButton.TabIndex = 4;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 578);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.refreshInputButton);
            this.Controls.Add(this.selectInputBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "App";
            this.Text = "MidiMapper";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ListBox selectInputBox;
        private System.Windows.Forms.Button refreshInputButton;
        private System.Windows.Forms.Button connectButton;
    }
}

