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
            this.pressKeyTimer = new System.Windows.Forms.Timer(this.components);
            this.selectInputBox = new System.Windows.Forms.ListBox();
            this.refreshInputButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.eventLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pressKeyTimer
            // 
            this.pressKeyTimer.Enabled = true;
            this.pressKeyTimer.Tick += new System.EventHandler(this.PressKeyTimer_Tick);
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
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(519, 114);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(178, 34);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(703, 114);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(38, 34);
            this.stopButton.TabIndex = 5;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // eventLog
            // 
            this.eventLog.Location = new System.Drawing.Point(93, 225);
            this.eventLog.Multiline = true;
            this.eventLog.Name = "eventLog";
            this.eventLog.ReadOnly = true;
            this.eventLog.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.eventLog.Size = new System.Drawing.Size(604, 256);
            this.eventLog.TabIndex = 6;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 578);
            this.Controls.Add(this.eventLog);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.refreshInputButton);
            this.Controls.Add(this.selectInputBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "App";
            this.Text = "MidiMapper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer pressKeyTimer;
        private System.Windows.Forms.ListBox selectInputBox;
        private System.Windows.Forms.Button refreshInputButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.TextBox eventLog;
    }
}

