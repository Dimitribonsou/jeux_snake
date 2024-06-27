namespace Snakes_Game
{
    partial class frmjeu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmjeu));
            this.btnSnap = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.Label();
            this.txtHigh_score = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbtime = new System.Windows.Forms.Label();
            this.lbscore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbniv = new System.Windows.Forms.Label();
            this.lblevel = new System.Windows.Forms.Label();
            this.lbGameOver = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbafNiv = new System.Windows.Forms.Label();
            this.pictureBoxLive2 = new System.Windows.Forms.PictureBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbheure = new System.Windows.Forms.Label();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.lbafflevel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLive2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSnap
            // 
            this.btnSnap.BackColor = System.Drawing.Color.Blue;
            this.btnSnap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSnap.FlatAppearance.BorderSize = 0;
            this.btnSnap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnap.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSnap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSnap.Location = new System.Drawing.Point(99, 237);
            this.btnSnap.Margin = new System.Windows.Forms.Padding(4);
            this.btnSnap.Name = "btnSnap";
            this.btnSnap.Size = new System.Drawing.Size(136, 60);
            this.btnSnap.TabIndex = 1;
            this.btnSnap.Text = "Partager";
            this.btnSnap.UseVisualStyleBackColor = false;
            this.btnSnap.Click += new System.EventHandler(this.TakeSnap);
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(116, 530);
            this.txtScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(103, 29);
            this.txtScore.TabIndex = 3;
            this.txtScore.Text = "Score : ";
            // 
            // txtHigh_score
            // 
            this.txtHigh_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHigh_score.Location = new System.Drawing.Point(23, 603);
            this.txtHigh_score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtHigh_score.Name = "txtHigh_score";
            this.txtHigh_score.Size = new System.Drawing.Size(314, 29);
            this.txtHigh_score.TabIndex = 4;
            this.txtHigh_score.Text = "Meilleur Score";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 70;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 471);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Time :";
            // 
            // lbtime
            // 
            this.lbtime.AutoSize = true;
            this.lbtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtime.ForeColor = System.Drawing.Color.Red;
            this.lbtime.Location = new System.Drawing.Point(195, 471);
            this.lbtime.Name = "lbtime";
            this.lbtime.Size = new System.Drawing.Size(35, 25);
            this.lbtime.TabIndex = 7;
            this.lbtime.Text = "0s";
            // 
            // lbscore
            // 
            this.lbscore.AutoSize = true;
            this.lbscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbscore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbscore.Location = new System.Drawing.Point(213, 530);
            this.lbscore.Name = "lbscore";
            this.lbscore.Size = new System.Drawing.Size(27, 29);
            this.lbscore.TabIndex = 8;
            this.lbscore.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Level :";
            // 
            // lbniv
            // 
            this.lbniv.AutoSize = true;
            this.lbniv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbniv.Location = new System.Drawing.Point(923, 221);
            this.lbniv.Name = "lbniv";
            this.lbniv.Size = new System.Drawing.Size(0, 25);
            this.lbniv.TabIndex = 10;
            // 
            // lblevel
            // 
            this.lblevel.CausesValidation = false;
            this.lblevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblevel.ForeColor = System.Drawing.Color.Lime;
            this.lblevel.Location = new System.Drawing.Point(203, 401);
            this.lblevel.Name = "lblevel";
            this.lblevel.Size = new System.Drawing.Size(54, 25);
            this.lblevel.TabIndex = 11;
            this.lblevel.Text = "1";
            // 
            // lbGameOver
            // 
            this.lbGameOver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            this.lbGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGameOver.ForeColor = System.Drawing.Color.Red;
            this.lbGameOver.Location = new System.Drawing.Point(187, 311);
            this.lbGameOver.Name = "lbGameOver";
            this.lbGameOver.Size = new System.Drawing.Size(700, 85);
            this.lbGameOver.TabIndex = 12;
            this.lbGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbGameOver.Visible = false;
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Blue;
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.FlatAppearance.BorderSize = 0;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRestart.Location = new System.Drawing.Point(99, 135);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(136, 57);
            this.btnRestart.TabIndex = 13;
            this.btnRestart.Text = "RESTART";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Visible = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lbafNiv);
            this.panel1.Controls.Add(this.pictureBoxLive2);
            this.panel1.Controls.Add(this.btnRestart);
            this.panel1.Controls.Add(this.btnSnap);
            this.panel1.Controls.Add(this.lblevel);
            this.panel1.Controls.Add(this.lbscore);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbtime);
            this.panel1.Controls.Add(this.txtHigh_score);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtScore);
            this.panel1.Location = new System.Drawing.Point(1108, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 892);
            this.panel1.TabIndex = 14;
            // 
            // lbafNiv
            // 
            this.lbafNiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbafNiv.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbafNiv.Location = new System.Drawing.Point(3, 43);
            this.lbafNiv.Name = "lbafNiv";
            this.lbafNiv.Size = new System.Drawing.Size(328, 51);
            this.lbafNiv.TabIndex = 17;
            this.lbafNiv.Text = "Niveau Facile";
            this.lbafNiv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxLive2
            // 
            this.pictureBoxLive2.Location = new System.Drawing.Point(140, 322);
            this.pictureBoxLive2.Name = "pictureBoxLive2";
            this.pictureBoxLive2.Size = new System.Drawing.Size(41, 25);
            this.pictureBoxLive2.TabIndex = 16;
            this.pictureBoxLive2.TabStop = false;
            // 
            // lbDate
            // 
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.Black;
            this.lbDate.Location = new System.Drawing.Point(110, 9);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(225, 44);
            this.lbDate.TabIndex = 14;
            this.lbDate.Text = "Date";
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lbheure);
            this.panel2.Controls.Add(this.lbDate);
            this.panel2.Location = new System.Drawing.Point(16, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1094, 72);
            this.panel2.TabIndex = 15;
            // 
            // lbheure
            // 
            this.lbheure.AutoSize = true;
            this.lbheure.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbheure.ForeColor = System.Drawing.Color.Black;
            this.lbheure.Location = new System.Drawing.Point(674, 9);
            this.lbheure.Name = "lbheure";
            this.lbheure.Size = new System.Drawing.Size(157, 46);
            this.lbheure.TabIndex = 16;
            this.lbheure.Text = "Heure :";
            // 
            // picCanvas
            // 
            this.picCanvas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picCanvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            this.picCanvas.Location = new System.Drawing.Point(16, 69);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(4);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(1094, 798);
            this.picCanvas.TabIndex = 2;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdatePictureBoxGraphics);
            // 
            // lbafflevel
            // 
            this.lbafflevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            this.lbafflevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbafflevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbafflevel.ForeColor = System.Drawing.Color.Red;
            this.lbafflevel.Location = new System.Drawing.Point(402, 84);
            this.lbafflevel.Name = "lbafflevel";
            this.lbafflevel.Size = new System.Drawing.Size(328, 51);
            this.lbafflevel.TabIndex = 18;
            this.lbafflevel.Text = "Level 1";
            this.lbafflevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbafflevel.Visible = false;
            // 
            // frmjeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 892);
            this.Controls.Add(this.lbafflevel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbGameOver);
            this.Controls.Add(this.lbniv);
            this.Controls.Add(this.picCanvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmjeu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "snake game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLive2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSnap;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtHigh_score;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbtime;
        private System.Windows.Forms.Label lbscore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbniv;
        private System.Windows.Forms.Label lblevel;
        private System.Windows.Forms.Label lbGameOver;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbheure;
        private System.Windows.Forms.PictureBox pictureBoxLive2;
        public System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lbafNiv;
        private System.Windows.Forms.Label lbafflevel;
    }
}

