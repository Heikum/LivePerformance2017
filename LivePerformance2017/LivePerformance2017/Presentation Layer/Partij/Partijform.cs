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
using LivePerformance2017.Models;
using LivePerformance2017.Models.Repositorys;
using LivePerformance2017.Presentation_Layer.Partij;

namespace LivePerformance2017.Presentation_Layer
{
    public partial class Partijform : Form
    {
        private PartijRepository repo = new PartijRepository(new PartijSQLContext());
        public Models.Partij geselecteerdewijzigpartij { get; set; }
        public Partijform()
        {
            InitializeComponent();
            RefreshListbox();
        }

        private void addpartijbutton_Click(object sender, EventArgs e)
        {
            AddPartijform addform = new AddPartijform();
            addform.Show();

        }

        public void RefreshListbox()
        {
            lbpartijen.DataSource = null; 
            List<Models.Partij> partijlist = repo.GetAllPartijen();
            lbpartijen.DataSource = partijlist;
        }

        private void verwijderpartijbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Models.Partij geselecteerdepartij = (Models.Partij)lbpartijen.SelectedItem;
                DialogResult dialogResult = MessageBox.Show("Weet u het zeker?", "Verwijder partij", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    repo.VerwijderPartij(geselecteerdepartij);
                    RefreshListbox();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Er is een fout opgetreden: " + error);
            }
        }

        private void wijizigpartijbutton_Click(object sender, EventArgs e)
        {
            geselecteerdewijzigpartij = (Models.Partij)lbpartijen.SelectedItem;
            Wijzigpartijform wijzigform = new Wijzigpartijform();
            if (geselecteerdewijzigpartij == null)
            {
                MessageBox.Show("Selecteer eerst een partij.");
            }
            else
            {
                wijzigform.Show();
            }
        }
    }
}
