using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivePerformance2017.Database_Access_Layer;
using LivePerformance2017.Models;
using LivePerformance2017.Models.Repositorys;

namespace LivePerformance2017.Presentation_Layer
{
    public partial class Coalitieform : Form
    {
        private CoalitieRepository crepo = new CoalitieRepository(new CoalitieSQLContext());
        private  PartijRepository prepo = new PartijRepository(new PartijSQLContext());
        private  UitslagRepository urepo = new UitslagRepository(new UitslagSQLContext());

        public Coalitieform()
        {
            InitializeComponent();
            if (Database.Connection != null && Database.Connection.State == ConnectionState.Closed)
            {
                MessageBox.Show("U bent niet verbonden met de database"); 
            }
            else
            {
                lbverkiezingen.DataSource = urepo.GetAllUitslagen();
            }
            
        }

        public string GetPremier(List<Models.Partij> partijlist)
        {
            Models.Partij partijpremier = partijlist.OrderBy(item => item.Zetels1).First();
            return partijpremier.Lijsttrekker1; 
        }
        //Update listboxes zodra er verandering is op geklikte item
        private void lbverkiezingen_SelectedIndexChanged(object sender, EventArgs e)
        {
            Uitslag selecteduitslag = (Uitslag)lbverkiezingen.SelectedItem;
            lbcoalitie.DataSource = crepo.GetSpecificCoalities(selecteduitslag.UitslagId);
            checkedlbpartijen.DataSource = prepo.GetAllPartijenvoorUitslag(selecteduitslag.UitslagId);
        }
        //Update listboxes zodra er verandering is op geklikte item
        private void lbcoalitie_SelectedIndexChanged(object sender, EventArgs e)
        {
            Coalitie selectedcoalitie = (Coalitie)lbcoalitie.SelectedItem;
            lbpartijen.DataSource = crepo.GetCoalitiePartijen(selectedcoalitie.CoalitieId);

        }

        private void button2_Click(object sender, EventArgs e)
        {
             
        }

        //Maakt coalitie aan in database
        private void btmaakcoalitie_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbverkiezingen.SelectedItem == null)
                {
                    MessageBox.Show("Selecteer een verkiezing");
                }
                else
                {
                    Uitslag selecteduitslag = (Uitslag)lbverkiezingen.SelectedItem;
                    List<Models.Partij> gekozenpartijlist = new List<Models.Partij>();
                    foreach (Models.Partij partij in checkedlbpartijen.CheckedItems)
                    {
                        gekozenpartijlist.Add(partij);
                    }

                    tbpremier.Text = GetPremier(gekozenpartijlist);
                    Coalitie coalitie = new Coalitie(selecteduitslag.UitslagId, tbcoalitie.Text, tbpremier.Text, Convert.ToInt32(updownzetels.Value));
                    crepo.CreateCoalitie(coalitie);

                    int coalitieid = crepo.GetCoalitieId(tbcoalitie.Text, selecteduitslag.UitslagId);
                    foreach (Models.Partij partij in gekozenpartijlist)
                    {
                        crepo.CreateCoalitieMetPartij(partij, coalitieid);
                    }

                     
                }
                
            }
            catch (Exception exception)
            {
                MessageBox.Show("Er is een fout opgetreden: " + exception); 
            }
        }
        //Exporteert de coalitie naar een .txt bestand op de gekozen locatie 
        private void exportbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Uitdraai uitdraai = new Uitdraai();
                Coalitie coalitie = (Coalitie)lbcoalitie.SelectedItem;
                coalitie.Partijlijst1 = crepo.GetCoalitiePartijen(coalitie.CoalitieId);
                uitdraai.ExporteerCoalitie((Coalitie)lbcoalitie.SelectedItem, "ee");

                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Title = "Save Text File";
                saveDialog.Filter = "TXT files|*.txt";
                saveDialog.InitialDirectory = @"C:\";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    uitdraai.ExporteerCoalitie(coalitie, saveDialog.FileName);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Er is een fout opgetreden: " + exception); 
            }
           
        }
    }
}
