using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Midi;

namespace MidiMapper
{
    public abstract class Macro
    {
        protected String macroName;
        protected Pitch pitchKey;

        public Macro(String macroName, Pitch pitchKey)
        {
            this.macroName = macroName;
            this.pitchKey = pitchKey;
        }

        public abstract void Run();

        public abstract void Stop();

        public abstract String SaveMacro();

        public Pitch getPitch()
        {
            return pitchKey;
        }

        public String getMacroName()
        {
            return macroName;
        }

        public override String ToString()
        {
            return macroName;
        }
    }
}
