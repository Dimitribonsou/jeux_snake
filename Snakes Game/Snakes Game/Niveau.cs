using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using WMPLib;
using System.Text; 
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snakes_Game
{
    public partial class Niveau : Form
    {
        public WindowsMediaPlayer player = new WindowsMediaPlayer();
        
        public Niveau()
        {
            InitializeComponent();
            player.URL = "Rewind Kid - Eyes on the Prize.mp3";
        
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmjeu fj = new frmjeu();
            fj.RestartGame();
            fj.gameTimer.Interval = 70;
            player.controls.stop();
            fj.nomniv = " Niveau Facile";
            fj.Show();
       
        }

        private void btnMoyen_Click(object sender, EventArgs e)
        {
            frmjeu fj = new frmjeu();
            fj.RestartGame();
            fj.gameTimer.Interval = 50;
            player.controls.stop();
            fj.nomniv = " Niveau Moyen";
            fj.Show();
            
        }

        private void btnDifficile_Click(object sender, EventArgs e)
        {

            frmjeu fj = new frmjeu();
            fj.RestartGame();
            fj.gameTimer.Interval = 40;
            player.controls.stop();
            fj.nomniv = " Niveau Difficile";
            fj.Show();
        }

        private void Niveau_Load(object sender, EventArgs e)
        {
          
                player.controls.play();
           
        }



      
    }
}
