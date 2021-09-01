using NAudio.Midi;
using MidiMapper.Macros;

namespace MidiMapper.Controller
{
    public delegate void OnKeyPressed(string note, int velocity, Macro macro);
    public delegate void OnKeyReleased(string note, Macro macro);

    public class MidiMapperController
    {
        public Profile Profile { get; set; }
        
        private MidiDevice _midiDevice;
        private OnKeyPressed _onKeyPressedListener;
        private OnKeyReleased _onKeyReleasedListener;

        public void AddMidiDevice(MidiIn midiInput, OnKeyPressed onKeyPressedListener = null, OnKeyReleased onKeyReleasedListener = null)
        {
            _midiDevice = new MidiDevice(midiInput, OnNoteOn, OnNoteOff);
            _onKeyPressedListener = onKeyPressedListener;
            _onKeyReleasedListener = onKeyReleasedListener;
        }

        private void OnNoteOn(string note, int velocity)
        {
            Macro macro = Profile?.ExecuteMacroIfExists(note, velocity);
            _onKeyPressedListener?.Invoke(note, velocity, macro);
        }

        private void OnNoteOff(string note)
        {
            Macro macro = Profile?.StopMacroIfExists(note);
            _onKeyReleasedListener?.Invoke(note, macro);
        }


        public void CloseMidiDevice()
        {
            if (_midiDevice == null) return;
            
            _midiDevice.Close();
            _midiDevice = null;
        }
    }
}
