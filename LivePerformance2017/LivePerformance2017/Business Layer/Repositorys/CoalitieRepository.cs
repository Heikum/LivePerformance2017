using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance2017.Database_Access_Layer;

namespace LivePerformance2017.Models.Repositorys
{
    class CoalitieRepository
    {
        private ICoalitieSQLContext context;

        public CoalitieRepository(ICoalitieSQLContext context)
        {
            this.context = context;
        }

        public List<Coalitie> GetAllCoalities()
        {
            return context.GetAllCoalities();
        }

        public bool CreateCoalitie(Coalitie coalitie)
        {
            return context.CreateCoalitie(coalitie);
        }

        public bool VerwijderCoalitie(Coalitie coalitie)
        {
            return context.VerwijderCoalitie(coalitie);
        }

        public List<Partij> GetCoalitiePartijen(int coalitieid)
        {
            return context.GetCoalitiePartijen(coalitieid); 
        }

        public List<Coalitie> GetSpecificCoalities(int uitslagid)
        {
            return context.GetSpecificCoalities(uitslagid); 
        }


        public bool CreateCoalitieMetPartij(Partij partij, int id)
        {
            return context.CreateCoalitieMetPartij(partij, id); 
        }

        public int GetCoalitieId(string naam, int uitslagID)
        {
            return context.GetCoalitieId(naam, uitslagID); 
        }


    }
}
