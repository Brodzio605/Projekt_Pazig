using System.Windows;

namespace BadanieKrwi.Views
{
    /// <summary>
    /// Interaction logic for BadaniaOkno.xaml
    /// </summary>
    public partial class BadaniaOkno : Window
    {
        public BadaniaOkno()
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
