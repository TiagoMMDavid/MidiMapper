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

        public void RemoveMacro(Macro macro)
        {
            macros.Remove(macro);
        }

        public Macro RunMacros(Pitch pitch, int velocity)
        {
            //TODO: make use of velocity in macros (ex: macros that only take effect if velocity in in a certain velocity limit
            //TODO: search through all macros if pitch corresponds and call RunMacro() inside macro.cs
            return null;
        }

        public void StopMacros(Pitch pitch)
        {
            //TODO: search through all macros if pitch correspondsand call StopMacro() inside macro.cs
        }

        public int GetMacroCount()
        {
            return macros.Count;
        }

        public Macro GetMacroAtIndex(int idx)
        {
            if (idx < 0 || idx > macros.Count)
                throw new IndexOutOfRangeException("Invalid index");
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
