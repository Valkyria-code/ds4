using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Aquí_sí_Sabe.Data
{
    public static class DatabaseConnection
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["AquiSiSabeDB"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public static string GetConnectionString()
        {
            return connectionString;
        }
    }
}