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
        private MidiController midiDevice;
        private Profile profile;

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

        public void Start(InputDevice inputDevice)
        {
            inputDevice.Open();
            inputDevice.StartReceiving(null);
            midiDevice = new MidiController(inputDevice);
        }

        public void CheckForKeys()
        {
            //Return if connection hasn't been established yet
            //TODO: CHECK FOR PROFILE
            if (midiDevice == null || profile == null)
                return;

            for (int i = 0; i < midiDevice.GetPressedKeysCount(); i++)
            {
                for (int j = 0; j < profile.GetMacroCount(); j++)
                {
                    if (midiDevice.GetPitchAtIndex(i).Equals(profile.GetMacroAtIndex(j).getPitch()))
                    {
                        profile.GetMacroAtIndex(j).Run();
                    }
                }
            }
        }

        public void setProfile(Profile profile)
        {
            this.profile = profile;
        }
    }
}
