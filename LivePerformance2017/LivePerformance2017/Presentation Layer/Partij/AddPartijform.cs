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
    public partial class AddPartijform : Form
    {
        private PartijRepository repo = new PartijRepository(new PartijSQLContext());
        public AddPartijform()
        {
            InitializeComponent();
        }

        private void addpartijbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Models.Partij partij = new Models.Partij(tbpartijnaam.Text, tbvolledigepartijnaam.Text, tbpartijkleur.Text, tbpartijlijsttrekker.Text);
                if (tbpartijnaam.Text == "" || tbpartijkleur.Text ==
                                            "" || tbpartijlijsttrekker.Text == "" || tbvolledigepartijnaam.Text == "")
                {
                    MessageBox.Show("U heeft niet alle velden ingevuld.");
                }
                else
                {
                    if (repo.CreatePartij(partij))
                    {
                        MessageBox.Show("Partij toegevoegd!");
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Er is een fout opgetreden: " + error);
            }
        }
    }
}
