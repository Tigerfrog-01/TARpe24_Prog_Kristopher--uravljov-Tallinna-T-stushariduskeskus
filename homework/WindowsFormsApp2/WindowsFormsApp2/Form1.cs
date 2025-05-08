using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UsernameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordText_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

            string text = PasswordText.Text;
            string user = UsernameText.Text;
            if (text == "apple")
            {

                if (user == "Banana")
                {

                    PasswordWrong.Text = "You are logged in!";


                }
                else
                {

                    PasswordWrong.Text = "Its wrong username try again";
                    return;


                }

            }
            else
            {

                PasswordWrong.Text = "its wrong password";
                return;

            }

        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            if (PasswordText.PasswordChar == '*')
            {
                ShowButton.BringToFront();
                PasswordText.PasswordChar = '\0';
            }


        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            if (PasswordText.PasswordChar == '\0')
            {
                HideButton.BringToFront();
                PasswordText.PasswordChar = '*';
            }

        }

    }
}