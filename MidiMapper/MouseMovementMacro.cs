using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Midi;
using InputManager;
using System.Windows.Forms;

namespace MidiMapper
{
    class MouseMovementMacro : Macro
    {
        private int xAxis;
        private int yAxis;

        private Timer timer;
        private const int timerInterval = 1;
        bool timerRunning = false;

        public MouseMovementMacro(string macroName, Pitch pitchKey, int xAxis, int yAxis) : base(macroName, pitchKey)
        {
            this.xAxis = xAxis;
            this.yAxis = yAxis;

            timer = new Timer();
            timer.Interval = timerInterval;
            timer.Enabled = true;
            timer.Tick += new EventHandler(Timer_Tick);
        }

        public override void Run()
        {
            timerRunning = true;
        }

        public override void Stop()
        {
            timerRunning = false;
        }

        private void Timer_Tick(object Sender, EventArgs e)
        {
            if (timerRunning)
                Mouse.MoveRelative(xAxis, yAxis);
        }

        public override string SaveMacro()
        {
            return macroName + ";" + pitchKey + ";Mouse(" + xAxis + "," + yAxis + ")";
        }

        public override string ToString()
        {
            return base.ToString() + ": Moves mouse by (" + xAxis + "," + yAxis + ")";
        }
    }
}
