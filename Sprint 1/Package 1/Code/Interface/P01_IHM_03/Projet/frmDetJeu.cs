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
    public partial class frmDetJeu : frmDetail
    {
        public frmDetJeu()
        {
            InitializeComponent();
        }

        private void btnAjoutGenre_Click(object sender, EventArgs e)
        {
            frmSelection f = new frmSelection();
            f.Show();
        }
    }
}
