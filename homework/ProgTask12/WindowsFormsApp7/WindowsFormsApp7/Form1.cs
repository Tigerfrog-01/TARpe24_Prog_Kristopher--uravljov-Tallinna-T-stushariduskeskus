using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{

    public partial class Form1 : Form
    {
        private Timer timer;
        private int currentX = 0;  
        private int currentY = 0;  
        private bool movingDown = true;  
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
          


        }

        private void ClickMeButton_Click(object sender, EventArgs e)
        {


            timer1.Start();



        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            


        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb
            (
            (byte)random.Next(0, 255),
            (byte)random.Next(0, 255),
            (byte)random.Next(0, 255)), 10);

          
            Graphics g = this.CreateGraphics();

            
            if (movingDown)
            {
                g.DrawLine(pen, currentX, currentY, currentX, currentY + 10);
                currentY += 10; 
            }
            else
            {
                g.DrawLine(pen, currentX, currentY, currentX, currentY - 10);
                currentY -= 10; 
            }

          
            if (currentY >= this.ClientSize.Height || currentY <= 0)
            {
                
                movingDown = !movingDown; 
                currentX += 10; 

               
                if (currentX >= this.ClientSize.Width)
                {
                    currentX = 0;
                }
            }

        }
           

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
