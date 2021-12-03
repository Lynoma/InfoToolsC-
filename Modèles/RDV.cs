using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetInfoToolsCRM
{
    public class RDV
    {

        public RDV()
        {

        }

        private int _idRDV;

        public int IdRDV
        {
            get { return _idRDV; }
            set { _idRDV = value; }
        }

        private Client _myClient;   

        public Client MyClient
        {
            get { return _myClient; }
            set { _myClient = value; }
        }

        private Employe _myEmploye;

        public Employe MyProduit
        {
            get { return _myEmploye; }
            set { _myEmploye = value; }
        }


    }

}
