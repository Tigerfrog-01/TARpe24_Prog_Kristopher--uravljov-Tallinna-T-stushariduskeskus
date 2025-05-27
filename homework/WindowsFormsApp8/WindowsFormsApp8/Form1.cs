using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        private Rectangle _rectangle;
        private Rectangle _ball;
        private int _ballDx;
        private int _ballDy;
        private Timer _timer;
        private const int RectSize = 35;
        private const int BallSize = 50;

        private int _lives = 3;
        private bool _gameOver = false;

        public Form1()
        {

            InitializeComponent();

            _rectangle = new Rectangle(50, 50, RectSize, RectSize);
            _ball = new Rectangle(100, 100, BallSize, BallSize);

            Random rnd = new Random();
            _ballDx = rnd.Next(-3, 4);
            _ballDy = rnd.Next(-3, 4);
            if (_ballDx == 0) _ballDx = 2;
            if (_ballDy == 0) _ballDy = 2;

            _timer = new Timer();
            _timer.Interval = 16;
            _timer.Tick += Timer_Tick;
            _timer.Start();

            this.KeyPreview = true;
            this.KeyDown += Form1KeyDown;

            playgroundPanel.Paint += PlayGroundPaint;

            UpdateTitle();
        }

        private void PlayGroundPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            e.Graphics.FillRectangle(Brushes.Blue, _rectangle);
            e.Graphics.FillEllipse(Brushes.Red, _ball);
        }

     


        private void Form1KeyDown(object sender, KeyEventArgs e)
        {
            if (_gameOver)
                return;

            const int Step = 5;

            switch (e.KeyCode)
            {
                case Keys.W:
                    if (_rectangle.Y - Step >= 0)
                        _rectangle.Y -= Step;
                    break;
                case Keys.S:
                    if (_rectangle.Y + Step + _rectangle.Height <= playgroundPanel.Height)
                        _rectangle.Y += Step;
                    break;
                case Keys.A:
                    if (_rectangle.X - Step >= 0)
                        _rectangle.X -= Step;
                    break;
                case Keys.D:
                    if (_rectangle.X + Step + _rectangle.Width <= playgroundPanel.Width)
                        _rectangle.X += Step;
                    break;
            }
            playgroundPanel.Invalidate();
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            if (_gameOver)
                return;

            _ball.X += _ballDx;
            _ball.Y += _ballDy;

            
            if (_ball.X <= 0)
            {
                _ball.X = 0;
                _ballDx = -_ballDx;
            }
            else if (_ball.X + BallSize >= playgroundPanel.Width)
            {
                _ball.X = playgroundPanel.Width - BallSize;
                _ballDx = -_ballDx;
            }

            if (_ball.Y <= 0)
            {
                _ball.Y = 0;
                _ballDy = -_ballDy;
            }
            else if (_ball.Y + BallSize >= playgroundPanel.Height)
            {
                _ball.Y = playgroundPanel.Height - BallSize;
                _ballDy = -_ballDy;
            }

         
            if (_rectangle.IntersectsWith(_ball))
            {
              
                _lives--;
                UpdateTitle();

               
                if (_lives <= 0)
                {
                    _gameOver = true;
                    _timer.Stop();
                    MessageBox.Show("Game Over! Rectangle lost all lives", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; 
                }

                
                Rectangle intersection = Rectangle.Intersect(_rectangle, _ball);
                if (intersection.Width > intersection.Height)
                {
                   
                    _ballDy = -_ballDy;
                    _ball.Y += _ballDy;
                }
                else
                {
                    
                    _ballDx = -_ballDx;
                    _ball.X += _ballDx;
                }
            }
            playgroundPanel.Invalidate();
        }
                 private void UpdateTitle()
        {
            this.Text = $"Rectangle Lives: {_lives}";
        }
    }
}
