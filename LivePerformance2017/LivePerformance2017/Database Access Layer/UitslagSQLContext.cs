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
    public class UitslagSQLContext : IUitslagSQLContext
    {



        public List<Uitslag> GetAllUitslagen()
        {
            List<Uitslag> collectie = new List<Uitslag>();
            using (SqlConnection connectie = Database.Connection)
            {
                SqlCommand cmd = new SqlCommand("select * from Uitslag", connectie);
                cmd.ExecuteNonQuery();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        collectie.Add(CreateUitslagFromReader(reader));
                    }
                }
            }
            return collectie;
        }

        public int TotaalAantalStemmen(int uitslagid)
        {
            using (SqlConnection connectie = Database.Connection)
            {
                SqlCommand cmd1 =
                    new SqlCommand(
                        @"select sum(Stemmen) as AantalStemmen from Stemmen where Uitslag_ID = @ID ",
                        connectie);
                cmd1.CommandType = CommandType.Text;
                cmd1.Connection = connectie;
                cmd1.Parameters.AddWithValue("@ID", uitslagid);
                int result = Convert.ToInt32(cmd1.ExecuteScalar());
                return result;
            }
        }

        public int TotaalZetelAantal(int uitslagid)
        {
            using (SqlConnection connectie = Database.Connection)
            {
                SqlCommand cmd1 =
                    new SqlCommand(
                        @"select AantalZetels from Uitslag where ID = @ID; ",
                        connectie);
                cmd1.CommandType = CommandType.Text;
                cmd1.Connection = connectie;
                cmd1.Parameters.AddWithValue("@ID", uitslagid);
                int result = Convert.ToInt32(cmd1.ExecuteScalar());
                return result;
            }
        }

        public bool CreateUitslag(Uitslag uitslag)
        {
            using (SqlConnection connectie = Database.Connection)
            {
                SqlCommand cmd1 =
                    new SqlCommand("INSERT INTO Uitslag (Naam, AantalStemmen, Datum, AantalZetels) values (@Naam, @AantalStemmen, @Datum, @AantalZetels)",
                        connectie);
                cmd1.CommandType = CommandType.Text;
                cmd1.Connection = connectie;
                cmd1.Parameters.AddWithValue("@Naam", uitslag.Naam1);
                cmd1.Parameters.AddWithValue("@AantalStemmen", uitslag.AantalStemmen1);
                cmd1.Parameters.AddWithValue("@Datum", uitslag.Datum);
                cmd1.Parameters.AddWithValue("@AantalZetels", uitslag.ZetelAantal1);
                cmd1.ExecuteNonQuery();
                return true;
            }
        }

        public bool InsertStemmen(int uitslagID, Partij partij)
        {
            using (SqlConnection connectie = Database.Connection)
            {
                SqlCommand cmd1 =
                    new SqlCommand("INSERT INTO Stemmen (Uitslag_ID, Partij_ID, Stemmen) values (@Uitslag_ID, @Partij_ID, @Stemmen)",
                        connectie);
                cmd1.CommandType = CommandType.Text;
                cmd1.Connection = connectie;
                cmd1.Parameters.AddWithValue("@Uitslag_ID", uitslagID);
                cmd1.Parameters.AddWithValue("@Partij_ID", partij.PartijId);
                cmd1.Parameters.AddWithValue("@Stemmen", partij.Stemmen1);
                cmd1.ExecuteNonQuery();
                return true;
            }
        }

        public bool InsertZetels(int uitslagID, Partij partij)
        {
            using (SqlConnection connectie = Database.Connection)
            {
                SqlCommand cmd1 =
                    new SqlCommand("INSERT INTO Stemmen (Zetels) values (@Zetels) where ID = @ID",
                        connectie);
                cmd1.CommandType = CommandType.Text;
                cmd1.Connection = connectie;
                cmd1.Parameters.AddWithValue("@Zetels", partij.Zetels1);
                cmd1.Parameters.AddWithValue("@ID", uitslagID);
                //nog para voor percentage 
                cmd1.ExecuteNonQuery();
                return true;
            }
        }

        public bool VerwijderUitslag(int id)
        {
            using (SqlConnection connectie = Database.Connection)
            {
                SqlCommand cmd1 =
                    new SqlCommand("Delete FROM Uitslag where ID = @ID",
                        connectie);
                cmd1.CommandType = CommandType.Text;
                cmd1.Connection = connectie;
                cmd1.Parameters.AddWithValue("@ID", id);
                cmd1.ExecuteNonQuery();
                return true;
            }
        }

        public bool WijzigUitslag(int id, Uitslag uitslag)
        {
            using (SqlConnection connectie = Database.Connection)
            {
                SqlCommand cmd1 =
                    new SqlCommand(
                        @"UPDATE Uitslag SET [Naam] = @Naam, [AantalStemmen] = @AantalStemmen, [Datum] = @Datum, [AantalZetels] = @AantalZetels  WHERE ID = @id",
                        connectie);
                cmd1.CommandType = CommandType.Text;
                cmd1.Connection = connectie;
                cmd1.Parameters.AddWithValue("@id", id);
                cmd1.Parameters.AddWithValue("@Naam", uitslag.Naam1);
                cmd1.Parameters.AddWithValue("@AantalStemmen", uitslag.AantalStemmen1);
                cmd1.Parameters.AddWithValue("@Datum", uitslag.Datum);
                cmd1.Parameters.AddWithValue("@AantalZetels", uitslag.ZetelAantal1);
                cmd1.ExecuteNonQuery();
                return true;
            }
        }

        public Uitslag CreateUitslagFromReader(SqlDataReader reader)
        {
            return new Uitslag(
                Convert.ToInt32(reader["ID"]),
                Convert.ToString(reader["Naam"]),
                Convert.ToInt32(reader["AantalStemmen"]),
                Convert.ToDateTime(reader["Datum"]),
                Convert.ToInt32(reader["AantalZetels"]));
        }
    }
}

