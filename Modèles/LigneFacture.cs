using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetInfoToolsCRM.Modèles
{
    public class LigneFacture
    {
        private Facture _facture;

        public Facture MyFacture
        {
            get { return _facture; }
            set { _facture = value; }
        }

        private Produit _produit;

        public Produit MyProduit
        {
            get { return _produit; }
            set { _produit = value; }
        }

        private int _quantite;

        public int Quantite
        {
            get { return _quantite; }
            set { _quantite = value; }
        }

    }
}
