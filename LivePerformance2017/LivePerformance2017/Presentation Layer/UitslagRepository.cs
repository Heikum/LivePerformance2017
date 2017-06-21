using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance2017.Database_Access_Layer;

namespace LivePerformance2017.Models.Repositorys
{
    public class UitslagRepository
    {
        private IUitslagSQLContext context;

        public UitslagRepository(IUitslagSQLContext context)
        {
            this.context = context;
        }

        public List<Uitslag> GetAllUitslagen()
        {
            return context.GetAllUitslagen();
        }

        public bool CreateUitslag(Uitslag uitslag)
        {
            return context.CreateUitslag(uitslag);
        }

        public bool InsertStemmen(int uitslagID, Partij partij)
        {
            return context.InsertStemmen(uitslagID, partij); 
        }

        public bool VerwijderUitslag(int id)
        {
            return context.VerwijderUitslag(id);
        }

        public bool WijzigUitslag(int id, Uitslag uitslag)
        {
            return context.WijzigUitslag(id, uitslag);
        }

        public int TotaalAantalStemmen(int uitslagid)
        {
            return context.TotaalAantalStemmen(uitslagid); 
        }

        public int TotaalZetelAantal(int uitslagid)
        {
            return context.TotaalZetelAantal(uitslagid); 
        }

        public bool InsertZetels(int uitslagID, Partij partij)
        {
            return context.InsertZetels(uitslagID, partij); 
        }


    }
}
