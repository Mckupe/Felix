namespace Felix
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
            this.platform = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblScore = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.wall = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Ralph = new System.Windows.Forms.PictureBox();
            this.tmrEnemy = new System.Windows.Forms.Timer(this.components);
            this.progectals = new System.Windows.Forms.PictureBox();
            this.HpBar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.platform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ralph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progectals)).BeginInit();
            this.SuspendLayout();
            // 
            // platform
            // 
            this.platform.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.platform.Location = new System.Drawing.Point(-8, 579);
            this.platform.Name = "platform";
            this.platform.Size = new System.Drawing.Size(497, 30);
            this.platform.TabIndex = 0;
            this.platform.TabStop = false;
            this.platform.Tag = "platform";
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Player.Location = new System.Drawing.Point(231, 481);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(30, 50);
            this.Player.TabIndex = 1;
            this.Player.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox1.Location = new System.Drawing.Point(71, 465);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 10);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "platform";
            // 
            // LblScore
            // 
            this.LblScore.AutoSize = true;
            this.LblScore.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblScore.Location = new System.Drawing.Point(23, 9);
            this.LblScore.Name = "LblScore";
            this.LblScore.Size = new System.Drawing.Size(80, 20);
            this.LblScore.TabIndex = 3;
            this.LblScore.Text = "Score : 0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox2.Location = new System.Drawing.Point(75, 343);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(350, 11);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "platform";
            // 
            // wall
            // 
            this.wall.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.wall.Location = new System.Drawing.Point(464, -11);
            this.wall.Name = "wall";
            this.wall.Size = new System.Drawing.Size(25, 640);
            this.wall.TabIndex = 5;
            this.wall.TabStop = false;
            this.wall.Tag = "wall";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox3.Location = new System.Drawing.Point(-8, -11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 640);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "wall";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox4.Location = new System.Drawing.Point(72, 218);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(353, 10);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "platform";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox5.Location = new System.Drawing.Point(75, 78);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(423, 10);
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "platform";
            // 
            // Ralph
            // 
            this.Ralph.BackColor = System.Drawing.Color.Red;
            this.Ralph.Location = new System.Drawing.Point(176, -29);
            this.Ralph.Name = "Ralph";
            this.Ralph.Size = new System.Drawing.Size(124, 117);
            this.Ralph.TabIndex = 9;
            this.Ralph.TabStop = false;
            // 
            // tmrEnemy
            // 
            this.tmrEnemy.Enabled = true;
            this.tmrEnemy.Interval = 500;
            this.tmrEnemy.Tick += new System.EventHandler(this.TmrEnemy_Tick);
            // 
            // progectals
            // 
            this.progectals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.progectals.Location = new System.Drawing.Point(176, -32);
            this.progectals.Name = "progectals";
            this.progectals.Size = new System.Drawing.Size(124, 120);
            this.progectals.TabIndex = 10;
            this.progectals.TabStop = false;
            this.progectals.Tag = "breack";
            // 
            // HpBar
            // 
            this.HpBar.AutoSize = true;
            this.HpBar.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HpBar.Location = new System.Drawing.Point(395, 9);
            this.HpBar.Name = "HpBar";
            this.HpBar.Size = new System.Drawing.Size(57, 23);
            this.HpBar.TabIndex = 11;
            this.HpBar.Text = "Hp: 3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 621);
            this.Controls.Add(this.HpBar);
            this.Controls.Add(this.Ralph);
            this.Controls.Add(this.progectals);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.wall);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LblScore);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.platform);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.platform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ralph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progectals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox platform;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblScore;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox wall;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox Ralph;
        private System.Windows.Forms.Timer tmrEnemy;
        private System.Windows.Forms.PictureBox progectals;
        private System.Windows.Forms.Label HpBar;
    }
}

