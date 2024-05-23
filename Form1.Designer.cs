using DuckGame.Resources;

namespace DuckGame
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelLose = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.labelPatrones = new System.Windows.Forms.Label();
            this.MXP = new AxWMPLib.AxWindowsMediaPlayer();
            this.MXP2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.fall = new System.Windows.Forms.PictureBox();
            this.message = new System.Windows.Forms.PictureBox();
            this.fon = new System.Windows.Forms.PictureBox();
            this.devide = new System.Windows.Forms.PictureBox();
            this.bullet = new System.Windows.Forms.PictureBox();
            this.patrones = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.bg1 = new System.Windows.Forms.PictureBox();
            this.bg2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MXP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MXP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.message)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patrones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelLose
            // 
            this.labelLose.AutoSize = true;
            this.labelLose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLose.Font = new System.Drawing.Font("Playbill", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLose.Location = new System.Drawing.Point(480, 274);
            this.labelLose.Name = "labelLose";
            this.labelLose.Size = new System.Drawing.Size(284, 98);
            this.labelLose.TabIndex = 5;
            this.labelLose.Text = "YOU LOSE";
            this.labelLose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Playbill", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(445, 397);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(350, 73);
            this.btnRestart.TabIndex = 6;
            this.btnRestart.Text = "let\'s again, pupsik";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // labelPatrones
            // 
            this.labelPatrones.AutoSize = true;
            this.labelPatrones.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPatrones.Font = new System.Drawing.Font("Playbill", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatrones.Location = new System.Drawing.Point(1020, 9);
            this.labelPatrones.Name = "labelPatrones";
            this.labelPatrones.Size = new System.Drawing.Size(248, 49);
            this.labelPatrones.TabIndex = 8;
            this.labelPatrones.Text = "Taken patrones: 0";
            this.labelPatrones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MXP
            // 
            this.MXP.Enabled = true;
            this.MXP.Location = new System.Drawing.Point(137, 470);
            this.MXP.Name = "MXP";
            this.MXP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MXP.OcxState")));
            this.MXP.Size = new System.Drawing.Size(224, 47);
            this.MXP.TabIndex = 10;
            // 
            // MXP2
            // 
            this.MXP2.Enabled = true;
            this.MXP2.Location = new System.Drawing.Point(890, 511);
            this.MXP2.Name = "MXP2";
            this.MXP2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MXP2.OcxState")));
            this.MXP2.Size = new System.Drawing.Size(224, 47);
            this.MXP2.TabIndex = 14;
            // 
            // fall
            // 
            this.fall.Image = global::DuckGame.Properties.Resources.joZZd_2khHw;
            this.fall.Location = new System.Drawing.Point(-2, -3);
            this.fall.Name = "fall";
            this.fall.Size = new System.Drawing.Size(967, 241);
            this.fall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fall.TabIndex = 16;
            this.fall.TabStop = false;
            // 
            // message
            // 
            this.message.Image = global::DuckGame.Properties.Resources.techertizer;
            this.message.Location = new System.Drawing.Point(0, -250);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(966, 235);
            this.message.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.message.TabIndex = 13;
            this.message.TabStop = false;
            // 
            // fon
            // 
            this.fon.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.fon.Image = global::DuckGame.Properties.Resources.Фон;
            this.fon.Location = new System.Drawing.Point(855, 587);
            this.fon.Name = "fon";
            this.fon.Size = new System.Drawing.Size(162, 73);
            this.fon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fon.TabIndex = 12;
            this.fon.TabStop = false;
            // 
            // devide
            // 
            this.devide.Image = global::DuckGame.Properties.Resources._13e06a48c8aaa4f8504175bc07ae0849;
            this.devide.Location = new System.Drawing.Point(166, 292);
            this.devide.Name = "devide";
            this.devide.Size = new System.Drawing.Size(164, 143);
            this.devide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.devide.TabIndex = 11;
            this.devide.TabStop = false;
            // 
            // bullet
            // 
            this.bullet.Enabled = false;
            this.bullet.Image = global::DuckGame.Properties.Resources.energyPatron;
            this.bullet.Location = new System.Drawing.Point(1200, 600);
            this.bullet.Name = "bullet";
            this.bullet.Size = new System.Drawing.Size(72, 19);
            this.bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet.TabIndex = 9;
            this.bullet.TabStop = false;
            this.bullet.Visible = false;
            
            // 
            // patrones
            // 
            this.patrones.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.patrones.Image = global::DuckGame.Properties.Resources.battery;
            this.patrones.Location = new System.Drawing.Point(-220, 220);
            this.patrones.Name = "patrones";
            this.patrones.Size = new System.Drawing.Size(64, 64);
            this.patrones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.patrones.TabIndex = 7;
            this.patrones.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.enemy1.Image = global::DuckGame.Resources.Resourcec.enemy1;
            this.enemy1.Location = new System.Drawing.Point(-330, 120);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(103, 90);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 4;
            this.enemy1.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.enemy2.Image = global::DuckGame.Resources.Resourcec.enemy1;
            this.enemy2.Location = new System.Drawing.Point(-120, 329);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(103, 90);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 3;
            this.enemy2.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Black;
            this.player.Image = global::DuckGame.Resources.Resourcec.image_removebg_preview_2_;
            this.player.Location = new System.Drawing.Point(1029, 337);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(138, 68);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // bg1
            // 
            this.bg1.Image = global::DuckGame.Resources.Resourcec.theme;
            this.bg1.Location = new System.Drawing.Point(-2, -3);
            this.bg1.Name = "bg1";
            this.bg1.Size = new System.Drawing.Size(1280, 719);
            this.bg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bg1.TabIndex = 0;
            this.bg1.TabStop = false;
            // 
            // bg2
            // 
            this.bg2.Image = global::DuckGame.Resources.Resourcec.theme;
            this.bg2.Location = new System.Drawing.Point(-1280, 0);
            this.bg2.Name = "bg2";
            this.bg2.Size = new System.Drawing.Size(1280, 719);
            this.bg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bg2.TabIndex = 2;
            this.bg2.TabStop = false;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1280, 719);
            this.Controls.Add(this.fall);
            this.Controls.Add(this.MXP2);
            this.Controls.Add(this.message);
            this.Controls.Add(this.fon);
            this.Controls.Add(this.devide);
            this.Controls.Add(this.MXP);
            this.Controls.Add(this.bullet);
            this.Controls.Add(this.labelPatrones);
            this.Controls.Add(this.patrones);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.labelLose);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.player);
            this.Controls.Add(this.bg1);
            this.Controls.Add(this.bg2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.MXP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MXP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.message)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patrones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox bg2;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.Label labelLose;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.PictureBox patrones;
        private System.Windows.Forms.Label labelPatrones;
        private System.Windows.Forms.PictureBox bg1;
        public System.Windows.Forms.PictureBox bullet;
        private AxWMPLib.AxWindowsMediaPlayer MXP;
        private System.Windows.Forms.PictureBox devide;
        private System.Windows.Forms.PictureBox fon;
        private System.Windows.Forms.PictureBox message;
        private AxWMPLib.AxWindowsMediaPlayer MXP2;
        private System.Windows.Forms.PictureBox fall;
    }
}

