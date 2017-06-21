using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance2017.Models;

namespace LivePerformance2017.Database_Access_Layer
{
    public class PartijSQLContext : IPartijSQLContext
    {
        public List<Partij> GetAllPartijen()
        {

            List<Partij> collectie = new List<Partij>();
            using (SqlConnection connectie = Database.Connection)
            {
                SqlCommand cmd = new SqlCommand("select * from Partij", connectie);
                cmd.ExecuteNonQuery();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        collectie.Add(CreatePartijFromReader(reader));
                    }
                }
            }
            return collectie;
        }

        public bool CreatePartij(Partij partij)
        {
            using (SqlConnection connectie = Database.Connection)
            {
                SqlCommand cmd1 =
                    new SqlCommand("INSERT INTO Partij (Naam, Kleur, Lijsttrekker, VolledigeNaam) values (@Naam, @Kleur, @Lijsttrekker, @VolledigeNaam); ",
                        connectie);
                cmd1.CommandType = CommandType.Text;
                cmd1.Connection = connectie;
                cmd1.Parameters.AddWithValue("@Naam", partij.Naam1);
                cmd1.Parameters.AddWithValue("@Kleur", partij.Kleur1);
                cmd1.Parameters.AddWithValue("@Lijsttrekker", partij.Lijsttrekker1);
                cmd1.Parameters.AddWithValue("@VolledigeNaam", partij.VolledigeNaam1);
                cmd1.ExecuteNonQuery();
                return true;
            }
        }
        //Cascade? 
        public bool VerwijderPartij(Partij partij)
        {
            using (SqlConnection connectie = Database.Connection)
            {
                SqlCommand cmd1 =
                    new SqlCommand("EXECUTE Deletepartij @ID = @IDD; ",
                        connectie);
                cmd1.CommandType = CommandType.Text;
                cmd1.Connection = connectie;
                cmd1.Parameters.AddWithValue("@IDD", partij.PartijId);
                cmd1.ExecuteNonQuery();
                return true;
            }
        }

        public bool WijzigPartij(int id, Partij partij)
        {
            using (SqlConnection connectie = Database.Connection)
            {
                SqlCommand cmd1 =
                    new SqlCommand(
                        @"UPDATE Partij SET [Naam] = @voornaam, [VolledigeNaam] = @VolledigeNaam, [Kleur] = @Kleur, [Lijsttrekker] = @Lijsttrekker  WHERE Person_ID = @id",
                        connectie);
                cmd1.CommandType = CommandType.Text;
                cmd1.Connection = connectie;
                cmd1.Parameters.AddWithValue("@id", id);
                cmd1.Parameters.AddWithValue("@Naam", partij.Naam1);
                cmd1.Parameters.AddWithValue("@VolledigeNaam", partij.VolledigeNaam1);
                cmd1.Parameters.AddWithValue("@Kleur", partij.Kleur1);
                cmd1.Parameters.AddWithValue("@Lijsttrekker", partij.Lijsttrekker1);
                cmd1.ExecuteNonQuery();
                return true;
            }
        }

        public int GetStemmen(int uitslagID, Partij partij)
        {
            using (SqlConnection connectie = Database.Connection)
            {
                SqlCommand cmd1 =
                    new SqlCommand(
                        @"select Stemmen from Stemmen where Partij_ID = @PartijID AND Uitslag_ID = @ID",
                        connectie);
                cmd1.CommandType = CommandType.Text;
                cmd1.Connection = connectie;
                cmd1.Parameters.AddWithValue("@ID", uitslagID);
                cmd1.Parameters.AddWithValue("@PartijID", partij.PartijId);
                int result = Convert.ToInt32(cmd1.ExecuteScalar());
                return result;
            }
        }


        public List<Partij> GetAllPartijenvoorUitslag(int id)
        {
            List<Partij> collectie = new List<Partij>();
            using (SqlConnection connectie = Database.Connection)
            {
                SqlCommand cmd = new SqlCommand("select * from Stemmen inner join Partij on Partij_ID = Partij.ID where Uitslag_ID = @ID", connectie);
                cmd.Parameters.AddWithValue("@id", id);
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

        public Partij CreatePartijFromReader(SqlDataReader reader)
        {
            return new Partij(
                Convert.ToInt32(reader["ID"]),
                Convert.ToString(reader["Naam"]),  
                Convert.ToString(reader["VolledigeNaam"]),
                Convert.ToString(reader["Kleur"]),
                Convert.ToString(reader["Lijsttrekker"]));
        }

        public Partij CreatePartijMetStemmenFromReader(SqlDataReader reader)
        {
            return new Partij(
                Convert.ToInt32(reader["ID"]),
                Convert.ToString(reader["Naam"]),
                Convert.ToString(reader["VolledigeNaam"]),
                Convert.ToString(reader["Kleur"]),
                Convert.ToString(reader["Lijsttrekker"]),
            Convert.ToInt32(reader["Stemmen"]),
            Convert.ToInt32(reader["Zetels"]));
        }
    }
}
