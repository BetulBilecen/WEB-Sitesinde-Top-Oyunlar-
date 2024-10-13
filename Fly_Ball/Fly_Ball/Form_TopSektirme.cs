using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fly_Ball
{
    public partial class Form_TopSektirme : Form
    {
        public Form_TopSektirme()
        {
            InitializeComponent();
        }
        int topy = 1, sayi = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sayi > 20)
            {
                timer1.Stop();
                textBox2.Text = sayi.ToString();

            }
            else
            {
                pictureBox1.Top += topy;
                if (pictureBox1.Top >= 198)
                {
                    topy *= -1;
                }

                else if (pictureBox1.Top <= 100)
                {
                    topy *= -1;
                }


                if (pictureBox1.Top == 198)
                {
                    sayi++;
                    textBox2.Text = sayi.ToString();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            textBox2.Text = sayi.ToString() + " kere top sektirildi.";

            if (textBox1.Text == "")
            {
                MessageBox.Show("Lütfen Tahmin Yapınız.");
            }
            else
            {
                int guess = Convert.ToInt16(textBox1.Text);
                textBox2.Visible = true;

                if (guess == sayi)
                    MessageBox.Show("Tebrikler Kazandınız!");
                else
                    MessageBox.Show("Maalesef Kaybettiniz.");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
        }
    }
}
