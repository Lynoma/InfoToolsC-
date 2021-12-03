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
    /// Logique d'interaction pour ViewProspect.xaml
    /// </summary>
    public partial class ViewProspect : UserControl, INotifyPropertyChanged
    {
        static bddProspect baseProspect = new bddProspect();
        public ViewProspect()
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

        ObservableCollection<Prospect> _prospects = baseProspect.SelectProspects();

        public ObservableCollection<Prospect> Prospects
        {
            get { return _prospects; }
            set
            { 
                _prospects = value;
                OnPropertyChanged(nameof(Prospects));
            }
        }

        public void Prospect_selectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Prospect prospectSelected = (Prospect)ListViewProspects.SelectedItem;

            if (prospectSelected != null)
            {
                TxtID.Text = Convert.ToString(prospectSelected.IdProspect);
                TxtNom.Text = Convert.ToString(prospectSelected.NomProspect);
                TxtPrenom.Text = Convert.ToString(prospectSelected.PrenomProspect);
                TxtAdresse.Text = Convert.ToString(prospectSelected.AdresseProspect);
                TxtTelephone.Text = Convert.ToString(prospectSelected.TelephoneProspect);
                TxtMail.Text = Convert.ToString(prospectSelected.MailProspect);
                TxtMdp.Text = Convert.ToString(prospectSelected.MdpProspect);
            }
        }

        private void BtnProspectAdd_Click(object sender, RoutedEventArgs e)
        {
            Prospect addProspect = new Prospect
            {
                NomProspect = Convert.ToString(TxtNom.Text),
                PrenomProspect = Convert.ToString(TxtPrenom.Text),
                AdresseProspect = Convert.ToString(TxtAdresse.Text),
                TelephoneProspect = Convert.ToString(TxtTelephone.Text),
                MailProspect = Convert.ToString(TxtMail.Text),
                MdpProspect = Convert.ToString(TxtMdp.Text)
            };
            baseProspect.AddProspect(addProspect);
            Prospects = baseProspect.SelectProspects();
            ListViewProspects.Items.Refresh();
        }

        private void BtnProspectUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtID.Text))
            {
                Prospect updatedProspect = new Prospect
                {
                    IdProspect = Convert.ToInt32(TxtID.Text),
                    NomProspect = Convert.ToString(TxtNom.Text),
                    PrenomProspect = Convert.ToString(TxtPrenom.Text),
                    AdresseProspect = Convert.ToString(TxtAdresse.Text),
                    TelephoneProspect = Convert.ToString(TxtTelephone.Text),
                    MailProspect = Convert.ToString(TxtMail.Text),
                    MdpProspect = Convert.ToString(TxtMdp.Text)
                };

                baseProspect.UpdateProspect(updatedProspect);
                Prospects = baseProspect.SelectProspects();
                ListViewProspects.Items.Refresh();
            }
        }

        private void BtnProspectDelete_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtID.Text))
            {
                baseProspect.DeleteProspect(Convert.ToInt32(TxtID.Text));
                Prospects = baseProspect.SelectProspects();
                ListViewProspects.Items.Refresh();
            }
        }
    }
}
