using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string musik = "";
        string film = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            musik = "";
            film = "";

            if (checkBox1.Checked)
            {
                musik = "pop";
            }

            if (checkBox2.Checked)
            {
                if (!string.IsNullOrEmpty(musik))
                {
                    musik += ", dangdut";
                }
                else
                {
                    musik = "dangdut";
                }
            }

            if (radioButton1.Checked)
            {
                film = "Action";
            }
            else if (radioButton2.Checked)
            {
                film = "Drama";
            }

            string message = "";

            if (!string.IsNullOrEmpty(musik))
            {
                message += "Anda menyukai musik jenis " + musik;
            }

            if (!string.IsNullOrEmpty(film))
            {
                if (!string.IsNullOrEmpty(message))
                {
                    message += " dan ";
                }
                message += "film bergenre " + film + ".";
            }

            if (string.IsNullOrEmpty(musik) && string.IsNullOrEmpty(film))
            {
                MessageBox.Show("Anda belum memilih musik atau film.");
            }
            else if (string.IsNullOrEmpty(musik))
            {
                MessageBox.Show("Anda menyukai film bergenre " + film + ".");
            }
            else if (string.IsNullOrEmpty(film))
            {
                MessageBox.Show("Anda menyukai musik jenis " + musik + ".");
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
