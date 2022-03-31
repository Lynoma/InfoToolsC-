using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetInfoToolsCRM
{
    public class Facture
    {

        public Facture()
        {

        }

        private int _idFacture;

        public int IdFacture
        {
            get { return _idFacture; }
            set { _idFacture = value; }
        }

        private Client _myClient;   

        public Client MyClient
        {
            get { return _myClient; }
            set { _myClient = value; }
        }

        private Produit _myProduit;

        public Produit MyProduit
        {
            get { return _myProduit; }
            set { _myProduit = value; }
        }

        public override string ToString()
        {
            return Convert.ToString(this.IdFacture);
        }
    }

}
