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
        private Label MovingLabel;
        private Label X;
        private Label Y;
        private Button StartButton;
        private Button StopButton;
        private Timer timer;

        private int step = 10;
        private int direction;


        private int origX, origY;
        private int leftBound, rightBound, topBound, bottomBound;

        public Form1()
        {
            this.Text = "Flying Label";
            this.ClientSize = new Size(400, 300);


            MovingLabel = new Label();
            MovingLabel.Text = "I'm flying";
            MovingLabel.AutoSize = true;
            MovingLabel.Location = new Point(10, 10);
            this.Controls.Add(MovingLabel);


            X = new Label();
            X.Text = "X: 10";
            X.Location = new Point(10, 40);
            this.Controls.Add(X);

            Y = new Label();
            Y.Text = "Y: 10";
            Y.Location = new Point(10, 60);
            this.Controls.Add(Y);


            StartButton = new Button();
            StartButton.Text = "Start";
            StartButton.Location = new Point(10, 100);
            StartButton.Click += StartButton_Click;
            this.Controls.Add(StartButton);


            StopButton = new Button();
            StopButton.Text = "Stop";
            StopButton.Location = new Point(100, 100);
            StopButton.Click += StopButton_Click;
            this.Controls.Add(StopButton);


            timer = new Timer();
            timer.Interval = 400;
            timer.Tick += Timer_Tick;


            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            origX = MovingLabel.Location.X;
            origY = MovingLabel.Location.Y;
            leftBound = origX;
            topBound = origY;

            rightBound = this.ClientSize.Width - MovingLabel.Width;
            bottomBound = this.ClientSize.Height - MovingLabel.Height;
            direction = 0;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            Point pos = MovingLabel.Location;

            if (direction == 0)
            {

                if (pos.X + step <= rightBound)
                {
                    pos.X += step;
                }
                else
                {
                    pos.X = rightBound;
                    direction = 1;
                }
            }
            else if (direction == 1)
            {
                if (pos.Y + step <= bottomBound)
                {
                    pos.Y += step;
                }
                else
                {
                    pos.Y = bottomBound;
                    direction = 2;
                }
            }
            else if (direction == 2)
            {
                if (pos.X - step >= leftBound)
                {
                    pos.X -= step;
                }
                else
                {
                    pos.X = leftBound;
                    direction = 3;
                }
            }
            else if (direction == 3)
            {
                if (pos.Y - step >= topBound)
                {
                    pos.Y -= step;
                }
                else
                {
                    pos.Y = topBound;
                    direction = 0;
                }
            }


            MovingLabel.Location = pos;


            X.Text = "X: " + pos.X;
            Y.Text = "Y: " + pos.Y;
        }
    }
}