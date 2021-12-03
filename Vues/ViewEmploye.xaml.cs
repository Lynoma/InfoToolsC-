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
    /// Logique d'interaction pour ViewEmploye.xaml
    /// </summary>
    public partial class ViewEmploye : UserControl, INotifyPropertyChanged
    {
        static bddEmploye baseEmploye = new bddEmploye();
        public ViewEmploye()
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

        ObservableCollection<Employe> _Employes = baseEmploye.SelectEmployes();

        

        public ObservableCollection<Employe> Employes
        {
            get { return _Employes; }
            set 
            { 
                _Employes = value;
                OnPropertyChanged(nameof(Employes));
            }
        }

        public void Employe_selectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Employe EmployeSelected = (Employe)ListViewEmployes.SelectedItem;

            if (EmployeSelected != null)
            {
                TxtID.Text = Convert.ToString(EmployeSelected.IdEmp);
                TxtNom.Text = Convert.ToString(EmployeSelected.NomEmp);
                TxtPrenom.Text = Convert.ToString(EmployeSelected.PrenomEmp);
                TxtAdresse.Text = Convert.ToString(EmployeSelected.AdresseEmp);
                TxtTelephone.Text = Convert.ToString(EmployeSelected.TelephoneEmp);
                TxtMail.Text = Convert.ToString(EmployeSelected.MailEmp);
                TxtMdp.Text = Convert.ToString(EmployeSelected.MdpEmp);
            }
        }

        private void BtnEmployeAdd_Click(object sender, RoutedEventArgs e)
        {
            Employe addEmploye = new Employe
            {
                NomEmp = Convert.ToString(TxtNom.Text),
                PrenomEmp = Convert.ToString(TxtPrenom.Text),
                AdresseEmp = Convert.ToString(TxtAdresse.Text),
                TelephoneEmp = Convert.ToString(TxtTelephone.Text),
                MailEmp = Convert.ToString(TxtMail.Text),
                MdpEmp = Convert.ToString(TxtMdp.Text)
            };
            baseEmploye.AddEmploye(addEmploye);
            Employes = baseEmploye.SelectEmployes();
            ListViewEmployes.Items.Refresh();
        }

        private void BtnEmployeUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtID.Text))
            {
                Employe updatedEmploye = new Employe
                {
                    IdEmp = Convert.ToInt32(TxtID.Text),
                    NomEmp = Convert.ToString(TxtNom.Text),
                    PrenomEmp = Convert.ToString(TxtPrenom.Text),
                    AdresseEmp = Convert.ToString(TxtAdresse.Text),
                    TelephoneEmp = Convert.ToString(TxtTelephone.Text),
                    MailEmp = Convert.ToString(TxtMail.Text),
                    MdpEmp = Convert.ToString(TxtMdp.Text)
                };

                baseEmploye.UpdateEmploye(updatedEmploye);
                Employes = baseEmploye.SelectEmployes();
                ListViewEmployes.Items.Refresh();
            }   
        }

        private void BtnEmployeDelete_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtID.Text))
            {
                baseEmploye.DeleteEmploye(Convert.ToInt32(TxtID.Text));
                Employes = baseEmploye.SelectEmployes();
                ListViewEmployes.Items.Refresh();
            }
        }
    }
}
