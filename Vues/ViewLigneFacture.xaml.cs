using ProjetInfoToolsCRM.BDD;
using ProjetInfoToolsCRM.Modèles;
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

namespace ProjetInfoToolsCRM.Vues
{
    /// <summary>
    /// Logique d'interaction pour ViewLigneFacture.xaml
    /// </summary>
    public partial class ViewLigneFacture : UserControl, INotifyPropertyChanged
    {
        static bddLigneFacture baseLigneFacture = new bddLigneFacture();
        static bddFacture baseFacture = new bddFacture();
        static bddProduit baseProduit = new bddProduit();
        public ViewLigneFacture()
        {
            InitializeComponent();
            this.DataContext = this;
            CboF.ItemsSource = baseFacture.SelectFactures();
            CboP.ItemsSource = baseProduit.SelectProduits();
        }

        private ObservableCollection<LigneFacture> _ligneFactures = baseLigneFacture.SelectLigneFactures();
        public ObservableCollection<LigneFacture> LigneFactures
        {
            get { return _ligneFactures; }
            set
            {
                _ligneFactures = value;
                OnPropertyChanged(nameof(LigneFactures));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        private void ListViewLF_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LigneFacture LFSelected = (LigneFacture)ListViewLF.SelectedItem;

            if (LFSelected != null)
            {
                TxtQte.Text = Convert.ToString(LFSelected.Quantite);
                CboF.Text = LFSelected.MyFacture.ToString();
                CboP.Text = LFSelected.MyProduit.ToString();
            }
        }

        private void BtnLFAdd_Click(object sender, RoutedEventArgs e)
        {
            LigneFacture myLF = new LigneFacture
            {
                Quantite = Convert.ToInt32(TxtQte.Text),
                MyFacture = (Facture)CboF.SelectedItem,
                MyProduit = (Produit)CboP.SelectedItem
            };

            if (!baseLigneFacture.ExistsInDB(myLF))
            {
                baseLigneFacture.AddLF(myLF);
            }

            LigneFactures = baseLigneFacture.SelectLigneFactures();
            ListViewLF.Items.Refresh();
        }
        private void BtnLFUpdate_Click(object sender, RoutedEventArgs e)
        {
            LigneFacture myLF = new LigneFacture
            {
                Quantite = Convert.ToInt32(TxtQte.Text),
                MyFacture = (Facture)CboF.SelectedItem,
                MyProduit = (Produit)CboP.SelectedItem
            };

            if (baseLigneFacture.ExistsInDB(myLF))
            {
                baseLigneFacture.UpdateLF(myLF);
            }

            LigneFactures = baseLigneFacture.SelectLigneFactures();
            ListViewLF.Items.Refresh();
        }
        private void BtnLFDelete_Click(object sender, RoutedEventArgs e)
        {
            LigneFacture myLF = new LigneFacture
            {
                Quantite = Convert.ToInt32(TxtQte.Text),
                MyFacture = (Facture)CboF.SelectedItem,
                MyProduit = (Produit)CboP.SelectedItem
            };

            if (baseLigneFacture.ExistsInDB(myLF))
            {
                baseLigneFacture.DeleteLF(myLF);
            }

            LigneFactures = baseLigneFacture.SelectLigneFactures();
            ListViewLF.Items.Refresh();
        }
    }
}
