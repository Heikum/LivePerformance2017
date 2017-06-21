using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivePerformance2017.Models
{
    public class Uitdraai
    {
        //Exporteert coalitie als een tekstbestand op de door de user ingegeven path 
        public void ExporteerCoalitie(Coalitie coalitie, string path)
        {
            List<string> lines = new List<string>();
            lines.Add("Coalitie voorstel tweede kamer");
            lines.Add("-------------------------------");
            lines.Add("Van: Tjeenk Willink");
            lines.Add("Aan: Z.M. Koning Willem-Alexander: Majesteit;");
            lines.Add("Partij \t\t Zetels \t\t Lijsttrekker");
            foreach (Partij partij in coalitie.Partijlijst1)
            {
                //totaalAantalZetels = totaalAantalZetels + partij.Zetels1;
                lines.Add(partij.Naam1 + "\t\t" + partij.Zetels1 + "\t\t" + partij.Lijsttrekker1);
            }
            lines.Add("===============================");
            lines.Add("Totaal \t\t" + Convert.ToString("4") + "\t\t" + coalitie.Premier1);
            try
            {
                File.WriteAllLines(path, lines);
                if (lines == null)
                {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
