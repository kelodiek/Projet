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
    public partial class frmGesJeu : frmGestion
    {
        public frmGesJeu()
        {
            InitializeComponent();
        }

        private void frmGesJeu_Load(object sender, EventArgs e)
        {
            DataGridViewColumn Column;

            dataGridJeu.Columns.Add("Nom", "Nom");
            dataGridJeu.Columns.Add("Date", "Date de Sortie");
            dataGridJeu.Columns.Add("Genre", "Genres");
            dataGridJeu.Columns.Add("Theme", "Thème");
            dataGridJeu.Columns.Add("Mode", "Mode");

            Column = dataGridJeu.Columns[0];
            Column.Width = 50;
        }
    }
}
