using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetInfoToolsCRM.BDD;
using System.Collections.ObjectModel;
using MySql.Data.MySqlClient;

namespace ProjetInfoToolsCRM.BDD
{
    public class bddCommercial : bdd
    {
        public bddCommercial()
        {
            bddCommercial.Initialize();
        }
        public ObservableCollection<Commercial> SelectCommercials()
        {
            string query = "SELECT * FROM Commercial";
            ObservableCollection<Commercial> DBCommercials = new ObservableCollection<Commercial>();

            if (bdd.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Commercial leCommercial = new Commercial
                    {
                        IdCom = Convert.ToInt32(dataReader["idCom"]),
                        NomCom = Convert.ToString(dataReader["nomCom"]),
                        PrenomCom = Convert.ToString(dataReader["prenomCom"]),
                        AdresseCom = Convert.ToString(dataReader["adrCom"]),
                        TelephoneCom = Convert.ToString(dataReader["telCom"]),
                        MailCom = Convert.ToString(dataReader["mailCom"]),
                        MdpCom = Convert.ToString(dataReader["mdpCom"])
                    };
                    DBCommercials.Add(leCommercial);
                }
                bdd.CloseConnection();
            }
            return DBCommercials;
        }

        public void AddCommercial(Commercial newCommercial)
        {
            string query = "INSERT INTO Commercial (nomCom, prenomCom, adrCom, telCom, mailCom, mdpCom) VALUES('" + newCommercial.NomCom + "','" + newCommercial.PrenomCom + "','" + newCommercial.AdresseCom + "','" + newCommercial.TelephoneCom + "','" + newCommercial.MailCom + "','" + newCommercial.MdpCom + "')";
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

        public void UpdateCommercial(Commercial updateCommercial)
        {
            string query = "UPDATE Commercial SET nomCom='" + updateCommercial.NomCom + "', prenomCom='" + updateCommercial.PrenomCom + "', adrCom='" + updateCommercial.AdresseCom + "', telCom = '" + updateCommercial.TelephoneCom + "', mailCom='" + updateCommercial.MailCom + "', mdpCom='" + updateCommercial.MdpCom + "' WHERE idCom=" + updateCommercial.IdCom;
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

        public void DeleteCommercial(int numE)
        {
            //Delete Magazine
            string query = "DELETE FROM Commercial WHERE idCom=" + numE;

            if (bdd.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                bdd.CloseConnection();
            }
        }
    }
}
