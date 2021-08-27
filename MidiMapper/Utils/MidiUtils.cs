using System;

namespace MidiMapper.Utils
{
    public class MidiUtils
    {
        private static readonly string[] noteNames = new string[] { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };

        public static string GetNoteNameFromMidiNoteNumber(int noteNumber)
        {
            int octave = (noteNumber / 12) - 1;
            return String.Format("{0}{1}", noteNames[noteNumber % 12], octave);
        }

        // Note name is considered valid if the note is in the noteNames array and the octave is between 0-9 (e.g: C#1)
        public static bool IsNoteNameValid(string noteName)
        {
            if (!Char.IsDigit(noteName[noteName.Length - 1]))
                return false; // Octave is not present or is not the last character

            string note = noteName.Substring(0, noteName.Length - 1); // Remove octave from note
            if (Array.IndexOf(noteNames, note.ToUpper()) == -1)
                return false; // Invalid note name

            return true;
        }
    }
}
