using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using WMPLib;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Snakes_Game
{
    public partial class Acceuil : Form
    {
       public  WindowsMediaPlayer playacceuil = new WindowsMediaPlayer();
    
        public Acceuil()
        {
            InitializeComponent();
            playacceuil.URL = "Snake_java.mp3";
        }
        private void Acceuil_Load(object sender, EventArgs e)
        {
            
                playacceuil.controls.play();
         
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            Niveau fj = new Niveau();
            fj.Show();
            playacceuil.controls.stop();
        ;
        }

      

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Est-Tu sur de voulez Quitter", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.Show();
            
        }
    }
}
