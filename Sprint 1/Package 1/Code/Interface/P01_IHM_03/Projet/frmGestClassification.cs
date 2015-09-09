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
    public partial class frmGestClassification : Form
    {
        public frmGestClassification()
        {
            InitializeComponent();
        }

        private void GridClasification_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewColumn column;
            GridClassification.Columns.Add("CoteESRB", "Cote");
            GridClassification.Columns.Add("NomESRB", "Nom");
            GridClassification.Columns.Add("DescESRB", "Description");

            DataGridViewRow row = GridClassification.Rows[0];
            row.Height = 30;

            column = GridClassification.Columns[0];
            column.Width = 10;
            column = GridClassification.Columns[1];
            column.Width = 30;
            column = GridClassification.Columns[2];
            column.Width = 30;
        }

        private void btnAjoutClassification_Click(object sender, EventArgs e)
        {

        }

        private void GridClassification_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
