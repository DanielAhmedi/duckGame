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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.bg1 = new System.Windows.Forms.PictureBox();
            this.bg2 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.labelLose = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // enemy2
            // 
            this.enemy2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.enemy2.Image = Resourcec.enemy1;
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
            this.player.Image = Resourcec.image_removebg_preview_2_;
            this.player.Location = new System.Drawing.Point(1028, 365);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(138, 68);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // bg1
            // 
            this.bg1.Image = Resourcec.theme;
            this.bg1.Location = new System.Drawing.Point(0, 0);
            this.bg1.Name = "bg1";
            this.bg1.Size = new System.Drawing.Size(1280, 719);
            this.bg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bg1.TabIndex = 0;
            this.bg1.TabStop = false;
            // 
            // bg2
            // 
            this.bg2.Image = Resourcec.theme;
            this.bg2.Location = new System.Drawing.Point(-1280, 0);
            this.bg2.Name = "bg2";
            this.bg2.Size = new System.Drawing.Size(1280, 719);
            this.bg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bg2.TabIndex = 2;
            this.bg2.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.enemy1.Image = Resourcec.enemy1;
            this.enemy1.Location = new System.Drawing.Point(-330, 120);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(103, 90);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 4;
            this.enemy1.TabStop = false;
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(135, 228);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1280, 719);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bg1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox bg2;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.Label labelLose;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

