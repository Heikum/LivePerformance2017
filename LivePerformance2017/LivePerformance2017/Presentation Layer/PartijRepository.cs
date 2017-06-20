using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance2017.Database_Access_Layer;

namespace LivePerformance2017.Models.Repositorys
{
    public class PartijRepository
    {
        private IPartijSQLContext context;

        public PartijRepository(IPartijSQLContext context)
        {
            this.context = context;
        }
        public List<Partij> GetAllPartijen()
        {
            return context.GetAllPartijen(); 
        }

        public bool CreatePartij(Partij partij)
        {
            return context.CreatePartij(partij); 
        }

        public bool VerwijderPartij(Partij partij)
        {
            return context.VerwijderPartij(partij); 
        }

        public bool WijzigPartij(int id, Partij partij)
        {
            return context.WijzigPartij(id, partij); 
        }

    }
}
