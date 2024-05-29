using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using System.IO;
namespace DuckGame
{
    public partial class Form1 : Form
    {
        private Point positionMouse;
        private bool dragging, lose = false;
        private int countPatrones = 0;
        public int speedBullet = 10;
        private bool attack = false;
        private int countdown = 60; 
        
        private Timer countdownTimer;
        

        public Form1()
        {
            InitializeComponent();
            InitializeGameSettings();
        }

        private void InitializeGameSettings()
        {
            bg1.MouseDown += MouseClickDown;
            bg1.MouseUp += MouseClickUp;
            bg1.MouseMove += MouseClickMove;
            bg2.MouseDown += MouseClickDown;
            bg2.MouseUp += MouseClickUp;
            bg2.MouseMove += MouseClickMove;
            labelLose.Visible = false;
            btnRestart.Visible = false;
            KeyPreview = true;
            bullet.Visible = false;
            bullet.Enabled = false;
            devide.Visible = false;
            fall.Visible = false;
            MXP2.Visible = false;
            MXP.Visible = false;
            fon.Visible = false;
            message.Visible = false;
            MXP2.URL = @"Resources\teacherprew.wav";
            MXP.URL = @"Resources\OST.wav";
            MXP.Ctlcontrols.stop();
            MXP2.Ctlcontrols.stop();
            labelStart.Visible = true;
            timer1.Enabled = false;
            win.Visible = false;
            countdownTimer = new Timer { Interval = 1000 };
            countdownTimer.Tick += countdownTimer_Tick;
            countdownTimer.Stop();
            
        }


        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            countdown--;
            if (countdown == 45)
            {
                fall.Visible = true;
            }
            if (countdown == 43)
            {
                fall.Visible = false;
                message.Visible = false;
                
            }
            if (countdown == 0)
            {
                timer1.Enabled = false;
                win.Visible = true;
                countdownTimer.Stop();
                PlaySound(@"Resources\testik.wav");
            }
        }

        private void MouseClickDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            positionMouse = e.Location;
        }

        private void MouseClickUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void MouseClickMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currentPoint = PointToScreen(e.Location);
                this.Location = new Point(currentPoint.X - positionMouse.X + bg1.Left, currentPoint.Y - positionMouse.Y);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveObjects();
            CheckCollisions();
        }

        private void MoveObjects()
        {
            int speed = 10;
            bg1.Left += speed;
            bg2.Left += speed;
            int speedEnemy = 7;
            enemy1.Left += speedEnemy;
            enemy2.Left += speedEnemy;
            patrones.Left += speed;
            message.Top += 4;
            if (message.Top >= 0) message.Top = 0;
            if (attack)
            {
                bullet.Left -= speedBullet;
                bullet.Visible = true;
                bullet.Enabled = true;
                labelPatrones.Text = "Taken patrones: " + countPatrones;
            }

            if (enemy1.Left >= 1280) ResetEnemyPosition(enemy1, 0, 290);
            if (patrones.Left > 1280) ResetPatronesPosition();
            if (enemy2.Left >= 1280) ResetEnemyPosition(enemy2, 291, 520);
            if (bg1.Left >= 1280) ResetBackgroundPosition();
        }

        private void ResetEnemyPosition(PictureBox enemy, int minY, int maxY)
        {
            enemy.Left = -120;
            Random randomSpawn = new Random();
            enemy.Top = randomSpawn.Next(minY, maxY);
            devide.Visible = false;
        }

        private void ResetPatronesPosition()
        {
            patrones.Left = -220;
            Random randomSpawn = new Random();
            patrones.Top = randomSpawn.Next(0, 520);
            devide.Visible = false;
        }

        private void ResetBackgroundPosition()
        {
            bg1.Left = 0;
            bg2.Left = -1280;
        }

        private void CheckCollisions()
        {
            if (player.Bounds.IntersectsWith(enemy1.Bounds) || player.Bounds.IntersectsWith(enemy2.Bounds) || player.Top >= 590)
            {
                GameOver();
            }
            if (enemy1.Bounds.IntersectsWith(bullet.Bounds)) HandleBulletHit(enemy1);
            if (enemy2.Bounds.IntersectsWith(bullet.Bounds)) HandleBulletHit(enemy2);
            if (player.Bounds.IntersectsWith(patrones.Bounds)) CollectPatrones();
        }

        private void GameOver()
        {
            timer1.Enabled = false;
            labelLose.Visible = true;
            btnRestart.Visible = true;
            lose = true;
            fon.Location = player.Location;
            fon.Visible = true;
        }

        private void HandleBulletHit(PictureBox enemy)
        {
            bullet.Visible = false;
            bullet.Enabled = false;
            devide.Location = new Point(enemy.Left + 10, enemy.Top);
            devide.Visible = true;
            enemy.Left = -240;
            attack = false;
            bullet.Location = Point.Empty;
            PlaySound(@"Resources\bah.wav");
        }

        private void CollectPatrones()
        {
            countPatrones++;
            labelPatrones.Text = "Taken patrones: " + countPatrones;
            ResetPatronesPosition();
        }

        private void PlaySound(string path)
        {
            using (SoundPlayer playerMedia = new SoundPlayer(path))
            {
                playerMedia.Play();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (lose) return;

            int speedPlane = 10;
            switch (e.KeyCode)
            {
                case Keys.Up:
                case Keys.W:
                    if (player.Top >= 0) player.Top -= speedPlane;
                    break;
                case Keys.Down:
                case Keys.S:
                    player.Top += speedPlane;
                    break;
                case Keys.Left:
                case Keys.A:
                    player.Left -= speedPlane;
                    break;
                case Keys.Right:
                case Keys.D:
                    player.Left += speedPlane;
                    break;
                case Keys.Space:
                    if (countPatrones > 0)
                    {
                        bullet.Location = player.Location;
                        attack = true;
                        countPatrones--;
                        PlaySound(@"Resources\poletpuli.wav");
                    }
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        private void labelStart_Click(object sender, EventArgs e)
        {
            StartGame();

        }

        private void StartGame()
        {
            player.Top = 250;
            enemy1.Left = -120;
            enemy2.Left = -330;
            labelStart.Visible = false;
            countdownTimer.Start();
            timer1.Enabled = true;
            MXP.Ctlcontrols.play();
            MXP2.Ctlcontrols.play();
            
            message.Visible = true;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }



        private void RestartGame()
        {
            player.Top = 250;
            enemy1.Left = -120;
            enemy2.Left = -330;
            labelLose.Visible = false;
            btnRestart.Visible = false;
            timer1.Enabled = true;
            lose = false;
            countPatrones = 0;
            labelPatrones.Text = "Taken patrones: 0";
            ResetPatronesPosition();
            bullet.Visible = false;
            bullet.Enabled = false;
            Application.Restart();
            Environment.Exit(0);
            PlaySound(@"Resources\testik.wav");
        }
    }
}