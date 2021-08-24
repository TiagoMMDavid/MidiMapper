using Midi;
using InputManager;

namespace MidiMapper.Macros
{
    class MousePressMacro : Macro
    {
        //TODO: add MouseButtons and scroll with the other enums present in Mouse class
        private Mouse.MouseKeys mouseKey;

        public MousePressMacro(string macroName, Pitch pitchKey, Mouse.MouseKeys mouseKey) : base(macroName, pitchKey)
        {
            this.mouseKey = mouseKey;
        }

        public override void Run()
        {
            Mouse.ButtonDown(mouseKey);
        }

        public override void Stop()
        {
            Mouse.ButtonUp(mouseKey);
        }

        public override string SaveMacro()
        {
            return macroName + ";" + pitchKey + ";MouseButton" + mouseKey.ToString();
        }

        public override string ToString()
        {
            return base.ToString() + ": Presses " + mouseKey + " mouse button";
        }
    }
}
