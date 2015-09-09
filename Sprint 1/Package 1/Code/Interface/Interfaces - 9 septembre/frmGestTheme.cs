using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jesuistanne
{
    public partial class frmGestTheme : Form
    {
        public frmGestTheme()
        {
            InitializeComponent();
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
            column.Width = 30;
        }
    }
}
