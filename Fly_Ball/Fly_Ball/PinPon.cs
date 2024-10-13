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
    public partial class PinPon : Form
    {
        public PinPon()
        {
            InitializeComponent();
        }

        private void PinPon_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true; //Form açıldığında timer'ı başlatır.
            timer3.Enabled = true;
            timer5.Enabled = true;
        }

        Random _random = new Random(); //_random değişkenine rastgele sayı ataması yapıldı

        private void PinPon_KeyDown(object sender, KeyEventArgs e)
        {
            // Sol çubuğun kordinatları
            int x_leftstick = leftStick.Location.X;
            int y_leftstick = leftStick.Location.Y;

            // Sol çubuğu y ekseninde klavye ile kontrol etme
            if (e.KeyCode == Keys.W)
            {
                y_leftstick = y_leftstick - 20;
                leftStick.Location = new Point(x_leftstick, y_leftstick); //:ubuk konumu güncellendi
            }

            if (e.KeyCode == Keys.S)
            {
                y_leftstick = y_leftstick + 20;
                leftStick.Location = new Point(x_leftstick, y_leftstick);
            }

            // Sağ çubuğun kordinatları
            int x_rightstick = rightStick.Location.X;
            int y_rightstick = rightStick.Location.Y;

            // Sağ çubuğu y ekseninde klavye ile kontrol etme
            if ((e.KeyCode == Keys.P))
            {
                y_rightstick = y_rightstick - 20;
                rightStick.Location = new Point(x_rightstick, y_rightstick);
            }

            if ((e.KeyCode == Keys.L))
            {
                y_rightstick += 20;
                rightStick.Location = new Point(x_rightstick, y_rightstick);
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int ball = _random.Next(20, 25);
            pictureBox1.Left = pictureBox1.Left - ball; // top sol tarafa rastgele bir şekilde hareket edicek

            if (leftStick.Bottom >= pictureBox1.Top && leftStick.Top <= pictureBox1.Bottom && leftStick.Right >= pictureBox1.Left && leftStick.Left <= pictureBox1.Right)
            {
                timer1.Enabled = false;
                timer2.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int ball = _random.Next(20, 25);
            pictureBox1.Left = pictureBox1.Left + ball; // top sol tarafa rastgele bir şekilde hareket edicek

            if (rightStick.Top <= pictureBox1.Bottom && rightStick.Bottom >= pictureBox1.Top && rightStick.Left <= pictureBox1.Right && rightStick.Right >= pictureBox1.Left)
            {
                timer2.Enabled = false;
                timer1.Enabled = true;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int ball = _random.Next(20, 25);
            pictureBox1.Top = pictureBox1.Top - ball;

            if (pictureBox1.Bottom > topWall.Top)
            {
                timer3.Enabled = false;
                timer4.Enabled = true;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            int ball = _random.Next(20, 25);
            pictureBox1.Top = pictureBox1.Top + ball;

            if (pictureBox1.Top < underWall.Bottom)
            {
                timer4.Enabled = false;
                timer3.Enabled = true;
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            PinPon form = new PinPon();
            Form2 form2 = new Form2();

            #region Top Sol Duvara Çarptığında
            //Top sol duvara çarptığında yok olsun ve timer5 kapansın
            if (pictureBox1.Left <= leftWall.Right)
            {
                timer5.Enabled = false;
                pictureBox1.Visible = false;
                MessageBox.Show("İkinci Oyuncu Kazandı");

                //Yeniden oynamak için oyun sonunda mesaj kutusu sunma
                DialogResult newGame = MessageBox.Show("Yeni Oyun", "Yenile", MessageBoxButtons.YesNo);
                if (newGame == DialogResult.Yes)
                {
                    form.Show();
                    this.Hide();
                }
                else
                {
                    form2.Show();
                    this.Hide();
                }
            }
            #endregion
            #region Top Sağ Duvara Çarptığında
            if (pictureBox1.Right >= rightWall.Left)
            {
                timer5.Enabled = false;
                pictureBox1.Visible = false;
                MessageBox.Show("Birinci Oyunuc Kazandı");


                //Yeniden oynamak için oyun sonunda mesaj kutusu sunma
                DialogResult newGame = MessageBox.Show("Yeni Oyun", "Yenile", MessageBoxButtons.YesNo);
                if (newGame == DialogResult.Yes)
                {
                    form.Show();
                    this.Hide();
                }
                else
                {
                    form2.Show();
                    this.Hide();
                }
            }
            #endregion
        }
    }
}
