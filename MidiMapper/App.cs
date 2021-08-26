using System;
using System.IO;
using System.Windows.Forms;
using MidiMapper.Controller;
using MidiMapper.Macros;
using MidiMapper.Forms;
using NAudio.Midi;

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

        private MidiMapperController _controller;

        public App()
        {
            InitializeComponent();
            refreshInputs();
            _controller = new MidiMapperController();
        }

        // TODO: Is it possible to delete this method?
        private void App_Load(object sender, EventArgs e) { }


        private void refreshInputs()
        {
            selectMidiDevice.Enabled = true;
            selectMidiDevice.Items.Clear();

            int installedDevices = MidiIn.NumberOfDevices;
            if (installedDevices == 0)
            {
                selectMidiDevice.Items.Add("No devices detected");

                // Disable list box if there are no devices connected
                selectMidiDevice.Enabled = false;
            }
            else
            {
                for (int deviceIdx = 0; deviceIdx < installedDevices; deviceIdx++)
                {
                    selectMidiDevice.Items.Add(MidiIn.DeviceInfo(deviceIdx).ProductName);
                }
            }
            startButton.Enabled = false;
        }

        private void LogMessage(String str)
        {
            eventLog.Text = eventLog.Text.Insert(0, str + " \r\n");
        }

        private void OnKeyPressed(string note, int velocity, Macro macro)
        {
            // Callback for when a midi key is pressed
            LogMessage(String.Format("[{0} Velocity: {1}]\r\t\r\tMacro: {2}", note, velocity, macro != null ? macro.MacroName : "No macro"));
        }

        private void OnKeyReleased(string note, Macro macro)
        {
            // Callback for when a midi key is released
        }

        private void SelectInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectMidiDevice.SelectedIndex < 0 || selectMidiDevice.SelectedIndex > selectMidiDevice.Items.Count)
                return;

            startButton.Enabled = true;
        }

        // TODO: Change button to a refresh icon
        private void RefreshInputButton_Click(object sender, EventArgs e)
        {
            refreshInputs();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            // Update layout
            startButton.Enabled = false;
            refreshInputButton.Enabled = false;
            selectMidiDevice.Enabled = false;
            stopButton.Enabled = true;

            _controller.CloseMidiDevice(); // Close previous device if necessary
            MidiIn midiInput = new MidiIn(selectMidiDevice.SelectedIndex);
            _controller.AddMidiDevice(midiInput, OnKeyPressed, OnKeyReleased);

            LogMessage("Device successfully connected");
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            // Update Layout
            stopButton.Enabled = false;
            refreshInputButton.Enabled = true;
            selectMidiDevice.Enabled = true;
            eventLog.Clear();
            LogMessage("Device successfully disconnected");
            refreshInputs();

            _controller.CloseMidiDevice();
        }

        private void ClearEventLogButton_Click(object sender, EventArgs e)
        {
            eventLog.Clear();
        }

        
        private void CreateProfileButton_Click(object sender, EventArgs e)
        {  
            InsertNameForm createProfileForm = new InsertNameForm("Create Profile", "Insert profile name", "Create", "Cancel");
            createProfileForm.ShowDialog();
            string profileName = createProfileForm.GetName();

            //Create profile if cancel button wasn't pressed
            if (profileName != null)
            {
                _controller.Profile = new Profile(profileName);

                profileNameTextBox.Text = profileName;
                macrosButton.Enabled = true;
                saveButton.Enabled = true;
                LogMessage("Profile successfully created");
            }
        }

        private void MacrosButton_Click(object sender, EventArgs e)
        {
            MacrosForm macrosForm = new MacrosForm(_controller.Profile);
            macrosForm.ShowDialog();
        }

        // TODO: Change buttons to icons
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (_controller.Profile == null)
                return;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Txt files (*.txt)|*.txt";
            //saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, _controller.Profile.SerializeProfile());
                LogMessage("Profile successfully saved to " + saveFileDialog.FileName);
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!openFileDialog.FileName.EndsWith(".txt"))
                {
                    MessageBox.Show("Invalid format file (Needs to be .txt)", "File Error");
                    return;
                }

                _controller.Profile = Profile.GetProfileFromFile(openFileDialog.FileName);

                profileNameTextBox.Text = _controller.Profile.ProfileName;
                macrosButton.Enabled = true;
                saveButton.Enabled = true;
                LogMessage("Profile successfully loaded");
            }
        }
    }
}
