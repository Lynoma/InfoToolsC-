using MySql.Data.MySqlClient;
using ProjetInfoToolsCRM.Modèles;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetInfoToolsCRM.BDD
{
    public class bddLigneFacture : bdd
    {
        public bddLigneFacture()
        {
            bddLigneFacture.Initialize();
        }
        public ObservableCollection<LigneFacture> SelectLigneFactures()
        {
            string query = "SELECT LF.idFact, LF.idProd, Qte, F.idC, P.idProd, P.nomProd, P.descProd, P.prixProd" +
                           " FROM lignefact LF INNER JOIN facture F ON LF.idFact = F.idFact" + 
                                             " INNER JOIN produit P ON LF.idProd = P.idProd";
            ObservableCollection<LigneFacture> DBLF= new ObservableCollection<LigneFacture>();

            if (bdd.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    LigneFacture laLF = new LigneFacture
                    {
                        Quantite = Convert.ToInt32(dataReader["Qte"]),
                        MyFacture = new Facture 
                            { 
                                IdFacture = Convert.ToInt32(dataReader["idFact"])
                            },
                        MyProduit = new Produit 
                            {
                                IdProd = Convert.ToInt32(dataReader["idProd"]),
                                DescProd = Convert.ToString(dataReader["descProd"]),
                                NomProd = Convert.ToString(dataReader["nomProd"]),
                                PrixProd = Convert.ToString(dataReader["prixProd"])
                            }
                    };
                    DBLF.Add(laLF);
                }
                bdd.CloseConnection();
            }
            return DBLF;
        }
        public void AddLF(LigneFacture newLF)
        {
            string query = "INSERT INTO lignefact (Qte, idFact, idProd) VALUES(" + newLF.Quantite + "," + newLF.MyFacture.IdFacture + "," + newLF.MyProduit.IdProd + ")";
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

        public void UpdateLF(LigneFacture myLF)
        {
            string query = "UPDATE lignefact SET Qte = " + myLF.Quantite + " WHERE idProd=" + myLF.MyProduit.IdProd + " AND idFact=" + myLF.MyFacture.IdFacture;

            if (bdd.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                bdd.CloseConnection();
            }
        }

        public void DeleteLF(LigneFacture myLF)
        {
            string query = "DELETE FROM lignefact WHERE idFact=" + myLF.MyFacture.IdFacture + " AND idProd=" + myLF.MyProduit.IdProd;

            if (bdd.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                bdd.CloseConnection();
            }
        }

        public bool ExistsInDB(LigneFacture myLF)
        {
            string query = "SELECT * FROM lignefact WHERE idFact = " + myLF.MyFacture.IdFacture + " AND idProd = " + myLF.MyProduit.IdProd;
            bool Exists = false;

            if (bdd.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.HasRows)
                    Exists = true;
                
                bdd.CloseConnection();
            }
            return Exists;
        }
    }
}
