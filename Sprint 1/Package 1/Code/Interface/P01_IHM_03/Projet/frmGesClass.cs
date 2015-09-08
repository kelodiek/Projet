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
    public partial class frmGesClass : frmGestion
    {
        public frmGesClass()
        {
            InitializeComponent();
        }

        private void frmGesClass_Load(object sender, EventArgs e)
        {
            DataGridViewColumn column;

            dataGridClass.Columns.Add("Code", "Code");
            dataGridClass.Columns.Add("Nom", "Nom");
            dataGridClass.Columns.Add("Desc", "Description");

            column = dataGridClass.Columns[0];
            column.Width = 75;
            column = dataGridClass.Columns[1];
            column.Width = 150;
            column = dataGridClass.Columns[2];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void frmGesClass_Click(object sender, EventArgs e)
        {

        }

    }
}
