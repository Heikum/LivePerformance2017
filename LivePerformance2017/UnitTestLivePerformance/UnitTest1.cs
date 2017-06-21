using System;
using System.Collections.Generic;
using System.Linq;
using LivePerformance2017.Database_Access_Layer;
using LivePerformance2017.Models;
using LivePerformance2017.Models.Repositorys;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLivePerformance
{
    [TestClass]
    public class PartijSQLContextTests
    {
        PartijRepository repository = new PartijRepository(new PartijSQLContextTest());

        [TestMethod()]
        public void GetAllTest()
        {
            List<Partij> list = repository.GetAllPartijen();
            Assert.AreEqual("VVD", list[0].Naam1);
            Assert.AreEqual("Geert Wilders", list[1].Lijsttrekker1);
            Assert.AreEqual("GroenLinks", list[2].VolledigeNaam1);

        }

        [TestMethod()]
        public void InsertTest()
        {
            Partij s = new Partij("SP", "Socialistische Partij", "Rood", "Emile Roemer");
            repository.CreatePartij(s);
            Assert.AreSame(s, repository.GetAllPartijen()[3]);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            Partij s = new Partij("SP", "Socialistische Partij", "Rood", "Emile Roemer");
            repository.VerwijderPartij(s);
            Assert.IsFalse(repository.GetAllPartijen().Any(x => x.PartijId == 1));
        }

        [TestMethod()]
        public void UpdateSpecificatieTest()
        {
            Partij s = repository.GetAllPartijen()[1];
            s.Naam1 = "PVV";
            repository.WijzigPartij(2, s);
            Assert.AreEqual("PVV", repository.GetAllPartijen()[1].Naam1);
        }

        private class PartijSQLContextTest : IPartijSQLContext
        {
            private List<Partij> Partijen;

            public PartijSQLContextTest()
            {
                Partijen = new List<Partij>()
                {
                    new Partij("VVD", "Verenigde Verbonden Democraten", "Blauw", "Mark Rutte"),
                    new Partij("PVV", "Partij voor de Vrijheid", "Blauw", "Geert Wilders"),
                    new Partij("GL", "GroenLinks", "Groen", "Jesse Klaver")
                };
            }

            public List<Partij> GetAllPartijen()
            {
                return Partijen;
            }

            public bool CreatePartij(Partij partij)
            {
                Partijen.Add(partij);
                return true;
            }

            public bool VerwijderPartij(Partij partij)
            {
                Partijen.RemoveAll(x => x.PartijId == partij.PartijId);
                return true;
            }

            public bool WijzigPartij(int id, Partij partij)
            {
                Partijen[1] = partij;
                return true;
            }

            public List<Partij> GetAllPartijenvoorUitslag(int id)
            {
                throw new NotImplementedException();
            }

            public int GetStemmen(int uitslagID, Partij partij)
            {
                throw new NotImplementedException();
            }



        }
    }
}
