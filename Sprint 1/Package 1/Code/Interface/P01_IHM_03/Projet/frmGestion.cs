using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Note a Oli #1:
// Oublie pas de faire les rapport pour chaque truc de gestion de donnees.


// Interface de base pour toutes le fenetre
// de Gestion dans la l'administration des donnees.
namespace Projet
{
    public partial class frmGestion : Form
    {
        public frmGestion()
        {
            InitializeComponent();
        }

        private void btnSysExpToolStrip_Click(object sender, EventArgs e)
        {

        }
        private void donneesToolStrip_Click(object sender, EventArgs e)
        {
            var F = new Form();
            var B = (ToolStripMenuItem)sender;

            if (B == btnSysExpToolStrip)
            {
                this.Hide();
                F = new frmGesSysExp();
                F.Show();
            }
            if (B == btnPlateToolStrip)
            {
                this.Hide();
                F = new frmGesPlateforme();
                F.Show();
            }
            F.Closed += (s, args) => this.Close();

        }
    }
}
