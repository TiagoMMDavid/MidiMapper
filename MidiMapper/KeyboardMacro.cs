using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Midi;
using InputManager;

namespace MidiMapper
{
    class KeyboardMacro : Macro
    {
        private Keys kbdKey;
        public KeyboardMacro(string macroName, Pitch pitchKey, Keys kbdKey) : base(macroName, pitchKey)
        {
            this.kbdKey = kbdKey;
        }

        public override void Run()
        {
            Keyboard.KeyDown(kbdKey);
        }

        public override void Stop()
        {
            Keyboard.KeyUp(kbdKey);
        }

        public override String SaveMacro()
        {
            return macroName + ";" + pitchKey + ";" + kbdKey.ToString();
        }

        public override string ToString()
        {
            return base.ToString() + ": Presses '" + kbdKey + "' key";
        }
    }
}
