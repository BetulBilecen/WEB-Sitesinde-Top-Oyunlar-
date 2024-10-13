namespace Fly_Ball
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            ball = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            button3 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Green;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(16, 356);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.BackColor = Color.Green;
            label2.Location = new Point(707, 9);
            label2.Name = "label2";
            label2.Size = new Size(16, 356);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.BackColor = Color.PaleGreen;
            label3.Location = new Point(12, 8);
            label3.Name = "label3";
            label3.Size = new Size(712, 19);
            label3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(813, 70);
            label4.MaximumSize = new Size(50, 50);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 3;
            label4.Text = "3";
            // 
            // button1
            // 
            button1.BackColor = Color.Sienna;
            button1.Location = new Point(172, 309);
            button1.Name = "button1";
            button1.Size = new Size(89, 25);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = false;
            // 
            // ball
            // 
            ball.BackColor = SystemColors.InactiveCaptionText;
            ball.Location = new Point(203, 70);
            ball.Name = "ball";
            ball.Size = new Size(18, 18);
            ball.TabIndex = 5;
            ball.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            timer1.Interval = 200;
            timer1.Tick += timer1_Tick;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 255, 192);
            button3.Location = new Point(766, 311);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = "Çıkış";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(777, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 529);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(ball);
            Controls.Add(button1);
            Controls.Add(label4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Catching The Ball";
            Load += Form1_Load;
            MouseMove += Form1_MouseMove;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button ball;
        private System.Windows.Forms.Timer timer1;
        private Button button3;
        private PictureBox pictureBox1;
    }
}