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
    public partial class ViewRDV : UserControl, INotifyPropertyChanged
    {
        static bddRDV baseRDV = new bddRDV();
        static bddClient baseClient = new bddClient();
        static bddEmploye baseEmploye = new bddEmploye();
        public ViewRDV()
        {
            InitializeComponent();
            this.DataContext = this;
            CboC.ItemsSource = baseClient.SelectClients();
            CboE.ItemsSource = baseEmploye.SelectEmployes();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        ObservableCollection<RDV> _RDVs = baseRDV.SelectRDVs();

        public ObservableCollection<RDV> RDVs
        {
            get { return _RDVs; }
            set
            {
                _RDVs = value;
                OnPropertyChanged(nameof(RDVs));
            }
        }

        public void RDV_selectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RDV RDVSelected = (RDV)ListViewRDVs.SelectedItem;

            if (RDVSelected != null)
            {
                TxtID.Text = Convert.ToString(RDVSelected.IdRDV);
                TxtDate.Text = Convert.ToString(RDVSelected.dateRDV);
                CboC.Text = RDVSelected.MyClient.ToString();
                CboE.Text = RDVSelected.MyEmploye.ToString();
            }
        }

        private void BtnRDVAdd_Click(object sender, RoutedEventArgs e)
        {
            RDV addRDV = new RDV
            {
                dateRDV = Convert.ToDateTime(TxtDate.Text),
                MyClient = (Client)CboC.SelectedItem,
                MyEmploye = (Employe)CboE.SelectedItem
            };
            baseRDV.AddRDV(addRDV);
            RDVs = baseRDV.SelectRDVs();
            ListViewRDVs.Items.Refresh();
        }

        private void BtnRDVUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtID.Text))
            {
                RDV updatedRDV = new RDV
                {
                    IdRDV = Convert.ToInt32(TxtID.Text),
                    dateRDV = Convert.ToDateTime(TxtDate.Text),
                    MyClient = (Client)CboC.SelectedItem,
                    MyEmploye = (Employe)CboE.SelectedItem
                };

                baseRDV.UpdateRDV(updatedRDV);
                RDVs = baseRDV.SelectRDVs();
                ListViewRDVs.Items.Refresh();
            }
        }

        private void BtnRDVDelete_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtID.Text))
            {
                baseRDV.DeleteRDV(Convert.ToInt32(TxtID.Text));
                RDVs = baseRDV.SelectRDVs();
                ListViewRDVs.Items.Refresh();
            }
        }
    }
}
