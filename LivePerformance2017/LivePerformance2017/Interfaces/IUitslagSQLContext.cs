using System.Collections.Generic;
using LivePerformance2017.Models;

namespace LivePerformance2017.Database_Access_Layer
{
    public interface IUitslagSQLContext
    {
        List<Uitslag> GetAllUitslagen();
        bool CreateUitslag(Uitslag uitslag);
        bool InsertStemmen(int uitslagID, Partij partij);
        bool VerwijderUitslag(int id);
        bool WijzigUitslag(int id, Uitslag uitslag);
        int TotaalZetelAantal(int uitslagid);
        int TotaalAantalStemmen(int uitslagid);
        bool InsertZetels(int uitslagID, Partij partij);
    }
}