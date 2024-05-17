using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DuckGame;

public class Class1
{
	public Class1()
	{
        InitializeComponent();
        public void btnRestart_Click(object sender, EventArgs e)
        {
            enemy1.Left = -120;
            enemy2.Left = -330;
            labelLose.Visible = false;
            btnRestart.Visible = false;
            timer1.Enabled = true;
            lose = false;
        }
    }
    public void btnRestart_Click(object sender, EventArgs e)
    {
        enemy1.Left = -120;
        enemy2.Left = -330;
        labelLose.Visible = false;
        btnRestart.Visible = false;
        timer1.Enabled = true;
        lose = false;
    }
}
