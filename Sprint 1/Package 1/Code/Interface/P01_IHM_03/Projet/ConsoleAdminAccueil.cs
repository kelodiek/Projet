using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet
{
    public partial class ConsoleAdminAccueil : frmGestion
    {
        public ConsoleAdminAccueil()
        {
            InitializeComponent();
            this.btnRecherche.Visible = false;
            this.btnSupprimer.Visible = false;
            this.btnDetails.Visible = false;
            this.btnAjout.Visible = false;
            //this.txtRecherche.visible = false;
        }

    }
}
