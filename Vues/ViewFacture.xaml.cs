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
    /// Logique d'interaction pour ViewFacture.xaml
    /// </summary>
    public partial class ViewFacture : UserControl, INotifyPropertyChanged
    {
        static bddFacture baseFacture = new bddFacture();
        static bddClient baseClient = new bddClient();
        static bddProduit baseProduit = new bddProduit();
        public ViewFacture()
        {
            InitializeComponent();
            this.DataContext = this;
            CboC.ItemsSource = baseClient.SelectClients();
            CboP.ItemsSource = baseProduit.SelectProduits();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        ObservableCollection<Facture> _Factures = baseFacture.SelectFactures();

        public ObservableCollection<Facture> Factures
        {
            get { return _Factures; }
            set
            {
                _Factures = value;
                OnPropertyChanged(nameof(Factures));
            }
        }

        public void Facture_selectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Facture FactureSelected = (Facture)ListViewFactures.SelectedItem;

            if (FactureSelected != null)
            {
                TxtID.Text = Convert.ToString(FactureSelected.IdFacture);
                CboC.Text = FactureSelected.MyClient.ToString();
                CboP.Text = FactureSelected.MyProduit.ToString();
            }
        }

        private void BtnFactureAdd_Click(object sender, RoutedEventArgs e)
        {
            Facture addFacture = new Facture
            {
                MyClient = (Client)CboC.SelectedItem,
                MyProduit = (Produit)CboP.SelectedItem
            };
            baseFacture.AddFacture(addFacture);
            Factures = baseFacture.SelectFactures();
            ListViewFactures.Items.Refresh();
        }

        private void BtnFactureUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtID.Text))
            {
                Facture updatedFacture = new Facture
                {
                    IdFacture = Convert.ToInt32(TxtID.Text),
                    MyClient = (Client)CboC.SelectedItem,
                    MyProduit = (Produit)CboP.SelectedItem
                };

                baseFacture.UpdateFacture(updatedFacture);
                Factures = baseFacture.SelectFactures();
                ListViewFactures.Items.Refresh();
            }
        }

        private void BtnFactureDelete_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtID.Text))
            {
                baseFacture.DeleteFacture(Convert.ToInt32(TxtID.Text));
                Factures = baseFacture.SelectFactures();
                ListViewFactures.Items.Refresh();
            }
        }
    }
}
