using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetInfoToolsCRM
{
    public class Produit
    {

        public Produit()
        {

        }

        private int _idProd;

        public int IdProd
        {
            get { return _idProd; }
            set { _idProd = value; }
        }

        private string _nomProd;

        public string NomProd
        {
            get { return _nomProd; }
            set { _nomProd = value; }
        }
        private string _descProd;

        public string DescProd
        {
            get { return _descProd; }
            set { _descProd = value; }
        }

        private string _prixProd;

        public string PrixProd
        {
            get { return _prixProd; }
            set { _prixProd = value; }
        }


        public override string ToString()
        {
            return _nomProd;
        }

    }
}
