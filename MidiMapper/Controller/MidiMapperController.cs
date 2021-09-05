using System.Collections.Generic;
using NAudio.Midi;
using MidiMapper.Macros;

namespace MidiMapper.Controller
{
    public delegate void OnKeyPressed(string note, int velocity, Macro macro);
    public delegate void OnKeyReleased(string note, Macro macro);

    public class MidiMapperController
    {
        public Profile Profile { get; set; }
        public bool MacrosExecuting = true;
        
        private MidiDevice _midiDevice;
        private readonly List<OnKeyPressed> _onKeyPressedListeners = new List<OnKeyPressed>();
        private readonly List<OnKeyReleased> _onKeyReleasedListeners = new List<OnKeyReleased>();

        public void AddMidiDevice(MidiIn midiInput, OnKeyPressed onKeyPressedListener = null, OnKeyReleased onKeyReleasedListener = null)
        {
            _midiDevice = new MidiDevice(midiInput, OnNoteOn, OnNoteOff);

            if (onKeyPressedListener != null) _onKeyPressedListeners.Add(onKeyPressedListener);
            if (onKeyReleasedListener != null) _onKeyReleasedListeners.Add(onKeyReleasedListener);
        }

        private void OnNoteOn(string note, int velocity)
        {
            Macro macro = MacrosExecuting ?
                Profile?.ExecuteMacroIfExists(note, velocity) :
                Profile?.GetMacro(note);

            // Call all listeners
            foreach(OnKeyPressed listener in _onKeyPressedListeners)
                listener?.Invoke(note, velocity, macro);
        }

        private void OnNoteOff(string note)
        {
            Macro macro = MacrosExecuting ?
                Profile?.StopMacroIfExists(note) :
                Profile?.GetMacro(note);

            // Call all listeners
            foreach (OnKeyReleased listener in _onKeyReleasedListeners)
                listener?.Invoke(note, macro);
        }

        public void AddKeyPressedListener(OnKeyPressed listener) => _onKeyPressedListeners.Add(listener);
        public void RemoveKeyPressedListener(OnKeyPressed listener) => _onKeyPressedListeners.Remove(listener);
        public void AddKeyReleasedListener(OnKeyReleased listener) => _onKeyReleasedListeners.Add(listener);
        public void RemoveKeyReleasedListener(OnKeyReleased listener) => _onKeyReleasedListeners.Remove(listener);

        public void CloseMidiDevice()
        {
            if (_midiDevice == null) return;
            
            _midiDevice.Close();
            _midiDevice = null;
        }
    }
}
