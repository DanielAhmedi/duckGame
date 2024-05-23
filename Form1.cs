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
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
namespace DuckGame
{
    public partial class Form1 : Form
    {   
        private Point positionMouse;
        private bool dragging, lose =false;
        private int countPatrones=0;
        public int speedBullet = 10;
        private bool attack = false;
        private int countdown = 10; // начальное значение обратного отсчета 
        private System.Windows.Forms.Timer countdownTimer;

        public Form1()
        {
            InitializeComponent();
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
            MXP2.URL = (@"C:\Users\Данил\source\repos\DuckGame\Resources\teacherprew.wav");
            MXP2.Ctlcontrols.play();
            MXP.Visible = false;
            MXP.URL = @"C:\Users\Данил\source\repos\DuckGame\Resources\OST.wav";
            MXP.Ctlcontrols.play();
            fon.Visible = false;
            message.Visible = true;
            countdownTimer = new System.Windows.Forms.Timer();
            countdownTimer.Tick += new EventHandler(countdownTimer_Tick);
            countdownTimer.Interval = 1800; // интервал таймера в миллисекундах (в данном случае 1 секунда) 
            countdownTimer.Start();
        }

        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            countdown--; // уменьшаем значение обратного отсчета на 1 каждую секунду 

            if (countdown == 2)
            {
                fall.Visible = true;
                                
            }
            if (countdown == 0)
            {
                fall.Visible = false;
                message.Visible = false;
                countdownTimer.Stop();
            }
        }


        private void MouseClickDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            positionMouse.X=e.X; positionMouse.Y=e.Y;
        }
        private void MouseClickUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void MouseClickMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currentPoint = PointToScreen(new Point(e.X, e.Y));
                this.Location =new Point(currentPoint.X - positionMouse.X+bg1.Left, currentPoint.Y - positionMouse.Y);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int speed = 10;
            bg1.Left += speed;
            bg2.Left += speed;
            int speedEnemy = 7;
            enemy1.Left += speedEnemy;
            enemy2.Left += speedEnemy;
            patrones.Left += speed;
            message.Top += 4;
            if(message.Top>=0) message.Top = 0;
            if (attack)
            {
                bullet.Left -= speedBullet;
                bullet.Visible = true;
                bullet.Enabled = true;
                labelPatrones.Text = "Taken patrones: " + countPatrones;
                
            }
            
            if (enemy1.Left >= 1280)
            {
                enemy1.Left = -120;
                Random randomSpawn = new Random();
                enemy1.Top = randomSpawn.Next(0, 290);
            }

            if(patrones.Left > 1280)
            {
                patrones.Left = -220;
                Random randomSpawn = new Random();
                patrones.Top = randomSpawn.Next(0, 520);
                devide.Visible = false;
            }
            if(enemy2.Left >= 1280)
            {
                enemy2.Left = -120;
                Random randomSpawn = new Random();
                enemy2.Top = randomSpawn.Next(291, 520);
                devide.Visible = false;
            }
            if (bg1.Left >= 1280) 
            {
                bg1.Left = 0;
                bg2.Left = -1280;
            }
            if(player.Bounds.IntersectsWith(enemy1.Bounds) || player.Bounds.IntersectsWith(enemy2.Bounds) || (player.Top >= 590))
            {
                timer1.Enabled = false;
                labelLose.Visible = true;
                btnRestart.Visible = true;
                lose = true;
                fon.Left = player.Left;
                fon.Top = player.Top;
                fon.Visible = true;
            }
            if(enemy1.Bounds.IntersectsWith(bullet.Bounds))
            {
                bullet.Visible = false;
                bullet.Enabled = false;
                devide.Top = enemy1.Top;
                devide.Left = enemy1.Left;
                devide.Visible = true;
                devide.Left += 10;
                enemy1.Left = -240;
                attack = false;
                bullet.Left = 0;
                bullet.Top = 0;
                
                SoundPlayer playerMedia = new SoundPlayer();
                playerMedia.SoundLocation = (@"C:\Users\Данил\source\repos\DuckGame\Resources\bah.wav");
                playerMedia.Play();
            }
            if (enemy2.Bounds.IntersectsWith(bullet.Bounds))
            {
                bullet.Visible = false;
                attack = false;
                bullet.Enabled = false;
                devide.Top = enemy2.Top;
                devide.Left = enemy2.Left;
                devide.Visible = true;
                devide.Left += 10;
                enemy2.Left = -210;
                bullet.Left = 0;
                bullet.Top = 0;
                
                SoundPlayer playerMedia = new SoundPlayer();
                playerMedia.SoundLocation = (@"C:\Users\Данил\source\repos\DuckGame\Resources\bah.wav");
                playerMedia.Play();

            }
            if (player.Bounds.IntersectsWith(patrones.Bounds))
            {
                countPatrones++;
                labelPatrones.Text = "Taken patrones: "+countPatrones.ToString();
                patrones.Left = -220;
                Random rand = new Random();
                patrones.Top = rand.Next(0, 590);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (lose) return;
            int speedPlane = 10;
            if ((e.KeyCode == Keys.Up || e.KeyCode == Keys.W) &&(player.Top >=0))
                player.Top -= speedPlane;
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
                player.Top += speedPlane;
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                player.Left -= speedPlane;
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {

                player.Left += speedPlane;
            }
            else if ((e.KeyCode == Keys.Space) && (countPatrones > 0))
            {
                
                bullet.Left = player.Left;
                bullet.Top = player.Top;
                attack = true;
                countPatrones--;
                SoundPlayer playerMedia = new SoundPlayer();
                playerMedia.SoundLocation = (@"C:\Users\Данил\source\repos\DuckGame\Resources\poletpuli.wav");
                playerMedia.Play();
                
            }

            else if (e.KeyCode == Keys.Escape)
                this.Close();
        }


        private void btnRestart_Click(object sender, EventArgs e)
        {
            player.Top = 250;
            enemy1.Left = -120;
            enemy2.Left = -330;
            labelLose.Visible=false;
            btnRestart.Visible=false; 
            timer1.Enabled= true;
            lose = false;
            countPatrones = 0;
            labelPatrones.Text = "Taken patrones: 0";
            patrones.Left = -220;
            bullet.Visible = false;
            bullet.Enabled = false;
            Application.Restart();
            SoundPlayer playerMedia = new SoundPlayer();
            playerMedia.SoundLocation = (@"C:\Users\Данил\source\repos\DuckGame\Resources\testik.wav");
            playerMedia.Play();
        }
    }
}
