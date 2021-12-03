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
    public class bddProduit : bdd
    {
        public bddProduit()
        {
            bddProduit.Initialize();
        }
        public ObservableCollection<Produit> SelectProduits()
        {
            string query = "SELECT * FROM produit";
            ObservableCollection<Produit> DBProduits = new ObservableCollection<Produit>();

            if (bdd.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Produit leProduit= new Produit
                    {
                        IdProd = Convert.ToInt32(dataReader["idProd"]),
                        NomProd = Convert.ToString(dataReader["nomProd"]),
                        DescProd = Convert.ToString(dataReader["descProd"]),
                        PrixProd = Convert.ToString(dataReader["prixProd"])
                    };
                    DBProduits.Add(leProduit);
                }
                bdd.CloseConnection();
            }
            return DBProduits;
        }

        public void AddProduit(Produit newProduit)
        {
            string query = "INSERT INTO produit (nomProd, descProd, prixProd) VALUES('" + newProduit.NomProd + "','" + newProduit.DescProd + "','" + newProduit.PrixProd + "')";
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

        public void UpdateProduit(Produit updateProduit)
        {
            string query = "UPDATE produit SET nomProd='" + updateProduit.NomProd + "', descProd='" + updateProduit.DescProd + "', prixProd='" + updateProduit.PrixProd + "' WHERE idProd=" + updateProduit.IdProd;
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

        public void DeleteProduit(int numP)
        {
            //Delete Magazine
            string query = "DELETE FROM produit WHERE idProd=" + numP;

            if (bdd.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                bdd.CloseConnection();
            }
        }
    }
}
