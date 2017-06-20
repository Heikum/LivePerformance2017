using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance2017.Models
{
    public class Coalitie
    {
        private int CoalitieID;

        private string Naam;
        private string Premier;
        private List<Partij> Partijlijst;
        private int UitslagID;
        private int Zetels;

        public int Zetels1 => Zetels;

        public int CoalitieId => CoalitieID;
        public string Naam1 => Naam;
        public int UitslagId => UitslagID;
        public string Premier1 => Premier;
        public List<Partij> Partijlijst1
        {
            get { return Partijlijst; }
            set { Partijlijst = value; }
        }

        public Coalitie(int uitslagID, string naam, string premier, List<Partij> partijlijst, int zetels)
        {
            UitslagID = uitslagID; 
            Naam = naam;
            Premier = premier;
            Partijlijst = partijlijst;
            Zetels = zetels; 
        }

        public Coalitie(int coalitieID, int uitslagID, string naam, string premier, List<Partij> partijlijst, int zetels)
        {
            CoalitieID = coalitieID; 
            UitslagID = uitslagID;
            Naam = naam;
            Premier = premier;
            Partijlijst = partijlijst;
            Zetels = zetels;
        }

        public Coalitie(int coalitieID, int uitslagID, string naam, string premier, int zetels)
        {
            CoalitieID = coalitieID;
            UitslagID = uitslagID;
            Naam = naam;
            Premier = premier;
            Zetels = zetels;
        }

        public int Checkmeerderheid()
        {
            return 0; 
        }

        public string BepaalPremier()
        {
            return ""; 
        }

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
