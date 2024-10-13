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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            Form1 _form_TopSektirme = new Form1();
            Form2 form_Menü = new Form2();

            _form_TopSektirme.Show();
            form_Menü.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_TopSektirme form_TopSektirme = new Form_TopSektirme();
            Form2 form_Menü = new Form2();

            form_TopSektirme.Show();
            form_Menü.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form_Menü = new Form2();
            PinPon form_pinpon = new PinPon();

            form_pinpon.Show();
            form_Menü.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
