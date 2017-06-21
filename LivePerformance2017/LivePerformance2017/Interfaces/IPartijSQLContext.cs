using System.Collections.Generic;
using System.Data.SqlClient;
using LivePerformance2017.Models;

namespace LivePerformance2017.Database_Access_Layer
{
    public interface IPartijSQLContext
    {
        List<Partij> GetAllPartijen();
        bool CreatePartij(Partij partij);
        bool VerwijderPartij(Partij partij);
        bool WijzigPartij(int id, Partij partij);
        List<Partij> GetAllPartijenvoorUitslag(int id);
        int GetStemmen(int uitslagID, Partij partij);
    }
}