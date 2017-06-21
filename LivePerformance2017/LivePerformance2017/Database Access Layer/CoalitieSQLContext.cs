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
    public class CoalitieSQLContext : ICoalitieSQLContext
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

        public List<Coalitie> GetSpecificCoalities(int uitslagid)
        {
            List<Coalitie> collectie = new List<Coalitie>();
            using (SqlConnection connectie = Database.Connection)
            {
                SqlCommand cmd = new SqlCommand("select * from Coalitie where Uitslag_ID = @ID; ", connectie);
                cmd.Parameters.AddWithValue("@ID", uitslagid);
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

        public int GetCoalitieId(string naam, int uitslagID)
        {
            using (SqlConnection connectie = Database.Connection)
            {
                SqlCommand cmd1 =
                    new SqlCommand("select * from Coalitie where Naam = @Naam and Uitslag_ID = @UitslagID ",
                        connectie);
                cmd1.CommandType = CommandType.Text;
                cmd1.Connection = connectie;
                cmd1.Parameters.AddWithValue("@Naam", naam);
                cmd1.Parameters.AddWithValue("@UitslagID", uitslagID);
                int result = (int)cmd1.ExecuteScalar();
                return result;
            }
        }

        public bool CreateCoalitieMetPartij(Partij partij, int id)
        {
            using (SqlConnection connectie = Database.Connection)
            {
                SqlCommand cmd1 =
                    new SqlCommand("INSERT INTO Coalitie_Koppel (Coalitie_ID, Partij_ID) values (@Coalitie_ID, @Partij_ID)",
                        connectie);
                cmd1.CommandType = CommandType.Text;
                cmd1.Connection = connectie;
                cmd1.Parameters.AddWithValue("@Coalitie_ID", id );
                cmd1.Parameters.AddWithValue("@Partij_ID",  partij.PartijId);
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

        public List<Partij> GetCoalitiePartijen(int coalitieid)
        {
            List<Partij> collectie = new List<Partij>();
            using (SqlConnection connectie = Database.Connection)
            {
                SqlCommand cmd = new SqlCommand("select * from Coalitie_Koppel inner join Partij on Partij_ID = Partij.ID where Partij_ID = @ID", connectie);
                cmd.Parameters.AddWithValue("@ID", coalitieid);
                cmd.ExecuteNonQuery();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        collectie.Add(CreatePartijMetStemmenFromReader(reader));
                    }
                }
            }
            return collectie;
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

        public Partij CreatePartijMetStemmenFromReader(SqlDataReader reader)
        {
            return new Partij(
                Convert.ToInt32(reader["ID"]),
                Convert.ToString(reader["Naam"]),
                Convert.ToString(reader["VolledigeNaam"]),
                Convert.ToString(reader["Kleur"]),
                Convert.ToString(reader["Lijsttrekker"]));
        }


    }
}
