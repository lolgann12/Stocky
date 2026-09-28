using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Stocky
{
    internal class module
    {
        public static SqlConnection Getconn()
        {
            string lokasi = @"Data Source=LAPTOP-PJAMI8JO\SQLEXPRESS; Database=db_pkk; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(lokasi);
            return conn;
        }

        public static class Session
        {
            public static string username = "";
            public static string role = "";
            public static int id_user = 0;
        }
    }
}
