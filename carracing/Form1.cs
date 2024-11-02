using WMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace carracing
{
    public partial class Form1 : Form
    {
        private readonly WindowsMediaPlayer backgroundMusic = new WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();
            PlayBackgroundMusic();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            linemove(carspeed);
            gameover();
            totalscore();
        }

        Random pos = new Random();
        int carspeed = 3;
        int score = 0;
        int targetScore = 20; // Số điểm cần đạt để qua màn

        void linemove(int speed)
        {
            if (pictureBox1.Top > 500) pictureBox1.Top = 0;
            else pictureBox1.Top += speed;

            if (pictureBox2.Top > 500) pictureBox2.Top = 0;
            else pictureBox2.Top += speed;

            if (pictureBox3.Top > 500) pictureBox3.Top = 0;
            else pictureBox3.Top += speed;

            if (enemy1.Top > 500)
            {
                score++;
                enemy1.Left = pos.Next(0, 200);
                enemy1.Top = 0;
            }
            else enemy1.Top += speed;

            if (enemy2.Top > 500)
            {
                score++;
                enemy2.Left = pos.Next(0, 200);
                enemy2.Top = 0;
            }
            else enemy2.Top += speed;

            if (enemy3.Top > 500)
            {
                score++;
                enemy3.Left = pos.Next(225, 300);
                enemy3.Top = 0;
            }
            else enemy3.Top += speed;

            if (enemy4.Top > 500)
            {
                score++;
                enemy4.Left = pos.Next(225, 300);
                enemy4.Top = 0;
            }
            else enemy4.Top += speed;
        }
        private void PlayBackgroundMusic()
        {
            try
            {
                backgroundMusic.URL = "D:\\carracing\\carracing\\music\\duaxe.mp3";
                backgroundMusic.settings.volume = 100;
                backgroundMusic.settings.setMode("loop", true);
                backgroundMusic.controls.play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi phát nhạc: " + ex.Message);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            backgroundMusic.controls.stop();
            base.OnFormClosing(e);
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && mycar.Left > 0) mycar.Left -= 3;
            if (e.KeyCode == Keys.Right && mycar.Left < 400) mycar.Left += 3;
            if (e.KeyCode == Keys.Up && carspeed < 30) carspeed++;
            if (e.KeyCode == Keys.Down && carspeed > 3) carspeed--;
        }

        void totalscore()
        {
            textBox1.Text = score.ToString();
            if (score >= targetScore)
            {
                // Qua màn khi đạt đủ điểm
                timer1.Enabled = false;
                MessageBox.Show(" next level 2!", "Level Up", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Level2 level2 = new Level2();
                level2.Show(); // Hiện màn chơi mới
                this.Hide();   // Ẩn màn chơi hiện tại
            }
        }

        void gameover()
        {
            if (mycar.Bounds.IntersectsWith(enemy1.Bounds) ||
                mycar.Bounds.IntersectsWith(enemy2.Bounds) ||
                mycar.Bounds.IntersectsWith(enemy3.Bounds) ||
                mycar.Bounds.IntersectsWith(enemy4.Bounds))
            {
                timer1.Enabled = false;
                DialogResult go = MessageBox.Show("Do you want play agian?", "GAME OVER", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                switch (go)
                {
                    case DialogResult.Yes:
                        timer1.Enabled = true;
                        enemy1.Left = pos.Next(0, 200);
                        enemy1.Top = 0;
                        enemy2.Left = pos.Next(0, 200);
                        enemy2.Top = 0;
                        enemy3.Left = pos.Next(225, 300);
                        enemy3.Top = 0;
                        enemy4.Left = pos.Next(225, 300);
                        enemy4.Top = 0;
                        score = 0;
                        break;
                    case DialogResult.No:
                        this.Close();
                        break;
                }
            }
        }
    }
}
