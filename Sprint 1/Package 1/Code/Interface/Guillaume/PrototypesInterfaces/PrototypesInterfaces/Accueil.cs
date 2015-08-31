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
    public partial class Accueil : Form
    {
        List<string> lstDispo;
        int Cpt;
        public Accueil()
        {
            InitializeComponent();
            lstDispo = new List<string>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Popup_Accueil form = new Popup_Accueil();
            form.Show();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            Cpt = 0;
            lstDispo.Add("NHL 16 - PS4");
            lstDispo.Add("Diablo 4 - PC");
            lstDispo.Add("Dead Rising 4 - PC");
            lstDispo.Add("Dofus - Xbox One");
            lstDispo.Add("CS : GO - PC");
            button8.Text = lstDispo[0];
            button7.Text = lstDispo[1];
            button6.Text = lstDispo[2];
            button5.Text = lstDispo[3];
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                Cpt++;
                button8.Text = lstDispo[0 + Cpt];
                button7.Text = lstDispo[1 + Cpt];
                button6.Text = lstDispo[2 + Cpt];
                button5.Text = lstDispo[3 + Cpt];
            }
            catch (ArgumentOutOfRangeException)
            {
                Cpt--;
                button8.Text = lstDispo[0 + Cpt];
                button7.Text = lstDispo[1 + Cpt];
                button6.Text = lstDispo[2 + Cpt];
                button5.Text = lstDispo[3 + Cpt];
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
                {
            Cpt--;
            button8.Text = lstDispo[0 + Cpt];
            button7.Text = lstDispo[1 + Cpt];
            button6.Text = lstDispo[2 + Cpt];
            button5.Text = lstDispo[3 + Cpt];
                }
            catch(ArgumentOutOfRangeException)
            {
                Cpt++;
                button8.Text = lstDispo[0 + Cpt];
                button7.Text = lstDispo[1 + Cpt];
                button6.Text = lstDispo[2 + Cpt];
                button5.Text = lstDispo[3 + Cpt];       
            }

        }
    }
}
