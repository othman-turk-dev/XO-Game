namespace XO_Game
{
    partial class FrmGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGame));
            this.BT_Restart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LP_Winner = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LB_Round = new System.Windows.Forms.Label();
            this.LP_NamePlayer = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.PB_Player = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Player)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_Restart
            // 
            this.BT_Restart.BackColor = System.Drawing.Color.Black;
            this.BT_Restart.Font = new System.Drawing.Font("Microsoft New Tai Lue", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Restart.ForeColor = System.Drawing.Color.Transparent;
            this.BT_Restart.Location = new System.Drawing.Point(183, 703);
            this.BT_Restart.Name = "BT_Restart";
            this.BT_Restart.Size = new System.Drawing.Size(207, 81);
            this.BT_Restart.TabIndex = 32;
            this.BT_Restart.Text = "Restart Game";
            this.BT_Restart.UseVisualStyleBackColor = false;
            this.BT_Restart.Click += new System.EventHandler(this.BT_Restart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(1005, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 68);
            this.label2.TabIndex = 34;
            this.label2.Text = "Game";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(737, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 68);
            this.label1.TabIndex = 33;
            this.label1.Text = "Tic-Tac-Toe";
            // 
            // LP_Winner
            // 
            this.LP_Winner.AutoSize = true;
            this.LP_Winner.Font = new System.Drawing.Font("Sitka Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LP_Winner.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LP_Winner.Location = new System.Drawing.Point(196, 644);
            this.LP_Winner.Name = "LP_Winner";
            this.LP_Winner.Size = new System.Drawing.Size(176, 40);
            this.LP_Winner.TabIndex = 36;
            this.LP_Winner.Text = "In Progress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(234, 587);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 40);
            this.label3.TabIndex = 35;
            this.label3.Text = "Winner";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label9.Location = new System.Drawing.Point(864, 748);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 40);
            this.label9.TabIndex = 51;
            this.label9.Text = "Round: ";
            // 
            // LB_Round
            // 
            this.LB_Round.AutoSize = true;
            this.LB_Round.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LB_Round.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Round.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LB_Round.Location = new System.Drawing.Point(982, 756);
            this.LB_Round.Name = "LB_Round";
            this.LB_Round.Size = new System.Drawing.Size(27, 28);
            this.LB_Round.TabIndex = 50;
            this.LB_Round.Tag = "0";
            this.LB_Round.Text = "1";
            // 
            // LP_NamePlayer
            // 
            this.LP_NamePlayer.AutoSize = true;
            this.LP_NamePlayer.Font = new System.Drawing.Font("Sitka Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LP_NamePlayer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LP_NamePlayer.Location = new System.Drawing.Point(234, 456);
            this.LP_NamePlayer.Name = "LP_NamePlayer";
            this.LP_NamePlayer.Size = new System.Drawing.Size(127, 40);
            this.LP_NamePlayer.TabIndex = 52;
            this.LP_NamePlayer.Text = "Player 1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = global::XO_Game.Properties.Resources.dba76d69c0cd0ddb4ac0538054b0670e;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(609, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 457);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = global::XO_Game.Properties.Resources._929b9d9423e84d4e07edf17fd94d5c44;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.Location = new System.Drawing.Point(301, 201);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 75);
            this.button5.TabIndex = 59;
            this.button5.Tag = "?";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.BackgroundImage = global::XO_Game.Properties.Resources._929b9d9423e84d4e07edf17fd94d5c44;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.Transparent;
            this.button9.Location = new System.Drawing.Point(504, 317);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(110, 75);
            this.button9.TabIndex = 63;
            this.button9.Tag = "?";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::XO_Game.Properties.Resources._929b9d9423e84d4e07edf17fd94d5c44;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Location = new System.Drawing.Point(98, 201);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 75);
            this.button4.TabIndex = 58;
            this.button4.Tag = "?";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::XO_Game.Properties.Resources._929b9d9423e84d4e07edf17fd94d5c44;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(98, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 75);
            this.button1.TabIndex = 55;
            this.button1.Tag = "?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = global::XO_Game.Properties.Resources._929b9d9423e84d4e07edf17fd94d5c44;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.Transparent;
            this.button6.Location = new System.Drawing.Point(504, 201);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 75);
            this.button6.TabIndex = 60;
            this.button6.Tag = "?";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.BackgroundImage = global::XO_Game.Properties.Resources._929b9d9423e84d4e07edf17fd94d5c44;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.Transparent;
            this.button8.Location = new System.Drawing.Point(301, 317);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(110, 75);
            this.button8.TabIndex = 62;
            this.button8.Tag = "?";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::XO_Game.Properties.Resources._929b9d9423e84d4e07edf17fd94d5c44;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(504, 80);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 75);
            this.button3.TabIndex = 57;
            this.button3.Tag = "?";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::XO_Game.Properties.Resources._929b9d9423e84d4e07edf17fd94d5c44;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(301, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 75);
            this.button2.TabIndex = 56;
            this.button2.Tag = "?";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.BackgroundImage = global::XO_Game.Properties.Resources._929b9d9423e84d4e07edf17fd94d5c44;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.Transparent;
            this.button7.Location = new System.Drawing.Point(98, 317);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(110, 75);
            this.button7.TabIndex = 61;
            this.button7.Tag = "?";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // PB_Player
            // 
            this.PB_Player.Image = global::XO_Game.Properties.Resources._1b8079b5a79671e7210211540b2e3705;
            this.PB_Player.Location = new System.Drawing.Point(183, 222);
            this.PB_Player.Name = "PB_Player";
            this.PB_Player.Size = new System.Drawing.Size(224, 231);
            this.PB_Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Player.TabIndex = 53;
            this.PB_Player.TabStop = false;
            // 
            // FrmGame
            // 
            this.AcceptButton = this.BT_Restart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1846, 886);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PB_Player);
            this.Controls.Add(this.LP_NamePlayer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LB_Round);
            this.Controls.Add(this.LP_Winner);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_Restart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tic Tac Toe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmGame_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Restart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LP_Winner;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LB_Round;
        private System.Windows.Forms.Label LP_NamePlayer;
        private System.Windows.Forms.PictureBox PB_Player;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button7;
    }
}