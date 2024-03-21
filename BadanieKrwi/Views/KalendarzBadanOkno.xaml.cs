using System.Windows;

namespace BadanieKrwi.Views
{
    /// <summary>
    /// Interaction logic for KalendarzBadanOkno.xaml
    /// </summary>
    public partial class KalendarzBadanOkno : Window
    {
        public KalendarzBadanOkno()
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
