using System.Collections.Generic;
using LivePerformance2017.Models;

namespace LivePerformance2017.Database_Access_Layer
{
    public interface ICoalitieSQLContext
    {
        List<Coalitie> GetAllCoalities();
        bool CreateCoalitie(Coalitie coalitie);
        bool VerwijderCoalitie(Coalitie coalitie);
        List<Partij> GetCoalitiePartijen(int coalitieid);
         List<Coalitie> GetSpecificCoalities(int uitslagid);
        bool CreateCoalitieMetPartij(Partij partij, int id);

        int GetCoalitieId(string naam, int uitslagID); 
    }
}