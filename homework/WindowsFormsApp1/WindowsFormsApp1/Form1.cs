using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private DateTime endDate = new DateTime(2025, 12, 25, 19, 0, 0);

        public Form1()
        {
            InitializeComponent();
            Timer.Interval = 100;
            Timer.Tick += Timer_Tick;
            Timer.Start();
        }

        private void CountDays_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void CountHours_Click(object sender, EventArgs e)
        {

        }

        private void CountMinutes_Click(object sender, EventArgs e)
        {

        }

        private void CountSeconds_Click(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Timer.Start();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            Timer.Stop();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan remainingTime = endDate - DateTime.Now;

            
            if (remainingTime.TotalMilliseconds <= 0)
            {
                Timer.Stop();
                CountDown.Text = "The event is over now";
                return;
            }
            CountDown.Text = string.Format("{0:D2} days, {1:D2} hours, {2:D2} minutes, {3:D2} seconds, miliseconds {4:D2}",
             remainingTime.Days,
             remainingTime.Hours,
             remainingTime.Minutes,
             remainingTime.Seconds,
             remainingTime.Milliseconds);
        }
    }
}
