﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LivePerformance2017.Database_Access_Layer
{
    public class Database
    {
        //private static readonly string connectionString = "Data Source=HICH-LAPTOP;Initial Catalog=LivePerformance;Integrated Security=True";
        private static readonly string connectionString = "Server=mssql.fhict.local;Database=dbi353348;User Id=dbi353348;Password=loler123;";
        public static SqlConnection Connection
        {
            get
            {
                SqlConnection connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                }
                catch (Exception)
                {
                    connection.Close();
                }
                return connection;
            }
        }
    }
}
