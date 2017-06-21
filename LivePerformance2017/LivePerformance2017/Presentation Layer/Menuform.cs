using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivePerformance2017.Presentation_Layer;

namespace LivePerformance2017
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void partijbutton_Click(object sender, EventArgs e)
        {
            Partijform prtform = new Partijform();
            prtform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void verkiezingbutton_Click(object sender, EventArgs e)
        {
            Verkiezingform vform = new Verkiezingform();
            vform.Show(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Coalitieform cform = new Coalitieform();
            cform.Show();
        }
    }
}
