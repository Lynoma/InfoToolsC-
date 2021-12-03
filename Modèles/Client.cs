using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetInfoToolsCRM
{
    public class Client
    {
        private int _id;
        private string _nom;
        private string _prenom;
        private string _adresse;
        private string _telephone;
        private string _mail;
        private string _mdp;

        public Client()
        {
            
        }

        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public string Nom
        {
            get
            {
                return _nom;
            }
            set
            {
                _nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return _prenom;
            }
            set
            {
                _prenom = value;
            }
        }

        public string Adresse
        {
            get
            {
                return _adresse;
            }
            set
            {
                _adresse = value;
            }
        }

        public string Telephone
        {
            get
            {
                return _telephone;
            }
            set
            {
                _telephone = value;
            }
        }

        public string Mail
        {
            get
            {
                return _mail;
            }
            set
            {
                _mail = value;
            }
        }

        public string Mdp
        {
            get
            {
                return _mdp;
            }
            set
            {
                _mdp = value;
            }
        }

        public override string ToString()
        {
            return _nom + " " + _prenom;
        }
    }
}
