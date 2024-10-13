namespace Fly_Ball
{
    partial class Form_TopSektirme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_TopSektirme));
            button1 = new Button();
            button2 = new Button();
            pictureGirl = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureGirl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 152);
            button1.Name = "button1";
            button1.Size = new Size(254, 72);
            button1.TabIndex = 0;
            button1.Text = "Başla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 268);
            button2.Name = "button2";
            button2.Size = new Size(254, 72);
            button2.TabIndex = 1;
            button2.Text = "Dur";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureGirl
            // 
            pictureGirl.BackColor = Color.Transparent;
            pictureGirl.Image = (Image)resources.GetObject("pictureGirl.Image");
            pictureGirl.Location = new Point(414, 45);
            pictureGirl.Margin = new Padding(4, 5, 4, 5);
            pictureGirl.Name = "pictureGirl";
            pictureGirl.Size = new Size(378, 431);
            pictureGirl.TabIndex = 2;
            pictureGirl.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(903, 102);
            label1.Name = "label1";
            label1.Size = new Size(342, 22);
            label1.TabIndex = 4;
            label1.Text = "Kaç defa topun sekeceğini tahmin et";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(861, 155);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 5;
            label2.Text = "Tahmin:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(926, 156);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(861, 200);
            label3.Name = "label3";
            label3.Size = new Size(133, 20);
            label3.TabIndex = 7;
            label3.Text = "Sektirilen top sayısı:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1000, 201);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 8;
            textBox2.Visible = false;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(0, 192, 0);
            textBox3.Location = new Point(358, 469);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(482, 23);
            textBox3.TabIndex = 9;
            // 
            // timer1
            // 
            timer1.Interval = 30;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(597, 193);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(12, 382);
            button3.Name = "button3";
            button3.Size = new Size(254, 72);
            button3.TabIndex = 12;
            button3.Text = "Çıkış";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form_TopSektirme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1310, 611);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureGirl);
            Name = "Form_TopSektirme";
            Text = "Form_TopSektirme";
            ((System.ComponentModel.ISupportInitialize)pictureGirl).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private PictureBox pictureGirl;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private Button button3;
    }
}