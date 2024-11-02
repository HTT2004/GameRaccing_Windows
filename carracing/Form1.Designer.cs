namespace carracing
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            mycar = new PictureBox();
            enemy1 = new PictureBox();
            enemy2 = new PictureBox();
            enemy3 = new PictureBox();
            enemy4 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mycar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Location = new Point(225, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(10, 137);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ButtonHighlight;
            pictureBox2.Location = new Point(225, 168);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(10, 137);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ButtonHighlight;
            pictureBox3.Location = new Point(225, 331);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(10, 137);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.ButtonHighlight;
            pictureBox4.Location = new Point(-2, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(10, 453);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = SystemColors.ButtonHighlight;
            pictureBox5.Location = new Point(425, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(10, 453);
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // mycar
            // 
            mycar.Image = (Image)resources.GetObject("mycar.Image");
            mycar.Location = new Point(38, 393);
            mycar.Name = "mycar";
            mycar.Size = new Size(30, 48);
            mycar.SizeMode = PictureBoxSizeMode.Zoom;
            mycar.TabIndex = 5;
            mycar.TabStop = false;
            // 
            // enemy1
            // 
            enemy1.Image = (Image)resources.GetObject("enemy1.Image");
            enemy1.Location = new Point(47, 23);
            enemy1.Name = "enemy1";
            enemy1.Size = new Size(21, 62);
            enemy1.SizeMode = PictureBoxSizeMode.Zoom;
            enemy1.TabIndex = 6;
            enemy1.TabStop = false;
            // 
            // enemy2
            // 
            enemy2.Image = (Image)resources.GetObject("enemy2.Image");
            enemy2.Location = new Point(152, 75);
            enemy2.Name = "enemy2";
            enemy2.Size = new Size(21, 62);
            enemy2.SizeMode = PictureBoxSizeMode.Zoom;
            enemy2.TabIndex = 7;
            enemy2.TabStop = false;
            // 
            // enemy3
            // 
            enemy3.Image = (Image)resources.GetObject("enemy3.Image");
            enemy3.Location = new Point(291, 44);
            enemy3.Name = "enemy3";
            enemy3.Size = new Size(21, 62);
            enemy3.SizeMode = PictureBoxSizeMode.Zoom;
            enemy3.TabIndex = 8;
            enemy3.TabStop = false;
            // 
            // enemy4
            // 
            enemy4.Image = (Image)resources.GetObject("enemy4.Image");
            enemy4.Location = new Point(378, 114);
            enemy4.Name = "enemy4";
            enemy4.Size = new Size(21, 62);
            enemy4.SizeMode = PictureBoxSizeMode.Zoom;
            enemy4.TabIndex = 9;
            enemy4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(271, 5);
            label1.Name = "label1";
            label1.Size = new Size(94, 18);
            label1.TabIndex = 10;
            label1.Text = "Your score:";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(362, 1);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(61, 25);
            textBox1.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(432, 453);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(enemy4);
            Controls.Add(enemy3);
            Controls.Add(enemy2);
            Controls.Add(enemy1);
            Controls.Add(mycar);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "                                ";
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)mycar).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy3).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private System.Windows.Forms.Timer timer1;
        private PictureBox mycar;
        private PictureBox enemy1;
        private PictureBox enemy2;
        private PictureBox enemy3;
        private PictureBox enemy4;
        private Label label1;
        private TextBox textBox1;
    }
}
