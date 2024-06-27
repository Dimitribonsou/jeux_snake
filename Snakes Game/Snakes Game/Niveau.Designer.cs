namespace Snakes_Game
{
    partial class Niveau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Niveau));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDifficile = new System.Windows.Forms.Button();
            this.btnMoyen = new System.Windows.Forms.Button();
            this.btnFacile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDifficile);
            this.groupBox1.Controls.Add(this.btnMoyen);
            this.groupBox1.Controls.Add(this.btnFacile);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(43, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 375);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Niveau";
            // 
            // btnDifficile
            // 
            this.btnDifficile.BackColor = System.Drawing.Color.Silver;
            this.btnDifficile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDifficile.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDifficile.FlatAppearance.BorderSize = 0;
            this.btnDifficile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDifficile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDifficile.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDifficile.ForeColor = System.Drawing.Color.Black;
            this.btnDifficile.Location = new System.Drawing.Point(104, 264);
            this.btnDifficile.Name = "btnDifficile";
            this.btnDifficile.Size = new System.Drawing.Size(312, 55);
            this.btnDifficile.TabIndex = 5;
            this.btnDifficile.Text = "Difficile";
            this.btnDifficile.UseVisualStyleBackColor = false;
            this.btnDifficile.Click += new System.EventHandler(this.btnDifficile_Click);
            // 
            // btnMoyen
            // 
            this.btnMoyen.BackColor = System.Drawing.Color.Silver;
            this.btnMoyen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoyen.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMoyen.FlatAppearance.BorderSize = 0;
            this.btnMoyen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMoyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoyen.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoyen.ForeColor = System.Drawing.Color.Black;
            this.btnMoyen.Location = new System.Drawing.Point(104, 171);
            this.btnMoyen.Name = "btnMoyen";
            this.btnMoyen.Size = new System.Drawing.Size(312, 55);
            this.btnMoyen.TabIndex = 4;
            this.btnMoyen.Text = "Moyen";
            this.btnMoyen.UseVisualStyleBackColor = false;
            this.btnMoyen.Click += new System.EventHandler(this.btnMoyen_Click);
            // 
            // btnFacile
            // 
            this.btnFacile.BackColor = System.Drawing.Color.Silver;
            this.btnFacile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacile.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFacile.FlatAppearance.BorderSize = 0;
            this.btnFacile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFacile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacile.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacile.ForeColor = System.Drawing.Color.Black;
            this.btnFacile.Location = new System.Drawing.Point(109, 78);
            this.btnFacile.Name = "btnFacile";
            this.btnFacile.Size = new System.Drawing.Size(312, 55);
            this.btnFacile.TabIndex = 3;
            this.btnFacile.Text = "Facile";
            this.btnFacile.UseVisualStyleBackColor = false;
            this.btnFacile.Click += new System.EventHandler(this.button1_Click);
            // 
            // Niveau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(250)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(627, 541);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Niveau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Niveau";
            this.Load += new System.EventHandler(this.Niveau_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDifficile;
        private System.Windows.Forms.Button btnMoyen;
        private System.Windows.Forms.Button btnFacile;
    }
}