using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivePerformance2017.Database_Access_Layer;
using LivePerformance2017.Models.Repositorys;

namespace LivePerformance2017.Presentation_Layer.Partij
{
    public partial class Wijzigpartijform : Form
    {
        Partijform pform = (Partijform)Application.OpenForms["Partijform"];
        private Models.Partij selectedpartij;
        PartijRepository partijrepo = new PartijRepository(new PartijSQLContext());
        public Wijzigpartijform()
        {
            InitializeComponent();
            selectedpartij = pform.geselecteerdewijzigpartij;
            tbpartijnaam.Text = selectedpartij.Naam1;
            tbvolledigepartijnaam.Text = selectedpartij.VolledigeNaam1;
            tbpartijkleur.Text = selectedpartij.Kleur1;
            tbpartijlijsttrekker.Text = selectedpartij.Lijsttrekker1; 

        }

        private void wijzigpartijbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbpartijnaam.Text == "" || tbpartijkleur.Text ==
                    "" || tbpartijlijsttrekker.Text == "" || tbvolledigepartijnaam.Text == "")
                {
                    MessageBox.Show("U heeft niet alle velden ingevuld.");
                }
                else
                {
                    
                    Models.Partij editedpartij = new Models.Partij(tbpartijnaam.Text, tbvolledigepartijnaam.Text, tbpartijkleur.Text, tbpartijlijsttrekker.Text);
                    partijrepo.WijzigPartij(selectedpartij.PartijId, editedpartij);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Er is een fout opgetreden: " + error); 
            }

        }
    }
}
