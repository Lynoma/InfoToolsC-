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
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow :  Window
    {
        ViewClient viewClient = new ViewClient();
        ViewProspect viewProspect = new ViewProspect();
        ViewProduit viewProduit = new ViewProduit();
        ViewEmploye viewEmploye = new ViewEmploye();

        Brush selectedButton = new SolidColorBrush(Color.FromRgb(45, 51, 67));
        SolidColorBrush baseColor = new SolidColorBrush(Color.FromRgb(35,40,50));
        
        public MainWindow()
        {
            InitializeComponent();

            Main.Content = viewClient;

            NavigationBar.Visibility = Visibility.Hidden;

            Main.Visibility = Visibility.Hidden;

            BtnClients.Background = selectedButton;
        }

        private void BtnFactures_Click(object sender, RoutedEventArgs e)
        {
            ViewFacture viewFacture = new ViewFacture();
            Main.Content = viewFacture;

            ResetColor();
            BtnFactures.Background = selectedButton;
        }

        private void BtnProspects_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = viewProspect;

            ResetColor();
            BtnProspects.Background = selectedButton;
        }

        private void BtnRDV_Click(object sender, RoutedEventArgs e)
        {
            ViewRDV viewRDV = new ViewRDV();
            Main.Content = viewRDV;

            ResetColor();
            BtnRDV.Background = selectedButton;
        }

        private void BtnClients_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = viewClient;

            ResetColor();
            BtnClients.Background = selectedButton;
        }

        private void BtnEmployes_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = viewEmploye;

            ResetColor();
            BtnEmployes.Background = selectedButton;
        }

        private void BtnProduits_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = viewProduit;

            ResetColor();
            BtnProduits.Background = selectedButton;
        }

        private void BtnGraphiques_Click(object sender, RoutedEventArgs e)
        {
            ResetColor();
            BtnGraphiques.Background = selectedButton;
        }

        private void BtnConnexion_Click(object sender, RoutedEventArgs e)
        {
            if(!String.IsNullOrEmpty(TxtEmail.Text) && !String.IsNullOrEmpty(TxtMDP.Text))
            {
                foreach (Employe emp in viewEmploye.Employes)
                {
                    if(emp.MailEmp == TxtEmail.Text)
                        if(emp.MdpEmp == TxtMDP.Text)
                        {
                            Connexion.Visibility = Visibility.Hidden;
                            Main.Visibility = Visibility.Visible;
                            NavigationBar.Visibility = Visibility.Visible;
                        }
                }
            }
        }

        private void MinimizeApp_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void CloseApp_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ResizeApp_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
                return;
            }
            WindowState = WindowState.Maximized;
        }

        private void ResetColor()
        {
            BtnFactures.Background = baseColor;
            BtnEmployes.Background = baseColor;
            BtnGraphiques.Background = baseColor;
            BtnProduits.Background = baseColor;
            BtnProspects.Background = baseColor;
            BtnRDV.Background = baseColor;
            BtnClients.Background = baseColor;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
    }
}
