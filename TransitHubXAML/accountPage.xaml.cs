using System;
using System.Collections.Generic;
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

namespace TransitHubXAML
{
    /// <summary>
    /// Interaction logic for accountPage.xaml
    /// </summary>
    public partial class accountPage : Page
    {
        public accountPage()
        {
            InitializeComponent();
        }
        private void Name_Loaded(object sender, RoutedEventArgs e)
        {
            name.Content = User.firstName + " " + User.lastName;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AccountEditPage());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AccountPaymentMethodsPage());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AccountReceiptsPage());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new VerificationPage());
        }
        private void Logout(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new LogoutConfirmationPage());
        }
    }
}
