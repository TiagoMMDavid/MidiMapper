using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Midi;

namespace MidiMapper
{
    public class Macro
    {
        private String macroName;
        private Pitch pitchKey;
        private String keybind;

        public Macro(String macroName, Pitch pitchKey, String keybind)
        {
            this.macroName = macroName;
            this.pitchKey = pitchKey;

            //TODO: FIX SPECIAL CASES (example: enter key)
            this.keybind = keybind;
        }

        public void Run()
        {
            SendKeys.Send(keybind);
        }

        public Pitch getPitch()
        {
            return pitchKey;
        }

        public String getName()
        {
            return macroName;
        }

        public String SaveMacro()
        {
            return macroName + ";" + pitchKey + ";" + keybind;
        }

        public override String ToString()
        {
            return macroName + " (Presses '" + keybind + "' key)";
        }
    }
}
