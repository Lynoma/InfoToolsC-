using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetInfoToolsCRM.BDD;
using System.Collections.ObjectModel;

namespace ProjetInfoToolsCRM
{
    public class bddFacture : bdd
    {
        public bddFacture()
        {
            bddFacture.Initialize();
        }
        public ObservableCollection<Facture> SelectFactures()
        {
            string query = "SELECT idFact,F.idC, nomC, prenomC FROM Clients C INNER JOIN Facture F ON C.idC = F.idC";
            ObservableCollection<Facture> DBFactures = new ObservableCollection<Facture>();

            if (bdd.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Facture leFacture = new Facture
                    {
                        IdFacture = Convert.ToInt32(dataReader["idFact"]),
                        MyClient = new Client { ID = Convert.ToInt32(dataReader["idC"]), Nom = Convert.ToString(dataReader["nomC"]), Prenom = Convert.ToString(dataReader["prenomC"]) }
                    };
                    DBFactures.Add(leFacture);
                }
                bdd.CloseConnection();
            }
            return DBFactures;
        }

        public void AddFacture(Facture newFacture)
        {
            string query = "INSERT INTO Facture (idFact, idC) VALUES(" + newFacture.IdFacture + "," + newFacture.MyClient.ID + ")";
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

        public void UpdateFacture(Facture updateFacture)
        {
            string query = "UPDATE Facture SET idC=" + updateFacture.MyClient.ID + " WHERE idFact=" + updateFacture.IdFacture;
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

        public void DeleteFacture(int numF)
        {
            //Delete Magazine
            string query = "DELETE FROM Facture WHERE idFact=" + numF;

            if (bdd.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                bdd.CloseConnection();
            }
        }
    }
}
