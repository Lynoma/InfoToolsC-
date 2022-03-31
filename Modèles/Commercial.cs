using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetInfoToolsCRM
{
    public class Commercial
    {
        public Commercial()
        {

        }
        private int _idCom;

        public int IdCom
        {
            get { return _idCom; }
            set { _idCom = value; }
        }

        private string _nomCom;

        public string NomCom
        {
            get { return _nomCom; }
            set { _nomCom = value; }
        }

        private string _prenomCom;

        public string PrenomCom
        {
            get { return _prenomCom; }
            set { _prenomCom = value; }
        }

        private string _adresseCom;

        public string AdresseCom
        {
            get { return _adresseCom; }
            set { _adresseCom = value; }
        }

        private string _telephoneCom;

        public string TelephoneCom
        {
            get { return _telephoneCom; }
            set { _telephoneCom = value; }
        }

        private string _mailCom;

        public string MailCom
        {
            get { return _mailCom; }
            set { _mailCom = value; }
        }

        private string _mdpCom;

        public string MdpCom
        {
            get { return _mdpCom; }
            set { _mdpCom = value; }
        }

        public override string ToString()
        {
            return _nomCom + " " + _prenomCom;
        }
    }
}
