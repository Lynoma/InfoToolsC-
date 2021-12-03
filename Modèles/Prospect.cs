using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetInfoToolsCRM
{
    public class Prospect
    {

        public Prospect()
        {

        }

        private int _idProspect;

        public int IdProspect
        {
            get { return _idProspect; }
            set { _idProspect = value; }
        }

        private string _nomProspect;

        public string NomProspect
        {
            get { return _nomProspect; }
            set { _nomProspect = value; }
        }

        private string _prenomProspect;

        public string PrenomProspect
        {
            get { return _prenomProspect; }
            set { _prenomProspect = value; }
        }

        private string _adrProspect;

        public string AdresseProspect
        {
            get { return _adrProspect; }
            set { _adrProspect = value; }
        }

        private string _telProspect;

        public string TelephoneProspect
        {
            get { return _telProspect; }
            set { _telProspect = value; }
        }

        private string _mail;

        public string MailProspect
        {
            get { return _mail; }
            set { _mail = value; }
        }

        private string _mdp;

        public string MdpProspect
        {
            get { return _mdp; }
            set { _mdp = value; }
        }


    }

}
