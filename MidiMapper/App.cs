using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Midi;

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

        private InputDevice inputDevice;
        private MidiController midiDevice;
        private Profile profile;

        public App()
        {
            InitializeComponent();
            refreshInputs();
        }

        //TODO: Not working, inputDevice doesn't refresh while app is open
        private void refreshInputs()
        {
            selectInputBox.Enabled = true;
            selectInputBox.Items.Clear();

            int installedDevices = InputDevice.InstalledDevices.Count;
            if (installedDevices == 0)
            {
                selectInputBox.Items.Add("No devices detected");

                //Disable list box if there are no devices connected
                selectInputBox.Enabled = false;
            }
            else
            {
                for (int i = 0; i < installedDevices; i++)
                {
                    selectInputBox.Items.Add(InputDevice.InstalledDevices[i].Name);
                }
            }
            startButton.Enabled = false;
        }

        public void DisplayEventInLog(Pitch pitch, Macro macro)
        {
            String evt = "Pitch - " + pitch + (macro == null ? " \r\t No macro" : " \r\t Macro: " + macro.ToString());
            EventLogWriteLine(evt, 0);
        }

        private void SelectInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectInputBox.SelectedIndex < 0 || selectInputBox.SelectedIndex > selectInputBox.Items.Count)
                return;

            inputDevice = InputDevice.InstalledDevices[selectInputBox.SelectedIndex];
            startButton.Enabled = true;

        }

        //TODO: CHANGE TXT BUTTON TO REFRESH ICON
        private void RefreshInputButton_Click(object sender, EventArgs e)
        {
            refreshInputs();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            refreshInputButton.Enabled = false;
            selectInputBox.Enabled = false;
            stopButton.Enabled = true;

            //Start midiController
            if (!inputDevice.IsOpen)
                inputDevice.Open();
            if (!inputDevice.IsReceiving)
                inputDevice.StartReceiving(null);

            midiDevice = new MidiController(this, inputDevice);
            
            if (profile != null)
                midiDevice.SetProfile(profile);

            EventLogWriteLine("Device successfully connected", 0);
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            if (midiDevice != null && inputDevice != null)
            {
                midiDevice.Close();
                midiDevice = null;
                inputDevice = null;
            }
                

            stopButton.Enabled = false;
            refreshInputButton.Enabled = true;
            selectInputBox.Enabled = true;
            eventLog.Clear();
            EventLogWriteLine("Device successfully disconnected", 0);
            refreshInputs();
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
                profile = new Profile(profileName);
                profileNameTextBox.Text = profile.GetProfileName();
                macrosButton.Enabled = true;
                saveButton.Enabled = true;
                EventLogWriteLine("Profile successfully created", 0);
            }
        }

        private void MacrosButton_Click(object sender, EventArgs e)
        {
            MacrosForm macrosForm = new MacrosForm(this);
            macrosForm.ShowDialog();
        }

        //TODO: CHANGE BUTTONS TO ICONS INSTEAD
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (profile != null)
            {
                Stream stream;
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Txt files (*.txt)|*.txt";
                //saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if ((stream = saveFileDialog.OpenFile()) != null)
                    {
                        //Write profile information
                        StreamWriter sw = new StreamWriter(stream);
                        sw.Write(profile.SaveProfile());
                        sw.Close();
                        stream.Close();
                    }
                }
                EventLogWriteLine("Profile successfully saved to " + saveFileDialog.FileName, 0);
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader sr = new StreamReader(openFileDialog.FileName);
                    //Check if its a .txt file
                    if (!openFileDialog.FileName.Contains(".txt"))
                    {
                        MessageBox.Show("Invalid format file (Needs to be .txt)", "File Error");
                        return;
                    }

                    LoadProfile(sr);
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
                }
            }
            
        }

        //TODO: Give errors if file is not with the correct formula
        private void LoadProfile(StreamReader sr)
        {
            String line = sr.ReadLine();
            profile = new Profile(line);

            line = sr.ReadLine();
            //Go through all macros
            while (line != null)
            {
                String[] args = line.Split(';');
                profile.AddMacro(args[0], (Pitch) Enum.Parse(typeof(Pitch), args[1]), args[2]);
                line = sr.ReadLine();
            }

            if (midiDevice != null)
                midiDevice.SetProfile(profile);

            macrosButton.Enabled = true;
            profileNameTextBox.Text = profile.GetProfileName();
            saveButton.Enabled = true;
            EventLogWriteLine("Profile successfully loaded", 0);
            
            sr.Close();
        }

        private void EventLogWriteLine(String str, int idx)
        {
            eventLog.Text = eventLog.Text.Insert(idx, str + " \r\n");
        }

        public Profile GetProfile()
        {
            //TODO: find a better suiting exception
            if (profile == null)
                throw new Exception("Profile is null");

            return profile;
        }

        private void App_Load(object sender, EventArgs e)
        {

        }
    }
}
