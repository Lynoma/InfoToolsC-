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
    public class bddEmploye : bdd
    {
        public bddEmploye()
        {
            bddEmploye.Initialize();
        }
        public ObservableCollection<Employe> SelectEmployes()
        {
            string query = "SELECT * FROM employe";
            ObservableCollection<Employe> DBEmployes = new ObservableCollection<Employe>();

            if (bdd.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Employe leEmploye = new Employe
                    {
                        IdEmp = Convert.ToInt32(dataReader["idEmp"]),
                        NomEmp = Convert.ToString(dataReader["nomEmp"]),
                        PrenomEmp = Convert.ToString(dataReader["prenomEmp"]),
                        AdresseEmp = Convert.ToString(dataReader["adrEmp"]),
                        TelephoneEmp = Convert.ToString(dataReader["telEmp"]),
                        MailEmp = Convert.ToString(dataReader["mailEmp"]),
                        MdpEmp = Convert.ToString(dataReader["mdpEmp"])
                    };
                    DBEmployes.Add(leEmploye);
                }
                bdd.CloseConnection();
            }
            return DBEmployes;
        }

        public void AddEmploye(Employe newEmploye)
        {
            string query = "INSERT INTO employe (nomEmp, prenomEmp, adrEmp, telEmp, mailEmp, mdpEmp) VALUES('" + newEmploye.NomEmp + "','" + newEmploye.PrenomEmp + "','" + newEmploye.AdresseEmp + "','" + newEmploye.TelephoneEmp + "','" + newEmploye.MailEmp + "','" + newEmploye.MdpEmp + "')";
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

        public void UpdateEmploye(Employe updateEmploye)
        {
            string query = "UPDATE employe SET nomEmp='" + updateEmploye.NomEmp + "', prenomEmp='" + updateEmploye.PrenomEmp + "', adrEmp='" + updateEmploye.AdresseEmp + "', telEmp = '" + updateEmploye.TelephoneEmp + "', mailEmp='" + updateEmploye.MailEmp + "', mdpEmp='" + updateEmploye.MdpEmp + "' WHERE idEmp=" + updateEmploye.IdEmp;
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

        public void DeleteEmploye(int numE)
        {
            //Delete Magazine
            string query = "DELETE FROM employe WHERE idEmp=" + numE;

            if (bdd.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                bdd.CloseConnection();
            }
        }
    }
}
