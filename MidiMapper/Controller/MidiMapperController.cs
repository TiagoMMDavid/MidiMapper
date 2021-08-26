using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Midi;

namespace MidiMapper.Controller
{
    public class MidiMapperController
    {
        public MidiDevice MidiDevice { get; set; }
        public Profile Profile { get; set; }

        public void AddMidiDevice(MidiIn midiInput)
        {
            MidiDevice = new MidiDevice(midiInput, OnNoteOn, OnNoteOff);
        }

        public void OnNoteOn(string note, int velocity)
        {
            Console.WriteLine("Note pressed: " + note);
            Profile?.ExecuteMacroIfExists(note, velocity);
        }

        public void OnNoteOff(string note)
        {
            Console.WriteLine("Note released: " + note);
            Profile?.StopMacroIfExists(note);
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
