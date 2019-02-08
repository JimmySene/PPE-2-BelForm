using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE___Gestion_de_formations
{
    public class Mysql
    {
        private static string serveur = "localhost";
        private static string bdd = "gestion_formations";
        private static string user = "root";
        private static string pass = "";

        private static string StrConnection = @"SERVER="+serveur+";PORT=3306;DATABASE="+bdd+";UID="+user+";PWD="+pass+";";

        public static MySqlConnection connect()
        {
            return new MySqlConnection(StrConnection);
        }

    }
}
