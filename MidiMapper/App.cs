﻿using System;
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

        private InputDevice inputDevice;
        private Program ctrl;

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

        public void DisplayEventInLog(Pitch pitch, Macro macro)
        {
            String evt = "Pitch - " + pitch + (macro == null ? " \r\t No macro" : " \r\t Macro: " + macro.ToString()) + "\r\n";
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

            if (profile != null)
                ctrl.setProfile(profile);
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

        private void ClearEventLogButton_Click(object sender, EventArgs e)
        {
            eventLog.Clear();
        }

        //TODO: CHANGE BUTTONS TO ICONS INSTEAD
        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader sr = new StreamReader(openFile.FileName);
                    //Check if its a .txt file
                    if (!openFile.FileName.Contains(".txt"))
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
                String[] args = line.Split(':');
                profile.AddMacro(args[0], (Pitch) Enum.Parse(typeof(Pitch), args[1]), args[2]);
                line = sr.ReadLine();
            }

            if (ctrl != null)
                ctrl.setProfile(profile);

            profileNameTextBox.Text = profile.getName();
            eventLog.Text = eventLog.Text.Insert(0, "Profile successfully loaded");

            sr.Close();
        }
    }
}
