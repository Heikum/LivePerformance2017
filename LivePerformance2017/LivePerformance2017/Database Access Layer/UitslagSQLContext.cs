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
    public class UitslagSQLContext
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
                //nog een query om het aantal stemmen meteen te inserten, misschien door een trigger zetels berekenen? 
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

