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
    public partial class frmGesPlateforme : frmGestion
    {
        public frmGesPlateforme()
        {
            InitializeComponent();
        }

        private void Gestion_des_Plateformes_Load(object sender, EventArgs e)
        {
            DataGridViewColumn column;

            DataGridView1.Columns.Add("ID","ID");
            DataGridView1.Columns.Add("Code", "Code");
            DataGridView1.Columns.Add("Nom", "Nom");
            DataGridView1.Columns.Add("Categ", "Catégorie");
            DataGridView1.Columns.Add("OS", "OS");
            DataGridView1.Columns.Add("Desc", "Description");

            column = DataGridView1.Columns[0];
            column.Width = 50;
            column = DataGridView1.Columns[1];
            column.Width = 50;
            column = DataGridView1.Columns[2];
            column.Width = 150;
            column = DataGridView1.Columns[3];
            column.Width = 150;
            column = DataGridView1.Columns[5];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnAjoutPlateforme_Click(object sender, EventArgs e)
        {
            frmDetPlateforme form = new frmDetPlateforme();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAccueilAdmin form = new frmAccueilAdmin();
            this.Hide();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
