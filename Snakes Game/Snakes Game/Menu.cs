using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snakes_Game
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnParametre_Click(object sender, EventArgs e)
        {
          
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            txtInformation.Visible = true;
        }

        private void btnAide_Click(object sender, EventArgs e)
        {
            Aide ad = new Aide();
            ad.ShowDialog();
        }

        private void txtInformation_Click(object sender, EventArgs e)
        {
            txtInformation.Visible = false;
        }
    }
}
