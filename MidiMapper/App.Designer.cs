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
            this.clearEventLogButton = new System.Windows.Forms.Button();
            this.profileNameTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
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
            this.eventLog.Location = new System.Drawing.Point(93, 241);
            this.eventLog.Multiline = true;
            this.eventLog.Name = "eventLog";
            this.eventLog.ReadOnly = true;
            this.eventLog.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.eventLog.Size = new System.Drawing.Size(604, 256);
            this.eventLog.TabIndex = 6;
            // 
            // clearEventLogButton
            // 
            this.clearEventLogButton.Location = new System.Drawing.Point(93, 195);
            this.clearEventLogButton.Name = "clearEventLogButton";
            this.clearEventLogButton.Size = new System.Drawing.Size(70, 40);
            this.clearEventLogButton.TabIndex = 7;
            this.clearEventLogButton.Text = "Clear Text";
            this.clearEventLogButton.UseVisualStyleBackColor = true;
            this.clearEventLogButton.Click += new System.EventHandler(this.ClearEventLogButton_Click);
            // 
            // profileNameTextBox
            // 
            this.profileNameTextBox.Location = new System.Drawing.Point(73, 65);
            this.profileNameTextBox.Name = "profileNameTextBox";
            this.profileNameTextBox.ReadOnly = true;
            this.profileNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.profileNameTextBox.TabIndex = 8;
            this.profileNameTextBox.Text = "None";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(179, 54);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(50, 40);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(235, 54);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(50, 40);
            this.loadButton.TabIndex = 10;
            this.loadButton.Text = "LOAD";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 578);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.profileNameTextBox);
            this.Controls.Add(this.clearEventLogButton);
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
        private System.Windows.Forms.Button clearEventLogButton;
        private System.Windows.Forms.TextBox profileNameTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
    }
}

