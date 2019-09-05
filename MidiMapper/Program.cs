using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Midi;

namespace MidiMapper
{
    public class Program
    {
        private static MidiController midiDevice; //Why is it static

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new App());
        }

        public static void Run()
        {
            //Set correct device as input
            //TODO: Choose correct device instead of picking the 1st one
            if (InputDevice.InstalledDevices.Count == 0)
            {
                MessageBox.Show("No midi controllers detected", "Error");
                return;
            }
            InputDevice inputDevice = InputDevice.InstalledDevices[0];
            inputDevice.Open();
            inputDevice.StartReceiving(null);
            midiDevice = new MidiController(inputDevice);
        }

        public static void PressKeyTest()
        {
            //Return if connection hasn't been established yet
            if (midiDevice == null)
                return;

            //HARD CODED
            for (int i = 0; i < midiDevice.GetPressedKeysCount(); i++)
            {
                if (midiDevice.GetPitchAtIndex(i).Equals(Pitch.C5))
                {
                    SendKeys.Send("C");
                }
                else if (midiDevice.GetPitchAtIndex(i).Equals(Pitch.D5))
                {
                    SendKeys.Send("D");
                }
                else if (midiDevice.GetPitchAtIndex(i).Equals(Pitch.E5))
                {
                    SendKeys.Send("E");
                }
                else if (midiDevice.GetPitchAtIndex(i).Equals(Pitch.F5))
                {
                    SendKeys.Send("F");
                }
                else if (midiDevice.GetPitchAtIndex(i).Equals(Pitch.G5))
                {
                    SendKeys.Send("G");
                }
            }
        }
    }
}
