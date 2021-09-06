using System;
using NAudio.Midi;
using MidiMapper.Utils;

namespace MidiMapper.Controller
{
    public delegate void OnNoteOn(string note, int velocity);
    public delegate void OnNoteOff(string note);

    public class MidiDevice
    {
        private readonly MidiIn _midiInput;
        private readonly OnNoteOn _onNoteOnListener;
        private readonly OnNoteOff _onNoteOffListener;

        public MidiDevice(MidiIn midiInput, OnNoteOn onNoteOnListener, OnNoteOff onNoteOffListener)
        {
            _midiInput = midiInput;
            _onNoteOnListener = onNoteOnListener;
            _onNoteOffListener = onNoteOffListener;

            _midiInput.MessageReceived += OnMidiMessage;
            _midiInput.ErrorReceived += OnMidiError;
            _midiInput.Start();
        }

        private void OnMidiMessage(object sender, MidiInMessageEventArgs evt)
        {
            if (evt.MidiEvent.CommandCode != MidiCommandCode.NoteOn || evt.MidiEvent.CommandCode == MidiCommandCode.NoteOff)
                return; // Ignore non note events

            NoteEvent noteEvent = evt.MidiEvent as NoteEvent;
            string noteName = MidiUtils.GetNoteNameFromMidiNoteNumber(noteEvent.NoteNumber);
            
            if (noteEvent.Velocity != 0 && evt.MidiEvent.CommandCode == MidiCommandCode.NoteOn)
                _onNoteOnListener(noteName, noteEvent.Velocity);
            else
                _onNoteOffListener(noteName);

        }

        private void OnMidiError(object sender, MidiInMessageEventArgs evt)
        {
            Console.WriteLine($"Error received: " +
                              $"Time {evt.Timestamp} Message 0x{evt.RawMessage:X8} Event {evt.MidiEvent}");
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