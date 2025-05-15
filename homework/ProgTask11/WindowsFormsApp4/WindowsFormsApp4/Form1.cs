using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        int m;
        int s;

        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
           
            if (MinutesBox.Text == "")
            {

                MinutesBox.Text = "0";  

            }

            if (SecondBox.Text == "")
            {

                SecondBox.Text = "0";

            }
            
            s = Convert.ToInt32(SecondBox.Text);
            m = Convert.ToInt32(MinutesBox.Text);

            timer1.Start();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SecondBox.Text = null;
            MinutesBox.Text = null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s = s - 1;

            if (s == -1)
            {
                m = m - 1;
                s = 59;
            }

            if ((s == 0) && (m == 0))
            {

                timer1.Stop();
                MessageBox.Show("Times Up!");
                SecondBox.ForeColor = Color.Red;
                MinutesBox.ForeColor = Color.Red;
                
            }

            if (s > 59) 
            {
                SecondBox.Text = null;
                timer1.Stop();
                MessageBox.Show("The second cannot be over 60s, max limit is 60s");
           
            }
            



            string mm = Convert.ToString(m);
            string ss = Convert.ToString(s);

            MinutesBox.Text = mm;
            SecondBox.Text = ss;
        }

        private void SecondBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
