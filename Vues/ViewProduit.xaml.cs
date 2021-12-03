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
    /// Logique d'interaction pour ViewProduit.xaml
    /// </summary>
    public partial class ViewProduit : UserControl, INotifyPropertyChanged
    {
        static bddProduit baseProduit = new bddProduit();
        public ViewProduit()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        ObservableCollection<Produit> _produits = baseProduit.SelectProduits();

        public ObservableCollection<Produit> Produits
        {
            get { return _produits; }
            set
            {
                _produits = value;
                OnPropertyChanged(nameof(Produits));
            }
        }

        public void Produit_selectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Produit produitSelected = (Produit)ListViewProduits.SelectedItem;

            if (produitSelected != null)
            {
                TxtID.Text = Convert.ToString(produitSelected.IdProd);
                TxtNom.Text = Convert.ToString(produitSelected.NomProd);
                TxtDesc.Text = Convert.ToString(produitSelected.DescProd);
                TxtPrix.Text = Convert.ToString(produitSelected.PrixProd);
            }
        }

        private void BtnProduitAdd_Click(object sender, RoutedEventArgs e)
        {
            Produit addProduit = new Produit
            {
                NomProd = Convert.ToString(TxtNom.Text),
                DescProd = Convert.ToString(TxtDesc.Text),
                PrixProd = Convert.ToString(TxtPrix.Text)
            };
            baseProduit.AddProduit(addProduit);
            Produits = baseProduit.SelectProduits();
            ListViewProduits.Items.Refresh();
        }

        private void BtnProduitUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtID.Text))
            {
                Produit updatedProduit = new Produit
                {
                    IdProd = Convert.ToInt32(TxtID.Text),
                    NomProd = Convert.ToString(TxtNom.Text),
                    DescProd = Convert.ToString(TxtDesc.Text),
                    PrixProd = Convert.ToString(TxtPrix.Text)
                };

                baseProduit.UpdateProduit(updatedProduit);
                Produits = baseProduit.SelectProduits();
                ListViewProduits.Items.Refresh();
            }
        }

        private void BtnProduitDelete_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtID.Text))
            {
                baseProduit.DeleteProduit(Convert.ToInt32(TxtID.Text));
                Produits = baseProduit.SelectProduits();
                ListViewProduits.Items.Refresh();
            }
        }
    }
}
