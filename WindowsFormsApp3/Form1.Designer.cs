namespace WindowsFormsApp3
{
    partial class Form1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gravity = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.p1Score_label = new System.Windows.Forms.Label();
            this.p2score_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.player2_energy = new System.Windows.Forms.ProgressBar();
            this.player1_energy = new System.Windows.Forms.ProgressBar();
            this.energylPLayer2 = new System.Windows.Forms.Label();
            this.EnergylPLayer = new System.Windows.Forms.Label();
            this.uriahAbility = new System.Windows.Forms.Timer(this.components);
            this.boginAbility = new System.Windows.Forms.Timer(this.components);
            this.HeinmannAbility = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.crossbar2 = new System.Windows.Forms.PictureBox();
            this.crossbar1 = new System.Windows.Forms.PictureBox();
            this.player2 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.goalPlayer = new System.Windows.Forms.PictureBox();
            this.goalPC = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.Time = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossbar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossbar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gravity
            // 
            this.gravity.Tick += new System.EventHandler(this.gravity_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 300;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // p1Score_label
            // 
            this.p1Score_label.AutoSize = true;
            this.p1Score_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1Score_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.p1Score_label.Location = new System.Drawing.Point(938, 46);
            this.p1Score_label.Name = "p1Score_label";
            this.p1Score_label.Size = new System.Drawing.Size(100, 37);
            this.p1Score_label.TabIndex = 5;
            this.p1Score_label.Text = "label1";
            this.p1Score_label.Click += new System.EventHandler(this.p1Score_Click);
            // 
            // p2score_label
            // 
            this.p2score_label.AutoSize = true;
            this.p2score_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2score_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.p2score_label.Location = new System.Drawing.Point(109, 46);
            this.p2score_label.Name = "p2score_label";
            this.p2score_label.Size = new System.Drawing.Size(100, 37);
            this.p2score_label.TabIndex = 7;
            this.p2score_label.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(337, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 52);
            this.label1.TabIndex = 8;
            this.label1.Text = "Press Enter to start";
            // 
            // player2_energy
            // 
            this.player2_energy.Location = new System.Drawing.Point(292, 46);
            this.player2_energy.Name = "player2_energy";
            this.player2_energy.Size = new System.Drawing.Size(129, 26);
            this.player2_energy.TabIndex = 9;
            // 
            // player1_energy
            // 
            this.player1_energy.Location = new System.Drawing.Point(776, 46);
            this.player1_energy.Name = "player1_energy";
            this.player1_energy.Size = new System.Drawing.Size(129, 26);
            this.player1_energy.TabIndex = 11;
            // 
            // energylPLayer2
            // 
            this.energylPLayer2.AutoSize = true;
            this.energylPLayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.energylPLayer2.ForeColor = System.Drawing.Color.Red;
            this.energylPLayer2.Location = new System.Drawing.Point(286, 88);
            this.energylPLayer2.Name = "energylPLayer2";
            this.energylPLayer2.Size = new System.Drawing.Size(203, 32);
            this.energylPLayer2.TabIndex = 14;
            this.energylPLayer2.Text = "Full Energy (E)";
            // 
            // EnergylPLayer
            // 
            this.EnergylPLayer.AutoSize = true;
            this.EnergylPLayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnergylPLayer.ForeColor = System.Drawing.Color.Red;
            this.EnergylPLayer.Location = new System.Drawing.Point(770, 88);
            this.EnergylPLayer.Name = "EnergylPLayer";
            this.EnergylPLayer.Size = new System.Drawing.Size(265, 32);
            this.EnergylPLayer.TabIndex = 15;
            this.EnergylPLayer.Text = "Full Energy (Space)";
            // 
            // uriahAbility
            // 
            this.uriahAbility.Interval = 3000;
            this.uriahAbility.Tick += new System.EventHandler(this.uriahAbility_Tick);
            // 
            // boginAbility
            // 
            this.boginAbility.Interval = 4000;
            this.boginAbility.Tick += new System.EventHandler(this.boginAbility_Tick);
            // 
            // HeinmannAbility
            // 
            this.HeinmannAbility.Interval = 4000;
            this.HeinmannAbility.Tick += new System.EventHandler(this.HeinmannAbility_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.timeLabel.Location = new System.Drawing.Point(488, 153);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(100, 37);
            this.timeLabel.TabIndex = 18;
            this.timeLabel.Text = "label1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp3.Properties.Resources.goal;
            this.pictureBox2.Location = new System.Drawing.Point(1034, 373);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 216);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp3.Properties.Resources.goal;
            this.pictureBox1.Location = new System.Drawing.Point(0, 373);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // crossbar2
            // 
            this.crossbar2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.crossbar2.Location = new System.Drawing.Point(1034, 359);
            this.crossbar2.Name = "crossbar2";
            this.crossbar2.Size = new System.Drawing.Size(100, 26);
            this.crossbar2.TabIndex = 13;
            this.crossbar2.TabStop = false;
            // 
            // crossbar1
            // 
            this.crossbar1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.crossbar1.Location = new System.Drawing.Point(0, 359);
            this.crossbar1.Name = "crossbar1";
            this.crossbar1.Size = new System.Drawing.Size(102, 26);
            this.crossbar1.TabIndex = 12;
            this.crossbar1.TabStop = false;
            this.crossbar1.Click += new System.EventHandler(this.crossbar1_Click);
            // 
            // player2
            // 
            this.player2.BackColor = System.Drawing.SystemColors.GrayText;
            this.player2.Image = global::WindowsFormsApp3.Properties.Resources.uriahLogo1;
            this.player2.Location = new System.Drawing.Point(219, 519);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(70, 70);
            this.player2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player2.TabIndex = 6;
            this.player2.TabStop = false;
            this.player2.Visible = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.SystemColors.GrayText;
            this.player.Image = global::WindowsFormsApp3.Properties.Resources.ShaniLogo;
            this.player.Location = new System.Drawing.Point(857, 519);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(70, 70);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 4;
            this.player.TabStop = false;
            this.player.Visible = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.White;
            this.ball.Image = global::WindowsFormsApp3.Properties.Resources.ball1;
            this.ball.Location = new System.Drawing.Point(508, 301);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 30);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball.TabIndex = 3;
            this.ball.TabStop = false;
            // 
            // goalPlayer
            // 
            this.goalPlayer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.goalPlayer.Location = new System.Drawing.Point(1098, 373);
            this.goalPlayer.Name = "goalPlayer";
            this.goalPlayer.Size = new System.Drawing.Size(36, 216);
            this.goalPlayer.TabIndex = 2;
            this.goalPlayer.TabStop = false;
            // 
            // goalPC
            // 
            this.goalPC.BackColor = System.Drawing.SystemColors.ControlDark;
            this.goalPC.Location = new System.Drawing.Point(0, 373);
            this.goalPC.Name = "goalPC";
            this.goalPC.Size = new System.Drawing.Size(49, 216);
            this.goalPC.TabIndex = 1;
            this.goalPC.TabStop = false;
            // 
            // Ground
            // 
            this.Ground.BackColor = System.Drawing.Color.LimeGreen;
            this.Ground.Location = new System.Drawing.Point(-2, 587);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(1144, 50);
            this.Ground.TabIndex = 0;
            this.Ground.TabStop = false;
            // 
            // Time
            // 
            this.Time.Interval = 1000;
            this.Time.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1135, 637);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.EnergylPLayer);
            this.Controls.Add(this.energylPLayer2);
            this.Controls.Add(this.crossbar2);
            this.Controls.Add(this.crossbar1);
            this.Controls.Add(this.player1_energy);
            this.Controls.Add(this.player2_energy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.p2score_label);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.p1Score_label);
            this.Controls.Add(this.player);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.goalPlayer);
            this.Controls.Add(this.goalPC);
            this.Controls.Add(this.Ground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossbar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossbar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.PictureBox goalPC;
        private System.Windows.Forms.PictureBox goalPlayer;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer gravity;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label p1Score_label;
        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.Label p2score_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar player2_energy;
        private System.Windows.Forms.ProgressBar player1_energy;
        private System.Windows.Forms.PictureBox crossbar1;
        private System.Windows.Forms.PictureBox crossbar2;
        private System.Windows.Forms.Label energylPLayer2;
        private System.Windows.Forms.Label EnergylPLayer;
        private System.Windows.Forms.Timer uriahAbility;
        private System.Windows.Forms.Timer boginAbility;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer HeinmannAbility;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer Time;
    }
}

