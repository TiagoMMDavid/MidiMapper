using Midi;

namespace MidiMapper.Macros
{
    public abstract class Macro
    {
        protected string macroName;
        protected Pitch pitchKey;

        public Macro(string macroName, Pitch pitchKey)
        {
            this.macroName = macroName;
            this.pitchKey = pitchKey;
        }

        public abstract void Run();

        public abstract void Stop();

        public abstract string SaveMacro();

        public Pitch getPitch()
        {
            return pitchKey;
        }

        public string getMacroName()
        {
            return macroName;
        }

        public override string ToString()
        {
            return macroName;
        }
    }
}
