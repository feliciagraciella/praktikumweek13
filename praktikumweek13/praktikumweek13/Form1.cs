using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktikumweek13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonProses_Click(object sender, EventArgs e)
        {
            if (labelTulisan.Text == "[EMPTY]")
            {
                labelTulisan.Text = textBoxInput.Text;
            }
            else if (labelTulisan.Text != "[EMPTY]")
            {
                if (textBoxInput.Text == "DELETE")
                {
                    labelTulisan.Text = "[EMPTY]";
                    labelTulisan.ForeColor = Color.Black;
                }
                else if (textBoxInput.Text == "HIDE")
                {
                    labelTulisan.Visible = false;
                }
                else if (textBoxInput.Text == "SHOWN")
                {
                    labelTulisan.Visible = true;
                }
                else if (textBoxInput.Text == "BLUE")
                {
                    labelTulisan.ForeColor = Color.Blue;
                }
                else if (textBoxInput.Text == "RED")
                {
                    labelTulisan.ForeColor = Color.Red;
                }
                else if (textBoxInput.Text == "GREEN")
                {
                    labelTulisan.ForeColor = Color.Green;
                }
            }
        }
    }
}
