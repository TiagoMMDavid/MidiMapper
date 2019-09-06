using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Midi;

namespace MidiMapper
{
    public partial class App : Form
    {

        private InputDevice inputDevice;
        private Program ctrl;

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

                //Disable list box and connect button if there are no devices connected
                selectInputBox.Enabled = false;
                startButton.Enabled = false;
            }
            else
            {
                for (int i = 0; i < installedDevices; i++)
                {
                    selectInputBox.Items.Add(InputDevice.InstalledDevices[i].Name);
                }
            }
        }

        //TODO: Check if working when there is a profile
        public void DisplayEventInLog(Pitch pitch, Macro macro)
        {
            String evt = "Pitch - " + pitch + (macro == null ? ", No macro" : macro.ToString()) + "\r\n";
            Console.WriteLine(evt, "App"); //DEBUG
            eventLog.Text = eventLog.Text.Insert(0, evt);
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

            ctrl = new Program();
            ctrl.Start(inputDevice, this);
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            if (ctrl != null && inputDevice != null)
            {
                ctrl = null;
                inputDevice = null;
            }
                

            stopButton.Enabled = false;
            refreshInputButton.Enabled = true;
            selectInputBox.Enabled = true;
            eventLog.Clear();
            refreshInputs();
        }

        private void PressKeyTimer_Tick(object sender, EventArgs e)
        {
            if (inputDevice != null && ctrl != null)
            {
                ctrl.CheckForKeys();
            }
        }

        //DEBUG PURPOSE ONLY, WILL BE REPLACED BY ACTUAL GUI LATER
        private void MacroDebugTest()
        {
            Profile test = new Profile("Test");
            test.AddMacro("C4 - Press W", Pitch.C4, "W");
            test.AddMacro("C5 - Press S", Pitch.C5, "S");
            ctrl.setProfile(test);
        }

    }
}
