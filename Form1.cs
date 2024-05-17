using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuckGame
{
    public partial class Form1 : Form
    {   //hui
        
        private Point positionMouse;
        private bool dragging, lose =false;
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
            if(enemy1.Left >= 1280)
            {
                enemy1.Left = -120;
                Random randomSpawn = new Random();
                enemy1.Top = randomSpawn.Next(0, 290);
            }

            if(enemy2.Left >= 1280)
            {
                enemy2.Left = -120;
                Random randomSpawn = new Random();
                enemy2.Top = randomSpawn.Next(291, 520);
            }
            if (bg1.Left >= 1280) 
            {
                bg1.Left = 0;
                bg2.Left = -1280;
            }
            if(player.Bounds.IntersectsWith(enemy1.Bounds) || player.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                labelLose.Visible = true;
                btnRestart.Visible = true;
                lose = true;
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
                player.Left += speedPlane;

            else if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            enemy1.Left = -120;
            enemy2.Left = -330;
            labelLose.Visible=false;
            btnRestart.Visible=false; 
            timer1.Enabled=true;
            lose = false;
        }
    }
}
