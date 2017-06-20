using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance2017.Models
{
    class Coalitie
    {

        private string Naam;
        private string Premier;
        private List<Partij> Partijlijst;

        public Coalitie(string naam, string premier, List<Partij> partijlijst)
        {
            Naam = naam;
            Premier = premier;
            Partijlijst = partijlijst;
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
