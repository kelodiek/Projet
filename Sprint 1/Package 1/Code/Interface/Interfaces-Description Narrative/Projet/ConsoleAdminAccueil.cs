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
    public partial class ConsoleAdminAccueil : Form
    {
        public ConsoleAdminAccueil()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void plateformeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Accueil form = new Accueil();
            this.Hide();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void systèmeDExploitationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmGesSysExp form = new frmGesSysExp();
            this.Hide();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void retourInterfaceTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Accueil form = new Accueil();
            this.Hide();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void plateformeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Gestion_des_Plateformes form = new Gestion_des_Plateformes();
            this.Hide();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
