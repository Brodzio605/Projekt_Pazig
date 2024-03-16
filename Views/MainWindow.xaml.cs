using BadanieKrwi.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace BadanieKrwi.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void inputHaslo_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (DataContext is MainWindowViewModel vm && sender is PasswordBox pb)
            {
                vm.Haslo = pb.Password;
            }
        }
    }
}
