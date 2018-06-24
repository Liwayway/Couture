using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Couture
{
    public class ConnexionBDD
    {

        private static MySqlConnection connection;
        private static string server;
        private static string database;
        private static string uid;
        private static string password;


        public static MySqlConnection GetConnexionBDD()
        {

            server = "localhost";
            database = "coutureversion4";
            uid = "root";
            password = "";
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            if (connection == null)
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
            }
            return connection;
        }

        //Close connection
        public static bool CloseConnection()
        {
            if (connection != null)
            {
                connection.Close();
                connection = null;
            }
            return true;
        }
    }
}
