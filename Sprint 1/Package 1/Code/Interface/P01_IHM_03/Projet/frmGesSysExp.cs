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
    public partial class frmGesSysExp : frmGestion
    {
        public frmGesSysExp()
        {
            InitializeComponent();
            
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmDetOS form = new frmDetOS();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConsoleAdminAccueil form = new ConsoleAdminAccueil();
            this.Hide();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
