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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.selectMidiDevice = new System.Windows.Forms.ListBox();
            this.eventLog = new System.Windows.Forms.TextBox();
            this.profileNameTextBox = new System.Windows.Forms.TextBox();
            this.macrosButton = new System.Windows.Forms.Button();
            this.editProfileNameButton = new System.Windows.Forms.Button();
            this.createProfileButton = new System.Windows.Forms.Button();
            this.loadProfileButton = new System.Windows.Forms.Button();
            this.saveProfileButton = new System.Windows.Forms.Button();
            this.clearEventLogButton = new System.Windows.Forms.Button();
            this.stopMidiButton = new System.Windows.Forms.Button();
            this.startMidiButton = new System.Windows.Forms.Button();
            this.refreshMidiDevicesButton = new System.Windows.Forms.Button();
            this.userAvatar = new System.Windows.Forms.PictureBox();
            this.eventLogLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // selectMidiDevice
            // 
            this.selectMidiDevice.FormattingEnabled = true;
            resources.ApplyResources(this.selectMidiDevice, "selectMidiDevice");
            this.selectMidiDevice.Name = "selectMidiDevice";
            this.selectMidiDevice.SelectedIndexChanged += new System.EventHandler(this.SelectMidiDevice_SelectedIndexChanged);
            // 
            // eventLog
            // 
            this.eventLog.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.eventLog, "eventLog");
            this.eventLog.Name = "eventLog";
            this.eventLog.ReadOnly = true;
            // 
            // profileNameTextBox
            // 
            this.profileNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.profileNameTextBox, "profileNameTextBox");
            this.profileNameTextBox.Name = "profileNameTextBox";
            this.profileNameTextBox.ReadOnly = true;
            // 
            // macrosButton
            // 
            resources.ApplyResources(this.macrosButton, "macrosButton");
            this.macrosButton.Name = "macrosButton";
            this.macrosButton.UseVisualStyleBackColor = true;
            this.macrosButton.Click += new System.EventHandler(this.MacrosButton_Click);
            // 
            // editProfileNameButton
            // 
            resources.ApplyResources(this.editProfileNameButton, "editProfileNameButton");
            this.editProfileNameButton.Image = global::MidiMapper.Properties.Resources.edit_icon;
            this.editProfileNameButton.Name = "editProfileNameButton";
            this.editProfileNameButton.UseVisualStyleBackColor = true;
            this.editProfileNameButton.Click += new System.EventHandler(this.EditProfileNameButton_Click);
            // 
            // createProfileButton
            // 
            resources.ApplyResources(this.createProfileButton, "createProfileButton");
            this.createProfileButton.Image = global::MidiMapper.Properties.Resources.plus_icon;
            this.createProfileButton.Name = "createProfileButton";
            this.createProfileButton.UseVisualStyleBackColor = true;
            this.createProfileButton.Click += new System.EventHandler(this.CreateProfileButton_Click);
            // 
            // loadProfileButton
            // 
            this.loadProfileButton.Image = global::MidiMapper.Properties.Resources.load_icon;
            resources.ApplyResources(this.loadProfileButton, "loadProfileButton");
            this.loadProfileButton.Name = "loadProfileButton";
            this.loadProfileButton.UseVisualStyleBackColor = true;
            this.loadProfileButton.Click += new System.EventHandler(this.LoadProfileButton_Click);
            // 
            // saveProfileButton
            // 
            resources.ApplyResources(this.saveProfileButton, "saveProfileButton");
            this.saveProfileButton.Image = global::MidiMapper.Properties.Resources.save_icon;
            this.saveProfileButton.Name = "saveProfileButton";
            this.saveProfileButton.UseVisualStyleBackColor = true;
            this.saveProfileButton.Click += new System.EventHandler(this.SaveProfileButton_Click);
            // 
            // clearEventLogButton
            // 
            this.clearEventLogButton.Image = global::MidiMapper.Properties.Resources.trash_icon;
            resources.ApplyResources(this.clearEventLogButton, "clearEventLogButton");
            this.clearEventLogButton.Name = "clearEventLogButton";
            this.clearEventLogButton.UseVisualStyleBackColor = true;
            this.clearEventLogButton.Click += new System.EventHandler(this.ClearEventLogButton_Click);
            // 
            // stopMidiButton
            // 
            resources.ApplyResources(this.stopMidiButton, "stopMidiButton");
            this.stopMidiButton.Image = global::MidiMapper.Properties.Resources.stop_icon;
            this.stopMidiButton.Name = "stopMidiButton";
            this.stopMidiButton.UseVisualStyleBackColor = true;
            this.stopMidiButton.Click += new System.EventHandler(this.StopMidiButton_Click);
            // 
            // startMidiButton
            // 
            resources.ApplyResources(this.startMidiButton, "startMidiButton");
            this.startMidiButton.Image = global::MidiMapper.Properties.Resources.start_icon;
            this.startMidiButton.Name = "startMidiButton";
            this.startMidiButton.UseVisualStyleBackColor = true;
            this.startMidiButton.Click += new System.EventHandler(this.StartMidiButton_Click);
            // 
            // refreshMidiDevicesButton
            // 
            this.refreshMidiDevicesButton.Image = global::MidiMapper.Properties.Resources.refresh_icon;
            resources.ApplyResources(this.refreshMidiDevicesButton, "refreshMidiDevicesButton");
            this.refreshMidiDevicesButton.Name = "refreshMidiDevicesButton";
            this.refreshMidiDevicesButton.UseVisualStyleBackColor = true;
            this.refreshMidiDevicesButton.Click += new System.EventHandler(this.RefreshMidiDeviceButton_Click);
            // 
            // userAvatar
            // 
            this.userAvatar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.userAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userAvatar.Image = global::MidiMapper.Properties.Resources.user_icon;
            resources.ApplyResources(this.userAvatar, "userAvatar");
            this.userAvatar.Name = "userAvatar";
            this.userAvatar.TabStop = false;
            // 
            // eventLogLabel
            // 
            resources.ApplyResources(this.eventLogLabel, "eventLogLabel");
            this.eventLogLabel.Name = "eventLogLabel";
            // 
            // App
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.eventLogLabel);
            this.Controls.Add(this.editProfileNameButton);
            this.Controls.Add(this.macrosButton);
            this.Controls.Add(this.createProfileButton);
            this.Controls.Add(this.loadProfileButton);
            this.Controls.Add(this.saveProfileButton);
            this.Controls.Add(this.profileNameTextBox);
            this.Controls.Add(this.clearEventLogButton);
            this.Controls.Add(this.eventLog);
            this.Controls.Add(this.stopMidiButton);
            this.Controls.Add(this.startMidiButton);
            this.Controls.Add(this.refreshMidiDevicesButton);
            this.Controls.Add(this.selectMidiDevice);
            this.Controls.Add(this.userAvatar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "App";
            ((System.ComponentModel.ISupportInitialize)(this.userAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button clearEventLogButton;
        private System.Windows.Forms.Button createProfileButton;
        private System.Windows.Forms.TextBox eventLog;
        private System.Windows.Forms.Button loadProfileButton;
        private System.Windows.Forms.Button macrosButton;
        private System.Windows.Forms.TextBox profileNameTextBox;
        private System.Windows.Forms.Button refreshMidiDevicesButton;
        private System.Windows.Forms.Button saveProfileButton;
        private System.Windows.Forms.ListBox selectMidiDevice;
        private System.Windows.Forms.Button startMidiButton;
        private System.Windows.Forms.Button stopMidiButton;

        #endregion

        private System.Windows.Forms.PictureBox userAvatar;
        private System.Windows.Forms.Button editProfileNameButton;
        private System.Windows.Forms.Label eventLogLabel;
    }
}

