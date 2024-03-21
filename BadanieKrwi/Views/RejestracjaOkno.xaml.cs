using BadanieKrwi.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace BadanieKrwi.Views
{
    /// <summary>
    /// Interaction logic for RejestracjaOkno.xaml
    /// </summary>
    public partial class RejestracjaOkno : Window
    {
        public RejestracjaOkno()
        {
            InitializeComponent();
        }

        private void inputHaslo_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (DataContext is RejestracjaViewModel rvm && sender is PasswordBox pb)
            {
                rvm.Haslo = pb.Password;
            }
        }

        private void inputPowHaslo_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (DataContext is RejestracjaViewModel rvm && sender is PasswordBox pb)
            {
                rvm.PowtorzHaslo = pb.Password;
            }
        }
    }
}
