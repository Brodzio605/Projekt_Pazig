using System.Windows;

namespace BadanieKrwi.Views
{
    /// <summary>
    /// Interaction logic for KlinikiOkno.xaml
    /// </summary>
    public partial class KlinikiOkno : Window
    {
        public KlinikiOkno()
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
