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
    public class bddGraphique : bdd
    {
        public bddGraphique()
        {
            bddGraphique.Initialize();
        }
        
        public int SelectNbEmployes()
        {
            string query = "SELECT Count(idCom) as NbEmp FROM Commercial";
            int NbEmploye = 0;

            if (bdd.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    NbEmploye = Convert.ToInt32(dataReader["NbEmp"]);
                }
                bdd.CloseConnection();
            }
            return NbEmploye;
        }

        public int SelectRDV()
        {
            string query = "SELECT Count(idRDV) as NbRDV FROM rendezvous";
            int NbRDV = 0;

            if (bdd.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    NbRDV = Convert.ToInt32(dataReader["nbRDV"]);
                }
                bdd.CloseConnection();
            }
            return NbRDV;
        }

        public int SelectNbProd()
        {
            string query = "SELECT Count(idProd) as NbProd FROM produit";
            int NbProd = 0;

            if (bdd.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    NbProd = Convert.ToInt32(dataReader["nbProd"]);
                }
                bdd.CloseConnection();
            }
            return NbProd;
        }

        public double SelectCA()
        {
            string query = "SELECT SUM(PrixProd * qte) as CA FROM lignefact l INNER JOIN produit p ON l.idProd = p.idProd";
            double CA = 0;

            if (bdd.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    CA = Convert.ToDouble(dataReader["CA"]);
                }
                bdd.CloseConnection();
            }
            return CA;
        }

        public int SelectProspects()
        {
            string query = "SELECT Count(idC) as NbProspect FROM clients where IsCli = 0";
            int NbProspect = 0;

            if (bdd.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    NbProspect = Convert.ToInt32(dataReader["NbProspect"]);
                }
                bdd.CloseConnection();
            }
            return NbProspect;
        }

        public int SelectClients()
        {
            string query = "SELECT Count(idC) as NbClients FROM clients";
            int NbClients = 0;

            if (bdd.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    NbClients = Convert.ToInt32(dataReader["NbClients"]);
                }
                bdd.CloseConnection();
            }
            return NbClients;
        }

        public int SelectRatioRDV()
        {
            string query = "SELECT Count(idRDV) as countRDV FROM rendezvous GROUP BY idC";
            int ratioRDV = 0;

            if (bdd.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    ratioRDV = Convert.ToInt32(dataReader["countRDV"]);
                }
                bdd.CloseConnection();
            }
            return ratioRDV;
        }
        
        public List<ProdPop> SelectProdPop()
        {
            string query = "SELECT NomProd, SUM(qte) AS NbProd FROM lignefact l INNER JOIN produit p ON l.idProd = p.idProd GROUP BY NomProd ORDER BY NbProd DESC, NomProd";
            List<ProdPop> DbProdPop = new List<ProdPop>();

            if (bdd.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    ProdPop leProd = new ProdPop
                    {
                        NbProd = Convert.ToInt32(dataReader["NbProd"]),
                        NomProd = Convert.ToString(dataReader["NomProd"])
                    };
                    DbProdPop.Add(leProd);
                }
                bdd.CloseConnection();
            }
            return DbProdPop;
        }

        public int SelectNbFactures()
        {
            string query = "SELECT Count(idFact) as NbFact FROM Facture";
            int NbFact = 0;

            if (bdd.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    NbFact = Convert.ToInt32(dataReader["NbFact"]);
                }
                bdd.CloseConnection();
            }
            return NbFact;
        }
    }

    public class ProdPop
    {
        public ProdPop()
        {

        }

        private string _nomProd;

        public string NomProd
        {
            get { return _nomProd; }
            set { _nomProd = value; }
        }

        private int _nbProd;

        public int NbProd
        {
            get { return _nbProd; }
            set { _nbProd = value; }
        }

    }
}
