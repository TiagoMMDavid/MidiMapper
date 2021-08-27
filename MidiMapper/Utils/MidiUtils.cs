using System;

namespace MidiMapper.Utils
{
    public static class MidiUtils
    {
        private static readonly string[] NoteNames = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
        
        public static string GetNoteNameFromMidiNoteNumber(int noteNumber)
        {
            int octave = (noteNumber / 12) - 1;
            return $"{NoteNames[noteNumber % 12]}{octave}";
        }

        // Note name is considered valid if the note is in the noteNames array and the octave is between 0-9 (e.g: C#1)
        public static bool IsNoteNameValid(string noteName)
        {
            if (!char.IsDigit(noteName[noteName.Length - 1]))
                return false; // Octave is not present or is not the last character

            string note = noteName.Substring(0, noteName.Length - 1); // Remove octave from note
            return Array.IndexOf(NoteNames, note.ToUpper()) != -1; // Returns true if note is in NoteNames
        }
    }
}
