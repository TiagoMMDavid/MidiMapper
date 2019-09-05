using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Midi;

namespace MidiMapper
{
    public class Profile
    {
        private String name;
        private List<Macro> macros;
        

        public Profile(String name)
        {
            this.name = name;
            macros = new List<Macro>();
        }

        //TODO: Special keyboard keys, maybe make an enum
        public void AddMacro(String macroName, Pitch pitchKey, String keybind)
        {
            macros.Add(new Macro(macroName, pitchKey, keybind));
        }

        public void RemoveMacro(String macroName)
        {
           //TODO:
        }

        public void RemoveMacro(int MacroIdx)
        {
            //TODO:
        }

        public int GetMacroCount()
        {
            return macros.Count;
        }

        public Macro GetMacroAtIndex(int idx)
        {
            return macros[idx];
        }
    }
}
