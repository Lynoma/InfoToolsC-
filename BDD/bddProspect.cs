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
    public class bddProspect : bdd
    {
        public bddProspect()
        {
            bddProspect.Initialize();
        }
        public ObservableCollection<Prospect> SelectProspects()
        {
            string query = "SELECT * FROM prospect";
            ObservableCollection<Prospect> DBProspects = new ObservableCollection<Prospect>();

            if (bdd.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Prospect leProspect = new Prospect
                    {
                        IdProspect = Convert.ToInt32(dataReader["idP"]),
                        NomProspect = Convert.ToString(dataReader["nomP"]),
                        PrenomProspect = Convert.ToString(dataReader["prenomP"]),
                        AdresseProspect = Convert.ToString(dataReader["adrP"]),
                        TelephoneProspect = Convert.ToString(dataReader["telP"]),
                        MailProspect = Convert.ToString(dataReader["mailP"]),
                        MdpProspect = Convert.ToString(dataReader["mdpP"])
                    };
                    DBProspects.Add(leProspect);
                }
                bdd.CloseConnection();
            }
            return DBProspects;
        }

        public void AddProspect(Prospect newProspect)
        {
            string query = "INSERT INTO prospect (nomP, prenomP, adrP, telP, mailP, mdpP) VALUES('" + newProspect.NomProspect + "','" + newProspect.PrenomProspect + "','" + newProspect.AdresseProspect + "','" + newProspect.TelephoneProspect + "','" + newProspect.MailProspect + "','" + newProspect.MdpProspect + "')";
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

        public void UpdateProspect(Prospect updateProspect)
        {
            string query = "UPDATE prospect SET nomP='" + updateProspect.NomProspect + "', prenomP='" + updateProspect.PrenomProspect + "', adrP='" + updateProspect.AdresseProspect + "', telP = '" + updateProspect.TelephoneProspect + "', mailP='" + updateProspect.MailProspect + "', mdpP='" + updateProspect.MdpProspect + "' WHERE idP=" + updateProspect.IdProspect;
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

        public void DeleteProspect(int numP)
        {
            //Delete Magazine
            string query = "DELETE FROM prospect WHERE idP=" + numP;

            if (bdd.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                bdd.CloseConnection();
            }
        }
    }
}
