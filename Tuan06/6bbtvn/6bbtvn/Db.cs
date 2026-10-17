using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
namespace _6bbtvn
{
    internal static class Db
    {
        private const string ConnectionString =
            @"Data Source=THANHDAI;
              Initial Catalog=QLCuaHang;
              Integrated Security=True;
              TrustServerCertificate=True";
        public static SqlConnection Open()
        {
            SqlConnection conn =
                new SqlConnection(ConnectionString);

            conn.Open();
            return conn;
        }
    }
}
