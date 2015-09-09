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
    public partial class frmGenre : Form
    {
        public frmGenre()
        {
            InitializeComponent();
        }

        private void GridGenre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewColumn column;
            GridGenre.Columns.Add("IdGenre", "ID");
            GridGenre.Columns.Add("CodeGenre", "Code");
            GridGenre.Columns.Add("NomGenre", "Nom");

            DataGridViewRow row = GridGenre.Rows[0];
            row.Height = 30;

            column = GridGenre.Columns[0];
            column.Width = 10;
            column = GridGenre.Columns[1];
            column.Width = 30;
            column = GridGenre.Columns[2];
            column.Width = 30;
        }
    }
}
