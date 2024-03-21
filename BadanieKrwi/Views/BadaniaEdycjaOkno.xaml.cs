using System.Windows;

namespace BadanieKrwi.Views
{
    /// <summary>
    /// Interaction logic for BadaniaEdycjaOkno.xaml
    /// </summary>
    public partial class BadaniaEdycjaOkno : Window
    {
        public BadaniaEdycjaOkno()
        {
            InitializeComponent();
        }
        private void WrocMenu(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Czy na pewno chcesz cofnąć? Twoje dane nie zostaną zapisane", "Powrót", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                BadaniaOkno wroc = new BadaniaOkno();
                wroc.Show();
                this.Close();
            }
        }

        private void Zapisz(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Twoje dane zostały zapisane", "Powrót", MessageBoxButton.OK, MessageBoxImage.Information);
            if (result == MessageBoxResult.OK)
            {
                MenuOkno zapisz = new MenuOkno();
                zapisz.Show();
                this.Close();
            }

        }
    }
}
