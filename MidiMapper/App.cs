using System;
using System.IO;
using System.Windows.Forms;
using NAudio.Midi;
using MidiMapper.Controller;
using MidiMapper.Macros;
using MidiMapper.Forms;
using MidiMapper.Exceptions;

namespace MidiMapper
{
    public partial class App : Form
    {
        #region Main()
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new App());
        }
        #endregion

        private const string GitHubProjectUrl= "https://github.com/TiagoMMDavid/MidiMapper";
        private const int EventLogMaxLinesLength = 50;

        private readonly MidiMapperController _controller;

        private string _previousName; // Used to cancel profile name edit

        private bool _isMinimized;
        private bool _isCloseApp;

        private int _eventLogLinesCount;

        private App()
        {
            InitializeComponent();
            profileNameTextBox.MaxLength = Profile.MaxProfileNameSize;
            profileNameTextBox.KeyDown += ProfileNameTextBox_KeyDown;
            // TODO: Figure out way to lose focus when pressing anywhere on form
            profileNameTextBox.LostFocus += ProfileNameTextBox_FocusLost;

            this.FormClosing += App_FormClosing;

            LoadMidiDevices();
            _controller = new MidiMapperController();
        }

        private void LogMessage(string msg)
        {
            // Remove last lines if max number of lines has exceeded
            if (_eventLogLinesCount >= EventLogMaxLinesLength - 1)
                eventLog.Text = eventLog.Text.Substring(0, eventLog.Text.LastIndexOf('\n'));
            else
                _eventLogLinesCount++;

            string message = $"[{DateTime.Now:HH:mm:ss}]    {msg}\r\n";
            eventLog.Text = eventLog.Text.Insert(0, message);
        }

        private void ClearEventLogButton_Click(object sender, EventArgs e)
        {
            _eventLogLinesCount = 0;
            eventLog.Clear();
        }

        #region MIDI Devices controls
        private void LoadMidiDevices()
        {
            startMidiButton.Enabled = false;
            selectMidiDevice.Items.Clear();

            int devicesCount = MidiIn.NumberOfDevices;
            if (devicesCount == 0)
            {
                selectMidiDevice.Items.Add("No devices detected");
                selectMidiDevice.Enabled = false; // Disable list box if there are no devices connected
                return;
            }

            // Fill midi devices list
            selectMidiDevice.Enabled = true;
            for (int deviceIdx = 0; deviceIdx < devicesCount; deviceIdx++)
                selectMidiDevice.Items.Add(MidiIn.DeviceInfo(deviceIdx).ProductName);
        }

        // Callback for when a midi key is pressed
        private void OnKeyPressed(string note, int velocity, Macro macro)
        {
            string prefix = "MIDI Key Press";
            string macroName = macro != null ? macro.MacroName : "No macro";
            string message = $"{prefix,-19}[{note,-3} Velocity: {velocity + "]",-4}    Macro: {macroName}";

            // By using Invoke, the LogMessage method will only be called on the UI thread
            Action logMessage = delegate { LogMessage(message); };
            eventLog.Invoke(logMessage);
        }

        private void RefreshMidiDeviceButton_Click(object sender, EventArgs e) => LoadMidiDevices();

        private void SelectMidiDevice_SelectedIndexChanged(object sender, EventArgs e) => 
            startMidiButton.Enabled = selectMidiDevice.SelectedIndex != -1;

        private void StartMidiButton_Click(object sender, EventArgs e)
        {
            // Update layout
            startMidiButton.Enabled = false;
            refreshMidiDevicesButton.Enabled = false;
            selectMidiDevice.Enabled = false;
            stopMidiButton.Enabled = true;

            _controller.CloseMidiDevice(); // Close previous device if necessary
            MidiIn midiInput = new MidiIn(selectMidiDevice.SelectedIndex);
            _controller.AddMidiDevice(midiInput, OnKeyPressed);

            LogMessage("Device successfully connected");
        }

        private void StopMidiButton_Click(object sender, EventArgs e)
        {
            // Update Layout
            stopMidiButton.Enabled = false;
            refreshMidiDevicesButton.Enabled = true;
            LoadMidiDevices();

            _controller.CloseMidiDevice();
            LogMessage("Device successfully disconnected");
        }
        #endregion

        #region Profile controls
        private void CreateProfileButton_Click(object sender, EventArgs e)
        {
            // Confirm new profile creation
            if (_controller.Profile?.MacrosCount > 0)
            {
                // TODO: Improve Message box
                string message = "Are you sure you want to create a new profile?\r\n\r\nUnsaved changes may be lost!";
                DialogResult result = MessageBox.Show(message, "Create New Profile", MessageBoxButtons.YesNo);

                if (result != DialogResult.Yes)
                {
                    LogMessage("Profile creation was cancelled");
                    return;
                }
            }

            _controller.Profile = new Profile("New Profile");
            _previousName = "New Profile";
            
            profileNameTextBox.Text = "New Profile";
            profileNameTextBox.Enabled = true;
            profileNameTextBox.ReadOnly = false;
            profileNameTextBox.Focus();
            profileNameTextBox.SelectAll();
            
            macrosButton.Enabled = true;
            saveProfileButton.Enabled = true;

            editProfileNameButton.Enabled = false;
            LogMessage("Profile successfully created");
        }

        private void EditProfileNameButton_Click(object sender, EventArgs e)
        {
            _previousName = profileNameTextBox.Text;

            profileNameTextBox.Enabled = true;
            profileNameTextBox.ReadOnly = false;
            profileNameTextBox.Focus();
            profileNameTextBox.SelectAll();

            editProfileNameButton.Enabled = false;
        }

        private void ProfileNameTextBox_FocusLost(object sender, EventArgs e) => UpdateProfileName();

        private void ProfileNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // Update profile name when 'enter' is pressed or cancel name change when 'escape' is pressed
            if (e.KeyCode != Keys.Enter && e.KeyCode != Keys.Escape) return;

            if (e.KeyCode == Keys.Escape)
                profileNameTextBox.Text = _previousName; // Cancel new name

            UpdateProfileName();
        }

        private void UpdateProfileName()
        {
            _controller.Profile.ProfileName = profileNameTextBox.Text;
            profileNameTextBox.Enabled = false;
            profileNameTextBox.ReadOnly = true;
            profileNameTextBox.Select(0, 0); // Move text to left side of box
            // TODO: Text wrap name if its too long

            editProfileNameButton.Visible = true;
            editProfileNameButton.Enabled = true;
        }

        private void MacrosButton_Click(object sender, EventArgs e)
        {
            MacrosForm macrosForm = new MacrosForm(_controller);
            macrosForm.ShowDialog();
        }
        
        private void SaveProfileButton_Click(object sender, EventArgs e)
        {
            if (_controller.Profile == null) return;

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "MidiMapper - Save Profile",
                Filter = "Txt files (*.txt)|*.txt",
                //RestoreDirectory = true
            };

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                LogMessage("Save profile was cancelled");
                return;
            }
            
            // Save file
            File.WriteAllText(saveFileDialog.FileName, _controller.Profile.SerializeProfile());
            LogMessage($"Profile successfully saved to {saveFileDialog.FileName}");
        }

        private void LoadProfileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Title = "MidiMapper - Load Profile"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                LogMessage("Load profile was cancelled");
                return;
            }
            
            if (!openFileDialog.FileName.EndsWith(".txt"))
            {
                MessageBox.Show("Invalid format file (Needs to be .txt)", "File Error");
                LogMessage("Error loading profile");
                return;
            }

            try
            {
                _controller.Profile = Profile.ParseProfileFromFile(openFileDialog.FileName);
            } catch(ParseProfileFileException ex)
            {
                MessageBox.Show(ex.Message, "Load Profile Error");
                LogMessage("Error loading profile");
                return;
            }

            profileNameTextBox.Text = _controller.Profile.ProfileName;
            macrosButton.Enabled = true;
            saveProfileButton.Enabled = true;
            editProfileNameButton.Visible = true;
            editProfileNameButton.Enabled = true;
            LogMessage("Profile successfully loaded");
        }
        #endregion

        #region Notification Area
        private void App_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing || _isCloseApp) return;
            e.Cancel = true;

            MinimizeAppToTray();
        }

        private void AppNotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e) => OpenAppFromTray();

        // TODO: Check if it works in release mode
        private void AboutMidiMapperMenuItem_Click(object sender, EventArgs e) =>
            System.Diagnostics.Process.Start(GitHubProjectUrl);

        private void HideShowAppToolStripItem_Click(object sender, EventArgs e)
        {
            if (_isMinimized) OpenAppFromTray();
            else MinimizeAppToTray();
        }

        private void ExitMidiMapperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _isCloseApp = true;
            this.Close();
        }

        private void MinimizeAppToTray()
        {
            this.ShowIcon = false;
            this.Hide();

            _isMinimized = true;
            hideShowAppToolStripItem.Text = "Show MidiMapper";
        }

        private void OpenAppFromTray()
        {
            this.ShowInTaskbar = true;
            this.Show();
            this.WindowState = FormWindowState.Normal;

            _isMinimized = false;
            hideShowAppToolStripItem.Text = "Minimize to Tray";
        }
        #endregion
    }
}
