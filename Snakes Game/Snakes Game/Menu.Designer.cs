namespace Snakes_Game
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnAide = new System.Windows.Forms.Button();
            this.btnInformation = new System.Windows.Forms.Button();
            this.txtInformation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAide
            // 
            this.btnAide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnAide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAide.FlatAppearance.BorderSize = 0;
            this.btnAide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAide.Font = new System.Drawing.Font("MS PGothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAide.ForeColor = System.Drawing.Color.White;
            this.btnAide.Location = new System.Drawing.Point(193, 235);
            this.btnAide.Name = "btnAide";
            this.btnAide.Size = new System.Drawing.Size(338, 49);
            this.btnAide.TabIndex = 0;
            this.btnAide.Text = "Aide";
            this.btnAide.UseVisualStyleBackColor = false;
            this.btnAide.Click += new System.EventHandler(this.btnAide_Click);
            // 
            // btnInformation
            // 
            this.btnInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInformation.FlatAppearance.BorderSize = 0;
            this.btnInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformation.Font = new System.Drawing.Font("MS PGothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformation.ForeColor = System.Drawing.Color.White;
            this.btnInformation.Location = new System.Drawing.Point(193, 375);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Size = new System.Drawing.Size(338, 49);
            this.btnInformation.TabIndex = 2;
            this.btnInformation.Text = "Information";
            this.btnInformation.UseVisualStyleBackColor = false;
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // txtInformation
            // 
            this.txtInformation.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInformation.Location = new System.Drawing.Point(-1, 0);
            this.txtInformation.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txtInformation.Multiline = true;
            this.txtInformation.Name = "txtInformation";
            this.txtInformation.Size = new System.Drawing.Size(733, 192);
            this.txtInformation.TabIndex = 3;
            this.txtInformation.Text = "Se jeu video a été réaliser par les Etudiants de la TIPAM1 \r\nde l\'institut univai" +
    "sitaire de la côte situer au Cameroun Dans La ville de Doula plus Precisement\r\nA" +
    " Logbessou\r\n\r\nAnnee Scolaire 2020-2023";
            this.txtInformation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInformation.Visible = false;
            this.txtInformation.WordWrap = false;
            this.txtInformation.Click += new System.EventHandler(this.txtInformation_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(250)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(729, 584);
            this.Controls.Add(this.txtInformation);
            this.Controls.Add(this.btnInformation);
            this.Controls.Add(this.btnAide);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAide;
        private System.Windows.Forms.Button btnInformation;
        private System.Windows.Forms.TextBox txtInformation;
    }
}