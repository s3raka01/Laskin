using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edistyneempi_laskin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int luku1 = 0;
        int luku2 = 0;
        String valinta;
        int tulos;

        private void nappi1_Click(object sender, EventArgs e)
        {
            textBox3.Text += 1;
        }

        private void nappi2_Click(object sender, EventArgs e)
        {
            textBox3.Text += 2;
        }

        private void nappi4_Click(object sender, EventArgs e)
        {
            textBox3.Text += 4;
        }

        private void nappi3_Click(object sender, EventArgs e)
        {
            textBox3.Text += 3;
        }

        private void nappi5_Click(object sender, EventArgs e)
        {
            textBox3.Text += 5;
        }

        private void nappi6_Click(object sender, EventArgs e)
        {
            textBox3.Text += 6;
        }

        private void nappi7_Click(object sender, EventArgs e)
        {
            textBox3.Text += 7;
        }

        private void nappi8_Click(object sender, EventArgs e)
        {
            textBox3.Text += 8;
        }

        private void nappi9_Click(object sender, EventArgs e)
        {
            textBox3.Text += 9;
        }

        private void nappi0_Click(object sender, EventArgs e)
        {
            textBox3.Text += 0;
        }

        private void kerto_Click(object sender, EventArgs e)
        {
                textBox3.Text += " * ";
                valinta = "*";
        }

        private void jako_Click(object sender, EventArgs e)
        {
                textBox3.Text += " / ";
                valinta = "/";
        }

        private void miinus_Click(object sender, EventArgs e)
        {
                textBox3.Text += " - ";
                valinta = "-";
        }

        private void plus_Click(object sender, EventArgs e)
        {
                textBox3.Text += " + "; 
                valinta = "+";
        }

        private void yhtakuin_Click(object sender, EventArgs e)
        {
            string[] splitted = textBox3.Text.Split(' ');
            if (splitted.Length >= 2 && splitted[2] != "")
            {
                int luku1 = int.Parse(splitted[0]);
                int luku2 = int.Parse(splitted[2]);

                double answer = 0;
                bool error = false;
                switch (valinta)
                {
                    case "+":
                        answer = luku1 + luku2;
                        break;
                    case "-":
                        answer = luku1 - luku2;
                        break;
                    case "*":
                        answer = luku1 * luku2;
                        break;
                    case "/":
                        if (luku2 != 0)
                        { 
                            answer = luku1 / luku2;
                        }
                        else
                        {
                            error = true;
                        }
                        break;
                    default:
                        error = true;
                        break;
                }
                if(error)
                {
                    textBox4.Text = "ERROR";
                }
                else
                {
                    textBox4.Text = answer.ToString();
                }

                textBox3.Text += " = ";
            }
        }

        private void Cnappain_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox4.Clear();
            tulos = (0);
            luku1 = (0);
            luku2 = (0);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
