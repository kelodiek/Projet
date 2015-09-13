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
    public partial class frmGestTheme : frmGestion
    {
        public frmGestTheme()
        {
            InitializeComponent();
            btnAjout.Click += new EventHandler(ajoutTheme_Click);
            btnDetails.Click += new EventHandler(detailTheme_Click);
        }

        private void GridTheme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewColumn column;
            GridTheme.Columns.Add("IdTheme", "ID");
            GridTheme.Columns.Add("CodeTheme", "Code");
            GridTheme.Columns.Add("NomTheme", "Nom");

            DataGridViewRow row = GridTheme.Rows[0];
            row.Height = 30;

            column = GridTheme.Columns[0];
            column.Width = 10;
            column = GridTheme.Columns[1];
            column.Width = 30;
            column = GridTheme.Columns[2];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void ajoutTheme_Click(object sender, EventArgs e)
        {
            var frmDetails = new frmDetTheme();

            frmDetails.modifierChamp("a");

            frmDetails.Show();
        }
        private void detailTheme_Click(object sender, EventArgs e)
        {
            var frmDetails = new frmDetTheme();

            frmDetails.modifierChamp("m");

            frmDetails.Show();
        }
    }
}
