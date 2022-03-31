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
    public class bddRDV : bdd
    {
        public bddRDV()
        {
            bddRDV.Initialize();
        }
        public ObservableCollection<RDV> SelectRDVs()
        {
            string query = "SELECT idRDV, dateRDV, R.idC, R.idCom, nomCom, prenomCom, nomC, prenomC FROM Clients C INNER JOIN rendezvous R ON C.idC = R.idC INNER JOIN Commercial E ON R.idCom = E.idCom";
            ObservableCollection<RDV> DBRDVs = new ObservableCollection<RDV>();

            if (bdd.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    RDV leRDV = new RDV
                    {
                        IdRDV = Convert.ToInt32(dataReader["idRDV"]),
                        dateRDV = Convert.ToDateTime(dataReader["dateRDV"]),
                        MyClient = new Client { ID = Convert.ToInt32(dataReader["idC"]), Nom = Convert.ToString(dataReader["nomC"]), Prenom = Convert.ToString(dataReader["prenomC"]) },
                        MyCommercial = new Commercial { IdCom = Convert.ToInt32(dataReader["idCom"]), NomCom = Convert.ToString(dataReader["nomCom"]), PrenomCom = Convert.ToString(dataReader["prenomCom"])}
                    };
                    DBRDVs.Add(leRDV);
                }
                bdd.CloseConnection();
            }
            return DBRDVs;
        }

        public void AddRDV(RDV newRDV)
        {
            string query = "INSERT INTO rendezvous (dateRdv, idC, idCom) VALUES(STR_TO_DATE('" + newRDV.dateRDV + "','%d/%m/%Y %H:%i:%s')," + newRDV.MyClient.ID + "," + newRDV.MyCommercial.IdCom + ")";
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

        public void UpdateRDV(RDV updateRDV)
        {
            string query = "UPDATE rendezvous SET dateRDV =STR_TO_DATE('" + updateRDV.dateRDV + "','%d/%m/%Y %H:%i:%s'), idC=" + updateRDV.MyClient.ID + ", idCom=" + updateRDV.MyCommercial.IdCom + " WHERE idRDV=" + updateRDV.IdRDV;
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

        public void DeleteRDV(int numR)
        {
            //Delete Magazine
            string query = "DELETE FROM rendezvous WHERE idRDV=" + numR;

            if (bdd.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                bdd.CloseConnection();
            }
        }
    }
}
