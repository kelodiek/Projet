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
    public partial class frmGestVersion : Form
    {
        public frmGestVersion()
        {
            InitializeComponent();
        }

        private void GridVersion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewColumn column;
            GridVersion.Columns.Add("IdJeu","ID");
            GridVersion.Columns.Add("CodeVersion", "Code");
            GridVersion.Columns.Add("NomVersion", "Nom");
            GridVersion.Columns.Add("DescVersion", "Description de la Version");
            GridVersion.Columns.Add("StadeDeveloppement", "Stade");
            GridVersion.Columns.Add("DateVersion", "Date de la Version");
            GridVersion.Columns.Add("DateSortiePrevue", "Date de Sortie Prévue");

            DataGridViewRow row = GridVersion.Rows[0];
            row.Height = 30;

            column = GridVersion.Columns[0];
            column.Width = 10;
            column = GridVersion.Columns[2];
            column.Width = 30;
            column = GridVersion.Columns[5];
            column.Width = 30;
            column = GridVersion.Columns[6];
            column.Width = 50;
            column = GridVersion.Columns[7];
            column.Width = 50;
        
        }
    }
}
