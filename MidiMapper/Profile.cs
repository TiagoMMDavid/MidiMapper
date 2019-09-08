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
        private String profileName;
        private List<Macro> macros;
        

        public Profile(String profileName)
        {
            this.profileName = profileName;
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

        public String GetProfileName()
        {
            return profileName;
        }

        public String SaveProfile()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(profileName);
            foreach (Macro macro in macros)
            {
                stringBuilder.AppendLine();
                stringBuilder.Append(macro.SaveMacro());
            }
            return stringBuilder.ToString();
        }
    }
}
