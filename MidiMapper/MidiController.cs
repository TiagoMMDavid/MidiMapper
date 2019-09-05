using Midi;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MidiMapper
{
    public class MidiController
    {
        private InputDevice inputDevice;
        private List<Pitch> pressedKeys;

        public MidiController(InputDevice input)
        {
            this.inputDevice = input;
            pressedKeys = new List<Pitch>();
            inputDevice.NoteOn += new InputDevice.NoteOnHandler(this.NoteOn);
            inputDevice.NoteOff += new InputDevice.NoteOffHandler(this.NoteOff);
        }

        public void NoteOn(NoteOnMessage msg)
        {
            //Fixes a bug where some midi controllers assume a key was pressed with the velocity "0" when a key is released.
            if (msg.Velocity == 0)
                NoteReleased(msg.Pitch, msg.Velocity);
            else
                NotePressed(msg.Pitch, msg.Velocity);
       
        }

        public void NoteOff(NoteOffMessage msg)
        {
            NoteReleased(msg.Pitch, msg.Velocity);
        }

        private void NotePressed(Pitch pitch, int velocity)
        {
            pressedKeys.Add(pitch);
        }

        private void NoteReleased(Pitch pitch, int velocity)
        {
            pressedKeys.Remove(pitch);
        }

        public Pitch GetPitchAtIndex(int idx)
        {
            return pressedKeys[idx];
        }

        public int GetPressedKeysCount()
        {
            return pressedKeys.Count;
        }
    }
}