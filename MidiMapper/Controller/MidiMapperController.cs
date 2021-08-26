using System;
using MidiMapper.Macros;
using NAudio.Midi;

namespace MidiMapper.Controller
{
    public delegate void OnKeyPressed(string note, int velocity, Macro macro);
    public delegate void OnKeyReleased(string note, Macro macro);

    public class MidiMapperController
    {
        public MidiDevice MidiDevice { get; set; }
        public Profile Profile { get; set; }

        private OnKeyPressed _onKeyPressedListener;
        private OnKeyReleased _onKeyReleasedListener;

        public void AddMidiDevice(MidiIn midiInput, OnKeyPressed onKeyPressedListener = null, OnKeyReleased onKeyReleasedListener = null)
        {
            MidiDevice = new MidiDevice(midiInput, OnNoteOn, OnNoteOff);
            this._onKeyPressedListener = onKeyPressedListener;
            this._onKeyReleasedListener = onKeyReleasedListener;
        }

        public void OnNoteOn(string note, int velocity)
        {
            Macro macro = Profile?.ExecuteMacroIfExists(note, velocity);
            _onKeyPressedListener(note, velocity, macro);
        }

        public void OnNoteOff(string note)
        {
            Macro macro = Profile?.StopMacroIfExists(note);
            _onKeyReleasedListener(note, macro);
        }


        public void CloseMidiDevice()
        {
            if (MidiDevice != null)
            {
                MidiDevice.Close();
                MidiDevice = null;
            }
        }
    }
}
