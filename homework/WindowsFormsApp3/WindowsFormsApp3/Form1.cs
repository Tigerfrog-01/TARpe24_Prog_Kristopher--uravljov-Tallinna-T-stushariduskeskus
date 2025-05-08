using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            for (int y = 1; y < 10; y++)
            {

                int slptime = 1000;
                Task.Delay(100).Wait();
                MovingLabel.Location = new Point(MovingLabel.Location.X+25, MovingLabel.Location.Y);
            }
            for (int y = 1; y < 10; y++)
            {

                int slptime1 = 1000;
                Task.Delay(100).Wait();
                MovingLabel.Location = new Point(MovingLabel.Location.X, MovingLabel.Location.Y + 25);
            }
            for (int y = 1; y < 10; y++)
            {

                int slptime1 = 1000;
                Task.Delay(100).Wait();
                MovingLabel.Location = new Point(MovingLabel.Location.X + -50, MovingLabel.Location.Y);
            }
            for (int y = 1; y < 10; y++)
            {

                int slptime1 = 1000;
                Task.Delay(100).Wait();
                MovingLabel.Location = new Point(MovingLabel.Location.X , MovingLabel.Location.Y + -25);
            }
            


        }

        private void StopButton_Click(object sender, EventArgs e)
        {

        }
    }
}
