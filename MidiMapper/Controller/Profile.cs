using System;
using System.Collections.Generic;
using System.Text;
using Midi;
using System.Windows.Forms;
using InputManager;
using MidiMapper.Macros;

namespace MidiMapper.Controller
{
    public class Profile
    {
        private string profileName;
        private List<Macro> macros;

        public Profile(string profileName)
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

        public string GetProfileName()
        {
            return profileName;
        }

        public string SaveProfile()
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
                string[] mouseMovement = args[2].Split('(');
                int x = int.Parse(mouseMovement[1].Split(',')[0]);
                int y = int.Parse(mouseMovement[1].Split(',')[1].Replace(")", ""));

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
