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

        private DateTime _dateRDV;

        public DateTime dateRDV
        {
            get { return _dateRDV; }
            set { _dateRDV = value; }
        }


        private Client _myClient;   

        public Client MyClient
        {
            get { return _myClient; }
            set { _myClient = value; }
        }

        private Commercial _myCommercial;

        public Commercial MyCommercial
        {
            get { return _myCommercial; }
            set { _myCommercial = value; }
        }


    }

}
