using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Midi;
using System.Windows.Forms;
using InputManager;

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

        public void AddMacro(Macro macro)
        {
            macros.Add(macro);
        }

        public void RemoveMacro(Macro macro)
        {
            macros.Remove(macro);
        }

        public Macro RunMacros(Pitch pitch, int velocity)
        {
            //TODO: make use of velocity in macros (ex: macros that only take effect if velocity in in a certain velocity limit
            
            //Find correct macro (same pitch)
            foreach (Macro macro in macros)
            {
                if (macro.getPitch() == pitch)
                {
                    macro.Run();
                    return macro;
                }
            }
            return null;
        }

        public Macro StopMacros(Pitch pitch)
        {
            //Find correct macro (same pitch)
            foreach (Macro macro in macros)
            {
                if (macro.getPitch() == pitch)
                {
                    macro.Stop();
                    return macro;
                }
            }
            return null;
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

        public static Macro ReadProfile(string[] args)
        {
            //TODO: Improve code
            if (args[2].Contains("Mouse("))
            {
                String[] mouseMovement = args[2].Split('(');
                int x = Int32.Parse(mouseMovement[1].Split(',')[0]);
                int y = Int32.Parse(mouseMovement[1].Split(',')[1].Replace(")", ""));

                return new MouseMovementMacro(args[0],
                    (Pitch)Enum.Parse(typeof(Pitch), args[1]),
                    x, y);
            }
            else if (args[2].Contains("Mouse"))
            {
                return new MousePressMacro(args[0],
                (Pitch)Enum.Parse(typeof(Pitch), args[1]),
                (Mouse.MouseKeys)Enum.Parse(typeof(Mouse.MouseKeys), args[2].Replace("MouseButton", "")));
            }
            else
            {
                return new KeyboardMacro(args[0],
                (Pitch)Enum.Parse(typeof(Pitch), args[1]),
                (Keys)Enum.Parse(typeof(Keys), args[2]));
            }
        }
    }
}
