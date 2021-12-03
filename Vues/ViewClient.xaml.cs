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
using ProjetInfoToolsCRM;
using ProjetInfoToolsCRM.BDD;

namespace ProjetInfoToolsCRM
{
    /// <summary>
    /// Logique d'interaction pour ViewClient.xaml
    /// </summary>
    public partial class ViewClient : UserControl, INotifyPropertyChanged
    {
        static bddClient baseClient = new bddClient();
        public ViewClient()
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

        ObservableCollection<Client> _clients = baseClient.SelectClients();

        

        public ObservableCollection<Client> Clients
        {
            get { return _clients; }
            set 
            { 
                _clients = value;
                OnPropertyChanged(nameof(Clients));
            }
        }

        public void Client_selectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Client clientSelected = (Client)ListViewClients.SelectedItem;

            if (clientSelected != null)
            {
                TxtID.Text = Convert.ToString(clientSelected.ID);
                TxtNom.Text = Convert.ToString(clientSelected.Nom);
                TxtPrenom.Text = Convert.ToString(clientSelected.Prenom);
                TxtAdresse.Text = Convert.ToString(clientSelected.Adresse);
                TxtTelephone.Text = Convert.ToString(clientSelected.Telephone);
                TxtMail.Text = Convert.ToString(clientSelected.Mail);
                TxtMdp.Text = Convert.ToString(clientSelected.Mdp);
            }
        }

        private void BtnClientAdd_Click(object sender, RoutedEventArgs e)
        {
            Client addClient = new Client
            {
                Nom = Convert.ToString(TxtNom.Text),
                Prenom = Convert.ToString(TxtPrenom.Text),
                Adresse = Convert.ToString(TxtAdresse.Text),
                Telephone = Convert.ToString(TxtTelephone.Text),
                Mail = Convert.ToString(TxtMail.Text),
                Mdp = Convert.ToString(TxtMdp.Text)
            };
            baseClient.AddClient(addClient);
            Clients = baseClient.SelectClients();
            ListViewClients.Items.Refresh();
        }

        private void BtnClientUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtID.Text))
            {
                Client updatedClient = new Client
                {
                    ID = Convert.ToInt32(TxtID.Text),
                    Nom = Convert.ToString(TxtNom.Text),
                    Prenom = Convert.ToString(TxtPrenom.Text),
                    Adresse = Convert.ToString(TxtAdresse.Text),
                    Telephone = Convert.ToString(TxtTelephone.Text),
                    Mail = Convert.ToString(TxtMail.Text),
                    Mdp = Convert.ToString(TxtMdp.Text)
                };

                baseClient.UpdateClient(updatedClient);
                Clients = baseClient.SelectClients();
                ListViewClients.Items.Refresh();
            }   
        }

        private void BtnClientDelete_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtID.Text))
            {
                baseClient.DeleteClient(Convert.ToInt32(TxtID.Text));
                Clients = baseClient.SelectClients();
                ListViewClients.Items.Refresh();
            }
        }
    }
}
