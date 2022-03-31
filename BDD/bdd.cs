using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ProjetInfoToolsCRM;

namespace ProjetInfoToolsCRM
{
    public abstract class bdd
    {
       protected static MySqlConnection connection;
       protected static string server;
       protected static string database;
       protected static string uid;
       protected static string password;

        public static void Initialize()
        {
            server = "127.0.0.1";
            database = "infotools";
            uid = "root";
            password = "root";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database
                + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        protected static bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Erreur Connexion BDD");
            }
            return false;
        }

        protected static bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch(MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
