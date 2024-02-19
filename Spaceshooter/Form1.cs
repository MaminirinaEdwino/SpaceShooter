using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Spaceshooter
{
    public partial class Form1 : Form
    {
        PictureBox[] stars;
        PictureBox[] munitions;
        PictureBox[] enemies;
        PictureBox[] enemiesmunition;
        int backgroundspeed;
        int playerspeed;
        int munitionspeed;
        int enemiespeed;
        int enemiesmunitionspeed;
        int score;
        int level;
        int difficulty;
        bool pause;
        bool gameisover;
        Random rnd;
        SoundPlayer musique_de_fond;
        SoundPlayer son_de_tirs;
        SoundPlayer explosion;

        
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundspeed = 4;
            playerspeed = 4;
            enemiespeed = 4;
            enemiesmunitionspeed = 4;
                       
            pause = false;
            gameisover = false;
            score = 0;
            level = 1;
            difficulty = 9;
            stars = new PictureBox[10];
            rnd = new Random();

            munitionspeed = 20;
            munitions = new PictureBox[3];

            
            

            musique_de_fond = new SoundPlayer(@"songs\GameSong.wav");
            son_de_tirs = new SoundPlayer(@"songs\shoot.wav");
            explosion = new SoundPlayer(@"songs\boom.wav");
            //musique_de_fond.Play();
            musique_de_fond.PlayLooping();
                //chargement image 
            Image munition = Image.FromFile(@"asserts\munition.png");
            Image enemi1 = Image.FromFile(@"asserts\E1.png");
            Image enemi2 = Image.FromFile(@"asserts\E2.png");
            Image enemi3 = Image.FromFile(@"asserts\E3.png");
            Image boss1 = Image.FromFile(@"asserts\Boss1.png");
            Image boss2 = Image.FromFile(@"asserts\Boss2.png");

            enemies = new PictureBox[10];

            for (int i = 0; i < enemies.Length; i++) {
                enemies[i] = new PictureBox();
                enemies[i].Size = new Size(40, 40);
                enemies[i].SizeMode = PictureBoxSizeMode.Zoom;
                enemies[i].BorderStyle = BorderStyle.None;
                enemies[i].Visible = false;
                this.Controls.Add(enemies[i]);
                enemies[i].Location = new Point((i + 1) * 50, -50);
            }

            enemies[0].Image = boss1;
            enemies[1].Image = enemi1;
            enemies[2].Image = enemi2;
            enemies[3].Image = enemi3;
            enemies[4].Image = enemi1;
            enemies[5].Image = enemi2;
            enemies[6].Image = enemi3;
            enemies[7].Image = enemi2;
            enemies[8].Image = enemi1;
            enemies[9].Image = boss2;

            enemiesmunition = new PictureBox[10];
            for (int i = 0; i < enemiesmunition.Length; i++)
            {
                enemiesmunition[i] = new PictureBox();
                enemiesmunition[i].Size = new Size(2, 25);
                enemiesmunition[i].Visible = false;
                enemiesmunition[i].BackColor = Color.Yellow;
                int x = rnd.Next(0, 10);
                enemiesmunition[i].Location = new Point(enemies[x].Location.X, enemies[x].Location.Y - 20);
                this.Controls.Add(enemiesmunition[i]);
            }

                for (int i = 0; i < munitions.Length; i++)
                {
                    munitions[i] = new PictureBox();
                    munitions[i].Size = new Size(8, 8);
                    munitions[i].Image = munition;
                    munitions[i].SizeMode = PictureBoxSizeMode.Zoom;
                    munitions[i].BorderStyle = BorderStyle.None;
                    this.Controls.Add(munitions[i]);
                }
            for (int i = 0; i < stars.Length; i++)
            {
                stars[i] = new PictureBox();
                stars[i].BorderStyle = BorderStyle.None;
                stars[i].Location = new Point(rnd.Next(20, 500), rnd.Next(-10, 400));
                if (i % 2 == 1)
                {
                    stars[i].Size = new Size(2, 2);
                    stars[i].BackColor = Color.Wheat;
                }
                else
                {
                    stars[i].Size = new Size(3, 3);
                    stars[i].BackColor = Color.DarkGray;
                }

                this.Controls.Add(stars[i]);
            }
                

        }

        private void movebytimer_tick(object sender, EventArgs e)
        {
            for(int i = 0; i < stars.Length/2;i++){
                stars[i].Top += backgroundspeed;
                if (stars[i].Top >= this.Height) {
                    stars[i].Top = -stars[i].Height;
                }
            }
            for (int i = stars.Length / 2; i < stars.Length ; i++)
            {
                stars[i].Top += backgroundspeed - 2;
                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }
        }

        private void downmovetimer_Tick(object sender, EventArgs e)
        {
            if (player.Top < 400) {
                player.Top += playerspeed;
            }

        }

        private void upmovetimer_Tick(object sender, EventArgs e)
        {
            if (player.Top > 10)
            {
                player.Top -= playerspeed;
            }
        }

        private void rightmovetimer_Tick(object sender, EventArgs e)
        {
            if (player.Right < 550)
            {
                player.Left += playerspeed;
            }
        }

        private void leftmovetimer_Tick(object sender, EventArgs e)
        {
            if (player.Left > 10)
            {
                player.Left -= playerspeed;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!pause)
            {
                if (e.KeyCode == Keys.Right)
                {
                    rightmovetimer.Start();
                }
                if (e.KeyCode == Keys.Left)
                {
                    leftmovetimer.Start();
                }
                if (e.KeyCode == Keys.Down)
                {
                    downmovetimer.Start();
                }
                if (e.KeyCode == Keys.Up)
                {
                    upmovetimer.Start();
                }
            }
            
           
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            rightmovetimer.Stop();
            leftmovetimer.Stop();
            downmovetimer.Stop();
            upmovetimer.Stop();
            if (e.KeyCode == Keys.Space)
            {
                if (!gameisover)
                {
                    if (pause)
                    {
                        starttimer();
                        label1.Visible = false;
                        musique_de_fond.PlayLooping();
                        pause = false;
                    }
                    else
                    {
                        label1.Location = new Point(this.Width / 2 - 120, 150);
                        label1.Text = "PAUSED";
                        label1.Visible = true;
                        musique_de_fond.Stop();
                        stoptimer();
                        pause = true;
                    }

                }
            }

        }

        private void movemunitiontimer_Tick(object sender, EventArgs e)
        {
           
            for (int i = 0; i < munitions.Length; i++) 
            {
                if (munitions[i].Top > 0)
                {
                    munitions[i].Visible = true;
                    munitions[i].Top -= munitionspeed;
                    collision();
                }
                else 
                {
                    munitions[i].Visible = false;
                    munitions[i].Location = new Point(player.Location.X + 20, player.Location.Y - i * 30);
                }
            }
            
        }

        private void moveenemiestimer_Tick(object sender, EventArgs e)
        {
            moveenemies(enemies, enemiespeed);
        }
        private void moveenemies(PictureBox[] array, int speed)
        {
            for (int i = 0; i < array.Length; i++) {
                array[i].Visible = true;
                array[i].Top += speed;

                if (array[i].Top > this.Height)
                {
                    array[i].Location = new Point((i + 1) * 50, -200);
                }

            } 
        }
        private void collision()
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                if(munitions[0].Bounds.IntersectsWith(enemies[i].Bounds) || munitions[1].Bounds.IntersectsWith(enemies[i].Bounds) || munitions[2].Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    score += 1;
                    scorelabel.Text = (score < 10) ? "SCORE : 0" + score.ToString() : "SCORE : " + score.ToString();
                    if(score % 30 == 0){
                        level += 1;
                        levellabel.Text = (level < 10) ? "LEVEL : 0" + level.ToString() : "LEVEL : 0" +level.ToString();
                        enemiesmunitionspeed++;
                        enemiespeed++;
                        difficulty--;
                        if (level == 10)
                        {
                            Gameover("FIN");
                        }
                    }
                    enemies[i].Location = new Point((i + 1) * 50, -100);
                    
                }
                if (player.Bounds.IntersectsWith(enemies[i].Bounds)){                    
                    player.Visible = false;
                    Gameover("Game Over");
                    explosion.Play();
                }
            }

        }
        private void Gameover(string str)
        {
            label1.Text = str;
            label1.Location = new Point(120, 120);
            label1.Visible = true;
            btn_replay.Visible = true;
            btn_exit.Visible = true;
            musique_de_fond.Stop();
            stoptimer();
        }
        private void stoptimer()
        {
            moveenemiestimer.Stop();
            movemunitiontimer.Stop();
            Movebytimer.Stop();
            enemiesmunitiontimer.Stop();
        }
        private void starttimer()
        {
            moveenemiestimer.Start();
            movemunitiontimer.Start();
            Movebytimer.Start();
            enemiesmunitiontimer.Start();
        }

        private void enemiesmunitiontimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < enemiesmunition.Length -difficulty; i++)
            {
                if (enemiesmunition[i].Top < this.Height)
                {
                    enemiesmunition[i].Visible = true;
                    enemiesmunition[i].Top += enemiesmunitionspeed;

                    collisionavecmunitionenemie();
                }
                else
                {
                    enemiesmunition[i].Visible = false;
                    int x = rnd.Next(0, 10);
                    enemiesmunition[i].Location = new Point(enemies[x].Location.X+20, enemies[x].Location.Y + 30);
                }
            }
        }
        private void collisionavecmunitionenemie()
        {
            for (int i = 0; i < enemiesmunition.Length; i++)
            {
                if (enemiesmunition[i].Bounds.IntersectsWith(player.Bounds))
                {
                    enemiesmunition[i].Visible = false;
                    player.Visible = false;
                    Gameover("Game Over");
                    explosion.Play();
                }
            }
           
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void btn_replay_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            Form1_Load(e, e);
        }

    }
}
 