using MidiMapper.Macros;
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
            if (noteEvent.Velocity != 0 && evt.MidiEvent.CommandCode == MidiCommandCode.NoteOn)
            {
                // Key pressed event
                _onNoteOnListener(noteEvent.NoteName, noteEvent.Velocity);
            }
            else
            {
                // Key released event
                _onNoteOffListener(noteEvent.NoteName);
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
    }
}