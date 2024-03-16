using System.Windows;

namespace BadanieKrwi.Views
{
    /// <summary>
    /// Interaction logic for Twoje_Badanie_Okno.xaml
    /// </summary>
    public partial class TwojeBadanieOkno : Window
    {
        public TwojeBadanieOkno()
        {
            InitializeComponent();
        }
        private void WrocMenu(object sender, RoutedEventArgs e)
        {
            MenuOkno wroc = new MenuOkno();
            wroc.Show();
            this.Close();
        }
    }
}
