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
        private App app;

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

        public void Start(InputDevice inputDevice, App app)
        {
            this.app = app;

            if (!inputDevice.IsOpen)
                inputDevice.Open();
            if (!inputDevice.IsReceiving)
                inputDevice.StartReceiving(null);

            midiDevice = new MidiController(inputDevice);
        }

        public void CheckForKeys()
        {
            //Return if connection hasn't been established yet
            if (midiDevice == null)
                return;

            
            for (int i = 0; i < midiDevice.GetPressedKeysCount(); i++)
            {
                Pitch currPitch = midiDevice.GetPitchAtIndex(i);
                Macro currMacro = null;

                if (profile != null)
                {
                    for (int j = 0; j < profile.GetMacroCount(); j++)
                    {
                        if (currPitch.Equals(profile.GetMacroAtIndex(j).getPitch()))
                        {
                            currMacro = profile.GetMacroAtIndex(j);
                            profile.GetMacroAtIndex(j).Run();
                            break;
                        }
                    }
                }
                app.DisplayEventInLog(currPitch, currMacro);
            }
        }

        public void setProfile(Profile profile)
        {
            this.profile = profile;
        }
    }
}
