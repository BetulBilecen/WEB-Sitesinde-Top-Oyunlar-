namespace Fly_Ball
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int floorX = 5, floorY = 5, heart = 3;

        private void StrikeEvent()
        {
            //tavan çarpma
            if (ball.Top <= label3.Bottom)
            {
                floorY *= -1;
            }

            //buttona çarpma olayý
            if (ball.Bottom >= button1.Top && ball.Left >= button1.Left && ball.Right <= button1.Right)
            {
                floorY *= -1;
            }

            //sað kenara çarpma
            else if (ball.Right >= label2.Left)
            {
                floorX *= -1;
            }

            //sol kenara çarpma
            else if (ball.Left <= label1.Right)
            {
                floorX *= -1;
            }
        }

        private void FailHeart(object sender, EventArgs e)
        {
            if (ball.Top >= label2.Bottom)
            {
                if (heart > 0)
                {
                    timer1.Stop();
                    heart--;
                    label4.Text = heart.ToString();
                    Form1_Load(sender, e);
                }

                else
                {
                    timer1.Stop();
                    label4.Text = "0";

                }
                if (heart == 0)
                {
                    timer1.Stop();
                    MessageBox.Show("Kaybettiniz :(", "", MessageBoxButtons.OKCancel);
                }
            }
        }

        private void ReturnTheBallToStartingPosition()
        {
            ball.Location = new Point(203, 70);
        }


        private void Form1_MouseMove(object sender, MouseEventArgs e)  //Formda fare kontrolü
        {
            StrikeEvent();
            FailHeart(sender, e);
            button1.Left = e.X;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReturnTheBallToStartingPosition();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ball.Location = new Point(ball.Location.X + floorX, ball.Location.Y + floorY);
            if (timer1.Interval != 17)
                timer1.Interval -= 1;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}