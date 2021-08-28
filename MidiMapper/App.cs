using System;
using System.Globalization;
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

        private readonly MidiMapperController _controller;

        private App()
        {
            InitializeComponent();
            LoadMidiDevices();
            _controller = new MidiMapperController();
        }

        private void LogMessage(string msg)
        {
            string time = $"{DateTime.Now:HH:mm:ss}";
            eventLog.Text = eventLog.Text.Insert(0, $"[{time}] {msg}\r\n");
        }
        
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
            string macroName = macro != null ? macro.MacroName : "No macro"; 
            LogMessage($"{$"[{note} Velocity: {velocity}]", -25}Macro: {macroName}");
        }

        private void RefreshMidiDeviceButton_Click(object sender, EventArgs e)
        {
            LoadMidiDevices();
        }

        private void SelectMidiDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            startMidiButton.Enabled = selectMidiDevice.SelectedIndex != -1;
        }

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

        private void CreateProfileButton_Click(object sender, EventArgs e)
        {  
            InsertNameForm createProfileForm = new InsertNameForm("Create Profile", "Insert profile name", "Create", "Cancel");
            createProfileForm.ShowDialog();
            string profileName = createProfileForm.GetName();

            // Return if create profile was cancelled
            if (profileName == null) return;
            _controller.Profile = new Profile(profileName);

            profileNameTextBox.Text = profileName;
            macrosButton.Enabled = true;
            saveProfileButton.Enabled = true;
            LogMessage("Profile successfully created");
        }

        private void MacrosButton_Click(object sender, EventArgs e)
        {
            MacrosForm macrosForm = new MacrosForm(_controller.Profile);
            macrosForm.ShowDialog();
        }
        
        private void SaveProfileButton_Click(object sender, EventArgs e)
        {
            if (_controller.Profile == null) return;

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
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
            OpenFileDialog openFileDialog = new OpenFileDialog();
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
            LogMessage("Profile successfully loaded");
        }
        
        private void ClearEventLogButton_Click(object sender, EventArgs e)
        {
            eventLog.Clear();
        }
    }
}
