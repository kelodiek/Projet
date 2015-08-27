using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototypesInterfaces
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
            PopupOS form = new PopupOS();
            this.Hide();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
