using System.Windows;

namespace BadanieKrwi.Views
{
    /// <summary>
    /// Interaction logic for BadanieOkno.xaml
    /// </summary>
    public partial class BadanieOkno : Window
    {
        public BadanieOkno()
        {
            InitializeComponent();
        }

        private void WrocMenu(object sender, RoutedEventArgs e)
        {
            MenuOkno wroc = new MenuOkno();
            wroc.Show();
             this.Close();

        }

        private void Edytuj(object sender, RoutedEventArgs e)
        {
            
            

        }
    }
}
