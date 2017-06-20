using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance2017.Models
{
    class Partij
    {

        private string Naam;
        private string Beschrijving;
        private string Lijsttrekker;
        private int Stemmen;
        private int Zetels; 

        public Partij(string naam, string beschrijving, string lijsttrekker, int stemmen)
        {
            Naam = naam;
            Beschrijving = beschrijving;
            Lijsttrekker = lijsttrekker;
            Stemmen = stemmen;
        }

        public int BerekenZetels()
        {
            return 0; 
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
