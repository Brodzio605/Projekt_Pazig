using BadanieKrwi.Models;
using BadanieKrwi.Views;
using System.Windows.Input;

namespace BadanieKrwi.ViewModels
{
    public class StatystykiViewModel : KlasaBazowa
    {
        #region Properties
        public string TwojaIloscBadan { get; set; }
        public string BadanieWTymRoku { get; set; }

        public string SredniCzas { get; set; }

        public string LiczbaErytrocytow { get; set; }
        public string Hemoglobina { get; set; }

        #endregion Properties

        #region Commands
        public ICommand WrocCommand { get; set; }

        #endregion Commands

        #region Constructors
        public StatystykiViewModel()
        {
            Inicjalizacja();
        }
        #endregion Constructors

        #region Methods
        #region Main
        private void Inicjalizacja()
        {
            InicjalizacjaKomend();
        }

        private void InicjalizacjaKomend()
        {
            WrocCommand = new RelayCommand(ExecWroc);
        }

        #endregion Main
        private void ExecWroc(object obj)
        {
            if (obj is StatystykiOkno so)
                so.Close();
        }

        #endregion Methods
    }
}