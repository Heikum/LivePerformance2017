using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance2017.Models
{
    public class Uitslag
    {
        

        private string Naam;
        private DateTime datum;
        private int ZetelAantal;
        private int AantalStemmen;
        private int UitslagID;

        public int UitslagId => UitslagID;

        public string Naam1 => Naam;

        public DateTime Datum => datum;

        public int ZetelAantal1 => ZetelAantal;

        public int AantalStemmen1 => AantalStemmen;


        public Uitslag(string naam, DateTime datum, int zetelAantal, int aantalStemmen)
        {
            Naam = naam;
            this.datum = datum;
            ZetelAantal = zetelAantal;
            AantalStemmen = aantalStemmen;
        }

        public Uitslag(int uitslagid, string naam, int aantalStemmen, DateTime datum, int zetelAantal)
        {
            UitslagID = uitslagid; 
            Naam = naam;
            this.datum = datum;
            ZetelAantal = zetelAantal;
            AantalStemmen = aantalStemmen;
        }

        public override string ToString()
        {
            return "Naam: " + Naam + ", Aantal zetels: " + ZetelAantal; 
        }
    }
}
