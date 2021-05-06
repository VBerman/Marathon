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

namespace marathon_session1.PageApp
{
    /// <summary>
    /// Interaction logic for PageContainer.xaml
    /// </summary>
    public partial class PageContainer : Page
    {

        private bool isVisibleLogout;
        public bool IsVisibleLogout
        {
            get => isVisibleLogout;
            set
            {
                isVisibleLogout = value;

                LogoutButton.Visibility = isVisibleLogout ? Visibility.Visible : Visibility.Hidden;

            }
        }

        public PageContainer()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
            else
            {
                NavigationService.Navigate(new StartPage());
            }
        }
    }
}
