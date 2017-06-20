using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance2017.Models
{
    class Uitslag
    {

        private string Naam;
        private DateTime datum;
        private int ZetelAantal;
        private int AantalStemmen;

        public Uitslag(string naam, DateTime datum, int zetelAantal, int aantalStemmen)
        {
            Naam = naam;
            this.datum = datum;
            ZetelAantal = zetelAantal;
            AantalStemmen = aantalStemmen;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
