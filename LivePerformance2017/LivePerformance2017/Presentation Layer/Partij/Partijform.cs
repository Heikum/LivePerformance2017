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

namespace LivePerformance2017.Presentation_Layer
{
    public partial class Partijform : Form
    {
        private PartijRepository repo = new PartijRepository(new PartijSQLContext());
        public Partijform()
        {
            InitializeComponent();
            List<Models.Partij> partijlist = repo.GetAllPartijen();
            lbpartijen.DataSource = partijlist;
        }

        private void addpartijbutton_Click(object sender, EventArgs e)
        {
            

        }
    }
}
