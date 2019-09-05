﻿using System;
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
        private Program program;

        public App()
        {
            InitializeComponent();

            program = new Program();

            //Select input box
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
                connectButton.Enabled = false;
            }
            else
            {
                for (int i = 0; i < installedDevices; i++)
                {
                    selectInputBox.Items.Add(InputDevice.InstalledDevices[i]);
                }
            }
        }

        private void SelectInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            inputDevice = InputDevice.InstalledDevices[selectInputBox.SelectedIndex];
            connectButton.Enabled = true;

        }

        //TODO: CHANGE TXT BUTTON TO REFRESH ICON
        private void RefreshInputButton_Click(object sender, EventArgs e)
        {
            refreshInputs();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            connectButton.Enabled = false;
            refreshInputButton.Enabled = false;
            selectInputBox.Enabled = false;

            program.Start(inputDevice);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (inputDevice != null)
            {
                program.CheckForKeys();
            }
        }

        //DEBUG PURPOSE ONLY, WILL BE REPLACED BY ACTUAL GUI LATER
        private void MacroDebugTest()
        {
            Profile test = new Profile("Test");
            test.AddMacro("C4 - Press W", Pitch.C4, "W");
            test.AddMacro("C5 - Press S", Pitch.C5, "S");
            program.setProfile(test);
        }
    }
}
