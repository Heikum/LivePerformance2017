using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using LivePerformance2017.Models;

namespace LivePerformance2017.Database_Access_Layer
{
    public class CoalitieSQLContext
    {

        public List<Coalitie> GetAllCoalities()
        {
            List<Coalitie> collectie = new List<Coalitie>();
            using (SqlConnection connectie = Database.Connection)
            {
                SqlCommand cmd = new SqlCommand("select * from Coalitie", connectie);
                cmd.ExecuteNonQuery();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        collectie.Add(CreateCoalitieFromReader(reader));
                    }
                }
            }
            return collectie;
        }

        public bool CreateCoalitie(Coalitie coalitie)
        {
            using (SqlConnection connectie = Database.Connection)
            {
                SqlCommand cmd1 =
                    new SqlCommand("INSERT INTO Coalitie (Naam, Premier, Uitslag_ID, Zetels) values (@Naam, @Premier, @Uitslag_ID, @Zetels)",
                        connectie);
                cmd1.CommandType = CommandType.Text;
                cmd1.Connection = connectie;
                cmd1.Parameters.AddWithValue("@Naam", coalitie.Naam1);
                cmd1.Parameters.AddWithValue("@Premier", coalitie.Premier1);
                cmd1.Parameters.AddWithValue("@Uitslag_ID", coalitie.UitslagId);
                cmd1.Parameters.AddWithValue("@Zetels", coalitie.Zetels1);
                //nog een query om alle partijen in koppel tabel te pleuren 
                cmd1.ExecuteNonQuery();
                return true;
            }
        }
        // Cascade? 
        public bool VerwijderCoalitie(Coalitie coalitie)
        {
            using (SqlConnection connectie = Database.Connection)
            {
                SqlCommand cmd1 =
                    new SqlCommand("DELETE FROM Coalitie where ID = @ID",
                        connectie);
                cmd1.CommandType = CommandType.Text;
                cmd1.Connection = connectie;
                cmd1.Parameters.AddWithValue("@ID",  coalitie.CoalitieId);
                cmd1.ExecuteNonQuery();
                return true;
            }
        }

        public Coalitie CreateCoalitieFromReader(SqlDataReader reader)
        {
            return new Coalitie(
                Convert.ToInt32(reader["ID"]),
                Convert.ToInt32(reader["Uitslag_ID"]),
                Convert.ToString(reader["Naam"]),
                Convert.ToString(reader["Premier"]),
                Convert.ToInt32(reader["Zetels"]));
        }
    }
}
