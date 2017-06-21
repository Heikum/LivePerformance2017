using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance2017.Models
{
    public class Partij
    {
        private int PartijID;
        private string Naam;
        private string VolledigeNaam;
        private string Kleur;
        private string Lijsttrekker;
        private int Stemmen;
        private int Zetels;

        public int Stemmen1
        {
            get { return Stemmen; }
            set { Stemmen = value; }
        }

        public int Zetels1
        {
            get { return Zetels; }
            set { Zetels = value; }
        }

        public int PartijId => PartijID;

        public string Naam1 => Naam;

        public string VolledigeNaam1 => VolledigeNaam;

        public string Kleur1 => Kleur;

        public string Lijsttrekker1 => Lijsttrekker;

        public Partij(int partijID, string naam, string volledigenaam, string kleur, string lijsttrekker)
        {
            PartijID = partijID; 
            Naam = naam;
            VolledigeNaam = volledigenaam;
            Kleur = kleur; 
            Lijsttrekker = lijsttrekker;
        }

        public Partij(int partijID, string naam, string volledigenaam, string kleur, string lijsttrekker, int stemmen, int zetels)
        {
            PartijID = partijID;
            Naam = naam;
            VolledigeNaam = volledigenaam;
            Kleur = kleur;
            Lijsttrekker = lijsttrekker;
            this.Stemmen = stemmen;
            Zetels = zetels; 
        }

        public Partij(string naam, string volledigenaam, string kleur, string lijsttrekker)
        {
            Naam = naam;
            VolledigeNaam = volledigenaam;
            Kleur = kleur;
            Lijsttrekker = lijsttrekker;
        }


        public override string ToString()
        {
            return "Naam: " + Naam + ", Lijsttrekker: " + Lijsttrekker + ", Stemmen: " + Stemmen + ", Zetels: " + Zetels; 
        }
    }
}
