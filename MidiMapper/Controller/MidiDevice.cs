using NAudio.Midi;
using System;

namespace MidiMapper.Controller
{
    public delegate void OnNoteOn(string note, int velocity);
    public delegate void OnNoteOff(string note);

    public class MidiDevice
    {
        private MidiIn _midiInput;
        private OnNoteOn _onNoteOnListener;
        private OnNoteOff _onNoteOffListener;

        public MidiDevice(MidiIn midiInput, OnNoteOn onNoteOnListener, OnNoteOff onNoteOffListener)
        {
            this._midiInput = midiInput;
            this._onNoteOnListener = onNoteOnListener;
            this._onNoteOffListener = onNoteOffListener;

            _midiInput.MessageReceived += OnMidiMessage;
            _midiInput.ErrorReceived += OnMidiError;
            _midiInput.Start();
        }

        private void OnMidiMessage(object sender, MidiInMessageEventArgs evt)
        {
            if (evt.MidiEvent.CommandCode != MidiCommandCode.NoteOn || evt.MidiEvent.CommandCode == MidiCommandCode.NoteOff)
                return; // Ignore non note events

            NoteEvent noteEvent = evt.MidiEvent as NoteEvent;
            string noteName = GetNoteNameFromMidiNoteNumber(noteEvent.NoteNumber);
            if (noteEvent.Velocity != 0 && evt.MidiEvent.CommandCode == MidiCommandCode.NoteOn)
            {
                // Key pressed event
                _onNoteOnListener(noteName, noteEvent.Velocity);
                var noteOnEvent = new NoteOnEvent(0, 1, noteEvent.NoteNumber, 60, 10);
            }
            else
            {
                // Key released event
                _onNoteOffListener(noteName);
            }

        }

        private void OnMidiError(object sender, MidiInMessageEventArgs evt)
        {
            Console.WriteLine("Error received: " + String.Format("Time {0} Message 0x{1:X8} Event {2}", 
                evt.Timestamp, evt.RawMessage, evt.MidiEvent));
        }

        public void Close()
        {
            _midiInput.MessageReceived -= OnMidiMessage;
            _midiInput.ErrorReceived -= OnMidiError;

            _midiInput.Stop();
            _midiInput.Dispose();
        }

        private static readonly string[] noteNames = new string[] { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };

        private static string GetNoteNameFromMidiNoteNumber(int noteNumber)
        {
            int octave = (noteNumber / 12) - 1;
            return String.Format("{0}{1}", noteNames[noteNumber % 12], octave);
        }
    }
}