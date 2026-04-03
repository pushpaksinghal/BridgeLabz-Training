using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthClinic.Connection
{
    internal class DB_Connection
    {
        private static readonly string connectionString = "Server=localhost\\SQLEXPRESS;Database=HealthClinicDB;Trusted_Connection=true;TrustServerCertificate=true;";

        public static SqlConnection CreateConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
