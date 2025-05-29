using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        private const string ScoreFilePath = @"C:\Users\opilane\Downloads\scores.txt";

        private Rectangle _rectangle;
        private Rectangle _redBall;
        private Rectangle _greenBall;

        private int _redBallDx;
        private int _redBallDy;

        private Timer _mainTimer;
        private Timer _greenBallTimer;
        private DateTime _startTime;

        private const int RectSize = 20;
        private const int GreenBallSize = 10;

        private Random _random = new Random();
        private int _score = 0;
        private int _lives = 3;
        private bool _gameOver = false;
        public Form1()
        {
            InitializeComponent();

            var (redBallSpeed, redBallSize) = GetRedBallSettings();

            _rectangle = new Rectangle(50, 50, RectSize, RectSize);
            _redBall = new Rectangle(100, 100, redBallSize, redBallSize);
            _greenBall = SpawnGreenBall();

            _redBallDx = _random.Next(-redBallSpeed, redBallSpeed + 1);
            _redBallDy = _random.Next(-redBallSpeed, redBallSpeed + 1);
            if (_redBallDx == 0) _redBallDx = redBallSpeed / 2;
            if (_redBallDy == 0) _redBallDy = redBallSpeed / 2;

            _mainTimer = new Timer { Interval = 16 };
            _mainTimer.Tick += Timer_Tick;
            _mainTimer.Start();

            _greenBallTimer = new Timer { Interval = 3000 };
            _greenBallTimer.Tick += greenballtimer_Tick;
            _greenBallTimer.Start();

            _startTime = DateTime.Now;

            this.KeyPreview = true;
            this.KeyDown += Form1KeyDown;
            playgroundPanel.Paint += PlayGroundPaint;

            UpdateTitle();
        }



        private Rectangle SpawnGreenBall()
        {
            int x = _random.Next(0, playgroundPanel.Width - GreenBallSize);
            int y = _random.Next(0, playgroundPanel.Height - GreenBallSize);
            return new Rectangle(x, y, GreenBallSize, GreenBallSize);
        }

        private void PlayGroundPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);


            e.Graphics.FillRectangle(Brushes.Blue, _rectangle);


            e.Graphics.FillEllipse(Brushes.Red, _redBall);


            e.Graphics.FillEllipse(Brushes.Green, _greenBall);
        }





        private void Form1KeyDown(object sender, KeyEventArgs e)
        {
            if (_gameOver) return;

            const int Step = 5;

            switch (e.KeyCode)
            {
                case Keys.W:
                    if (_rectangle.Y - Step >= 0) _rectangle.Y -= Step;
                    break;
                case Keys.S:
                    if (_rectangle.Y + Step + _rectangle.Height <= playgroundPanel.Height) _rectangle.Y += Step;
                    break;
                case Keys.A:
                    if (_rectangle.X - Step >= 0) _rectangle.X -= Step;
                    break;
                case Keys.D:
                    if (_rectangle.X + Step + _rectangle.Width <= playgroundPanel.Width) _rectangle.X += Step;
                    break;
            }
            playgroundPanel.Invalidate();
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            if (_gameOver) return;

           
            _redBall.X += _redBallDx;
            _redBall.Y += _redBallDy;

          
            if (_redBall.X <= 0 || _redBall.X + _redBall.Width >= playgroundPanel.Width) _redBallDx = -_redBallDx;
            if (_redBall.Y <= 0 || _redBall.Y + _redBall.Height >= playgroundPanel.Height) _redBallDy = -_redBallDy;

           
            if (_rectangle.IntersectsWith(_redBall))
            {
                _lives--;
                UpdateTitle();

                if (_lives <= 0)
                {
                    EndGame();
                    return;
                }

                Rectangle intersection = Rectangle.Intersect(_rectangle, _redBall);
                if (intersection.Width > intersection.Height) _redBallDy = -_redBallDy;
                else _redBallDx = -_redBallDx;
            }

            
            if (_rectangle.IntersectsWith(_greenBall))
            {
                _score++;
                if (_score % 5 == 0) _lives++;
                _greenBall = SpawnGreenBall();
                UpdateTitle();
            }
            playgroundPanel.Invalidate();
        }

        private void EndGame()
        {
            _gameOver = true;
            _mainTimer.Stop();
            _greenBallTimer.Stop();

            TimeSpan survivalTime = DateTime.Now - _startTime;
            int survivalBonus = (int)survivalTime.TotalSeconds;
            _score += survivalBonus;

            string message = $"Game Over!\n\nFinal Score: {_score}\nSurvival Time: {survivalTime.TotalSeconds:F1} seconds\nBonus Points for Survival: {survivalBonus}";
            MessageBox.Show(message, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);

            HandleHighScores(_score);
            DisplayHighScores();
        }
        private void HandleHighScores(int newScore)
        {

            List<int> scores = LoadScores();

            if (scores.Count < 3 || newScore > scores.Min())
            {
                scores.Add(newScore);
                scores = scores.OrderByDescending(s => s).Take(3).ToList();
                SaveScores(scores);
            }
        }
        private List<int> LoadScores()
        {
            if (!File.Exists(ScoreFilePath))
            {
                File.WriteAllText(ScoreFilePath, string.Empty);
                return new List<int>();
            }

            return File.ReadAllLines(ScoreFilePath)
                       .Where(line => int.TryParse(line, out _))
                       .Select(int.Parse)
                       .ToList();
        
            
        }

        private void UpdateTitle()
        {
            this.Text = $"Lives: {_lives} | Score: {_score}";
        }
        
        private void greenballtimer_Tick(object sender, EventArgs e)
        {
            _greenBall = SpawnGreenBall();
            playgroundPanel.Invalidate();
        }

        private void SaveScores(List<int> scores)
        {
            File.WriteAllLines(ScoreFilePath, scores.Select(score => score.ToString()));
        }

        private void DisplayHighScores()
        {
            List<int> scores = LoadScores();
            string highScores = string.Join("\n", scores.Select((score, index) => $"{index + 1}. {score}"));
            MessageBox.Show($"High Scores:\n{highScores}", "High Scores", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private (int, int) GetRedBallSettings()
        {
            using (Form inputForm = new Form())
            {
                inputForm.Text = "Set Red Ball Settings";
                inputForm.Width = 300;
                inputForm.Height = 200;

                Label lblSpeed = new Label { Left = 20, Top = 20, Text = "Speed (1-10):" };
                TextBox txtSpeed = new TextBox { Left = 150, Top = 20, Width = 100 };
                Label lblSize = new Label { Left = 20, Top = 60, Text = "Size (10-30):" };
                TextBox txtSize = new TextBox { Left = 150, Top = 60, Width = 100 };
                Button btnOk = new Button { Text = "OK", Left = 100, Width = 100, Top = 100, DialogResult = DialogResult.OK };

                inputForm.Controls.Add(lblSpeed);
                inputForm.Controls.Add(txtSpeed);
                inputForm.Controls.Add(lblSize);
                inputForm.Controls.Add(txtSize);
                inputForm.Controls.Add(btnOk);

                inputForm.AcceptButton = btnOk;

                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    int speed = int.TryParse(txtSpeed.Text, out int parsedSpeed) ? parsedSpeed : 3;
                    int size = int.TryParse(txtSize.Text, out int parsedSize) ? parsedSize : 15;
                    return (speed, size);
                }
            }
            return (3, 15);
        }
    }
}