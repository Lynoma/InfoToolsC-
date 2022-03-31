using ProjetInfoToolsCRM.BDD;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjetInfoToolsCRM
{
    /// <summary>
    /// Logique d'interaction pour ViewRDV.xaml
    /// </summary>
    public partial class ViewGraphique : UserControl
    {

        static bddGraphique baseGraph = new bddGraphique();

        public ViewGraphique()
        {
            InitializeComponent();
            this.DataContext = this;
            listProduitsPopulaires = baseGraph.SelectProdPop();
            NbClients = baseGraph.SelectClients();
            NbProspects = baseGraph.SelectProspects();
            RatioRDV = baseGraph.SelectRatioRDV();
                Prod1 = listProduitsPopulaires[0];
                Prod2 = listProduitsPopulaires[1];
                Prod3 = listProduitsPopulaires[2];
                MaxProd = Prod1.NbProd + Prod2.NbProd + Prod3.NbProd;
            NbRDV = baseGraph.SelectRDV();
            NbFact = baseGraph.SelectNbFactures();
            NbProd = baseGraph.SelectNbProd();
            NbEmp = baseGraph.SelectNbEmployes();
            CA = baseGraph.SelectCA();

            NbClientsProspects = NbClients + NbProspects;
        }

        static List<ProdPop> listProduitsPopulaires = new List<ProdPop>();

        #region Properties

        public int MaxProd { get; set; }
        public int NbClients { get; set; }
        public int NbProspects { get; set; }
        public int RatioRDV { get; set; }

        public int NbClientsProspects { get; set; }

        public ProdPop Prod1 { get; set; }
        public ProdPop Prod2 { get; set; }
        public ProdPop Prod3 { get; set; }

        public int NbRDV { get; set; }
        public int NbFact { get; set; }
        public double CA { get; set; }
        public int NbEmp { get; set; }
        public int NbProd { get; set; }

        #endregion
    }
}
