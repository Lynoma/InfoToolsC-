using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetInfoToolsCRM
{
    public class Employe
    {
        public Employe()
        {

        }
        private int _idEmp;

        public int IdEmp
        {
            get { return _idEmp; }
            set { _idEmp = value; }
        }

        private string _nomEmp;

        public string NomEmp
        {
            get { return _nomEmp; }
            set { _nomEmp = value; }
        }

        private string _prenomEmp;

        public string PrenomEmp
        {
            get { return _prenomEmp; }
            set { _prenomEmp = value; }
        }

        private string _adresseEmp;

        public string AdresseEmp
        {
            get { return _adresseEmp; }
            set { _adresseEmp = value; }
        }

        private string _telephoneEmp;

        public string TelephoneEmp
        {
            get { return _telephoneEmp; }
            set { _telephoneEmp = value; }
        }

        private string _mailEmp;

        public string MailEmp
        {
            get { return _mailEmp; }
            set { _mailEmp = value; }
        }

        private string _mdpEmp;

        public string MdpEmp
        {
            get { return _mdpEmp; }
            set { _mdpEmp = value; }
        }

        public override string ToString()
        {
            return _nomEmp + " " + _prenomEmp;
        }
    }
}
