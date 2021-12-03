using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetInfoToolsCRM.BDD;
using System.Collections.ObjectModel;

namespace ProjetInfoToolsCRM.BDD
{
    public class bddClient : bdd
    {
        public bddClient()
        {
            bddClient.Initialize();
        }
        public ObservableCollection<Client> SelectClients()
        {
            string query = "SELECT * FROM clients";
            ObservableCollection<Client> DBClients = new ObservableCollection<Client>();

            if (bdd.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Client leClient = new Client
                    {
                        ID = Convert.ToInt32(dataReader["idC"]),
                        Nom = Convert.ToString(dataReader["nomC"]),
                        Prenom = Convert.ToString(dataReader["prenomC"]),
                        Adresse = Convert.ToString(dataReader["adrC"]),
                        Telephone = Convert.ToString(dataReader["telC"]),
                        Mail = Convert.ToString(dataReader["mailC"]),
                        Mdp = Convert.ToString(dataReader["mdpC"])
                    };
                    DBClients.Add(leClient);
                }
                bdd.CloseConnection();
            }
            return DBClients;
        }

        public void AddClient(Client newClient)
        {
            string query = "INSERT INTO clients (nomC, prenomC, adrC, telC, mailC, mdpC) VALUES('" + newClient.Nom + "','" + newClient.Prenom + "','" + newClient.Adresse + "','" + newClient.Telephone + "','" + newClient.Mail + "','" + newClient.Mdp + "')";
            Console.WriteLine(query);

            //open connection
            if (bdd.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                bdd.CloseConnection();
            }
        }

        public void UpdateClient(Client updateClient)
        {
            string query = "UPDATE clients SET nomC='" + updateClient.Nom + "', prenomC='" + updateClient.Prenom + "', adrC='" + updateClient.Adresse + "', telC = '" + updateClient.Telephone + "', mailC='" + updateClient.Mail + "', mdpC='" + updateClient.Mdp + "' WHERE idC=" + updateClient.ID;
            Console.WriteLine(query);
            //Open connection
            if (bdd.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                bdd.CloseConnection();
            }
        }

        public void DeleteClient(int numC)
        {
            //Delete Magazine
            string query = "DELETE FROM clients WHERE idC=" + numC;

            if (bdd.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                bdd.CloseConnection();
            }
        }
    }
}
