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
        private void donneesToolStrip_Click(object sender, EventArgs e)
        {
            var F = new Form();
            string B = ((ToolStripMenuItem)sender).Name;

            switch (B)
            {
                case "btnSysExpToolStrip":
                    F = new frmGesSysExp(); 
                    break;
                case "btnPlateToolStrip":
                    F = new frmGesPlateforme();
                    break;
                case "btnJeuToolStrip":
                    F = new frmGesJeu();
                    break;
                default:
                    break;
            }
            this.Hide();
            F.Show();
            F.Closed += (s, args) => this.Close();

        }

        private void btnQuitterToolStrip_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
