namespace Fly_Ball
{
    partial class PinPon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PinPon));
            leftWall = new Label();
            rightWall = new Label();
            topWall = new Label();
            underWall = new Label();
            leftStick = new Label();
            rightStick = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            timer4 = new System.Windows.Forms.Timer(components);
            timer5 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // leftWall
            // 
            leftWall.BackColor = Color.OrangeRed;
            leftWall.ForeColor = Color.White;
            leftWall.Location = new Point(0, 0);
            leftWall.Name = "leftWall";
            leftWall.Size = new Size(10, 452);
            leftWall.TabIndex = 1;
            // 
            // rightWall
            // 
            rightWall.BackColor = Color.OrangeRed;
            rightWall.ForeColor = Color.White;
            rightWall.Location = new Point(791, 0);
            rightWall.Name = "rightWall";
            rightWall.Size = new Size(10, 452);
            rightWall.TabIndex = 2;
            // 
            // topWall
            // 
            topWall.BackColor = Color.White;
            topWall.Location = new Point(11, 0);
            topWall.Name = "topWall";
            topWall.Size = new Size(782, 10);
            topWall.TabIndex = 3;
            // 
            // underWall
            // 
            underWall.BackColor = Color.White;
            underWall.Location = new Point(10, 439);
            underWall.Name = "underWall";
            underWall.Size = new Size(782, 10);
            underWall.TabIndex = 4;
            // 
            // leftStick
            // 
            leftStick.BackColor = Color.FromArgb(0, 192, 0);
            leftStick.Location = new Point(43, 117);
            leftStick.Name = "leftStick";
            leftStick.Size = new Size(12, 157);
            leftStick.TabIndex = 5;
            // 
            // rightStick
            // 
            rightStick.BackColor = Color.FromArgb(0, 192, 0);
            rightStick.Location = new Point(734, 117);
            rightStick.Name = "rightStick";
            rightStick.Size = new Size(12, 157);
            rightStick.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(307, 117);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 200;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 200;
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Interval = 200;
            timer3.Tick += timer3_Tick;
            // 
            // timer4
            // 
            timer4.Interval = 200;
            timer4.Tick += timer4_Tick;
            // 
            // timer5
            // 
            timer5.Tick += timer5_Tick;
            // 
            // PinPon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(214, 243, 254);
            ClientSize = new Size(800, 450);
            Controls.Add(rightWall);
            Controls.Add(pictureBox1);
            Controls.Add(rightStick);
            Controls.Add(leftStick);
            Controls.Add(underWall);
            Controls.Add(topWall);
            Controls.Add(leftWall);
            Name = "PinPon";
            Text = "PinPon";
            Load += PinPon_Load;
            KeyDown += PinPon_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label leftWall;
        private Label rightWall;
        private Label topWall;
        private Label underWall;
        private Label leftStick;
        private Label rightStick;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
    }
}