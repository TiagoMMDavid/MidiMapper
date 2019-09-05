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
        private string macroName;
        private Pitch pitchKey;
        private string keybind;

        public Macro(string macroName, Pitch pitchKey, string keybind)
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
    }
}
