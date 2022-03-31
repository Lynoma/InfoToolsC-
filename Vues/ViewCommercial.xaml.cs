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
    /// Logique d'interaction pour ViewCommercial.xaml
    /// </summary>
    public partial class ViewCommercial : UserControl, INotifyPropertyChanged
    {
        static bddCommercial baseCommercial = new bddCommercial();
        public ViewCommercial()
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

        ObservableCollection<Commercial> _Commercials = baseCommercial.SelectCommercials();

        

        public ObservableCollection<Commercial> Commercials
        {
            get { return _Commercials; }
            set 
            { 
                _Commercials = value;
                OnPropertyChanged(nameof(Commercials));
            }
        }

        public void Commercial_selectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Commercial CommercialSelected = (Commercial)ListViewCommercials.SelectedItem;

            if (CommercialSelected != null)
            {
                TxtID.Text = Convert.ToString(CommercialSelected.IdCom);
                TxtNom.Text = Convert.ToString(CommercialSelected.NomCom);
                TxtPrenom.Text = Convert.ToString(CommercialSelected.PrenomCom);
                TxtAdresse.Text = Convert.ToString(CommercialSelected.AdresseCom);
                TxtTelephone.Text = Convert.ToString(CommercialSelected.TelephoneCom);
                TxtMail.Text = Convert.ToString(CommercialSelected.MailCom);
                TxtMdp.Text = Convert.ToString(CommercialSelected.MdpCom);
            }
        }

        private void BtnCommercialAdd_Click(object sender, RoutedEventArgs e)
        {
            Commercial addCommercial = new Commercial
            {
                NomCom = Convert.ToString(TxtNom.Text),
                PrenomCom = Convert.ToString(TxtPrenom.Text),
                AdresseCom = Convert.ToString(TxtAdresse.Text),
                TelephoneCom = Convert.ToString(TxtTelephone.Text),
                MailCom = Convert.ToString(TxtMail.Text),
                MdpCom = Convert.ToString(TxtMdp.Text)
            };
            baseCommercial.AddCommercial(addCommercial);
            Commercials = baseCommercial.SelectCommercials();
            ListViewCommercials.Items.Refresh();
        }

        private void BtnCommercialUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtID.Text))
            {
                Commercial updatedCommercial = new Commercial
                {
                    IdCom = Convert.ToInt32(TxtID.Text),
                    NomCom = Convert.ToString(TxtNom.Text),
                    PrenomCom = Convert.ToString(TxtPrenom.Text),
                    AdresseCom = Convert.ToString(TxtAdresse.Text),
                    TelephoneCom = Convert.ToString(TxtTelephone.Text),
                    MailCom = Convert.ToString(TxtMail.Text),
                    MdpCom = Convert.ToString(TxtMdp.Text)
                };

                baseCommercial.UpdateCommercial(updatedCommercial);
                Commercials = baseCommercial.SelectCommercials();
                ListViewCommercials.Items.Refresh();
            }   
        }

        private void BtnCommercialDelete_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtID.Text))
            {
                baseCommercial.DeleteCommercial(Convert.ToInt32(TxtID.Text));
                Commercials = baseCommercial.SelectCommercials();
                ListViewCommercials.Items.Refresh();
            }
        }
    }
}
