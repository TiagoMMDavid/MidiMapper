using Midi;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MidiMapper
{
    public class MidiController
    {
        private InputDevice inputDevice;
        private Profile profile;
        private App app;

        public MidiController(App app, InputDevice input)
        {
            this.app = app;
            this.inputDevice = input;

            inputDevice.NoteOn += new InputDevice.NoteOnHandler(this.NoteOn);
            inputDevice.NoteOff += new InputDevice.NoteOffHandler(this.NoteOff);
        }

        public void NoteOn(NoteOnMessage msg)
        {
            //Fixes a bug where some midi controllers assume a key is pressed with the velocity "0" when a key is released.
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
            Macro macro = null;
            if (profile != null)
            {
                macro = profile.RunMacros(pitch, velocity);
            }
            app.DisplayEventInLog(pitch, macro);
        }

        private void NoteReleased(Pitch pitch, int velocity)
        {
            if (profile != null)
            {
                profile.StopMacros(pitch);
            }
        }

        //TODO: find a way that doesn't require Closing MidiController to start another
        public void Close()
        {
            inputDevice.NoteOn -= new InputDevice.NoteOnHandler(this.NoteOn);
            inputDevice.NoteOff -= new InputDevice.NoteOffHandler(this.NoteOff);
        }

        public void SetProfile(Profile profile)
        {
            this.profile = profile;
        }
    }
}