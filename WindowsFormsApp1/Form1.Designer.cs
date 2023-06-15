namespace WindowsFormsApp1
{
    partial class Pong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pong));
            this.player1 = new System.Windows.Forms.PictureBox();
            this.cpuPlayer = new System.Windows.Forms.PictureBox();
            this.pongBall = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.playerScoreLabel = new System.Windows.Forms.Label();
            this.cpuScoreLabel = new System.Windows.Forms.Label();
            this.pongTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pongBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.Color.DarkRed;
            this.player1.Location = new System.Drawing.Point(12, 269);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(14, 108);
            this.player1.TabIndex = 0;
            this.player1.TabStop = false;
            // 
            // cpuPlayer
            // 
            this.cpuPlayer.BackColor = System.Drawing.Color.DarkOrange;
            this.cpuPlayer.Location = new System.Drawing.Point(1023, 269);
            this.cpuPlayer.Name = "cpuPlayer";
            this.cpuPlayer.Size = new System.Drawing.Size(17, 108);
            this.cpuPlayer.TabIndex = 1;
            this.cpuPlayer.TabStop = false;
            // 
            // pongBall
            // 
            this.pongBall.BackColor = System.Drawing.Color.Transparent;
            this.pongBall.Image = ((System.Drawing.Image)(resources.GetObject("pongBall.Image")));
            this.pongBall.InitialImage = null;
            this.pongBall.Location = new System.Drawing.Point(507, 311);
            this.pongBall.Name = "pongBall";
            this.pongBall.Size = new System.Drawing.Size(38, 34);
            this.pongBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pongBall.TabIndex = 2;
            this.pongBall.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(396, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // playerScoreLabel
            // 
            this.playerScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerScoreLabel.Font = new System.Drawing.Font("BACKCOUNTRY", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScoreLabel.ForeColor = System.Drawing.Color.Linen;
            this.playerScoreLabel.Location = new System.Drawing.Point(301, 29);
            this.playerScoreLabel.Name = "playerScoreLabel";
            this.playerScoreLabel.Size = new System.Drawing.Size(75, 60);
            this.playerScoreLabel.TabIndex = 4;
            this.playerScoreLabel.Text = "0";
            this.playerScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpuScoreLabel
            // 
            this.cpuScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.cpuScoreLabel.Font = new System.Drawing.Font("BACKCOUNTRY", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuScoreLabel.ForeColor = System.Drawing.Color.Linen;
            this.cpuScoreLabel.Location = new System.Drawing.Point(642, 29);
            this.cpuScoreLabel.Name = "cpuScoreLabel";
            this.cpuScoreLabel.Size = new System.Drawing.Size(75, 60);
            this.cpuScoreLabel.TabIndex = 5;
            this.cpuScoreLabel.Text = "0";
            this.cpuScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pongTimer
            // 
            this.pongTimer.Enabled = true;
            this.pongTimer.Interval = 20;
            this.pongTimer.Tick += new System.EventHandler(this.pongTimer_Tick);
            // 
            // Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Table;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1052, 648);
            this.Controls.Add(this.cpuPlayer);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.pongBall);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.playerScoreLabel);
            this.Controls.Add(this.cpuScoreLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1068, 687);
            this.MinimumSize = new System.Drawing.Size(1068, 687);
            this.Name = "Pong";
            this.Text = "Pong";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pong_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Pong_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pongBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.PictureBox cpuPlayer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label playerScoreLabel;
        private System.Windows.Forms.Label cpuScoreLabel;
        public System.Windows.Forms.PictureBox pongBall;
        public System.Windows.Forms.Timer pongTimer;
    }
}

