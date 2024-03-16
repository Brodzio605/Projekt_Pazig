using BadanieKrwi.Models;
using BadanieKrwi.Views;
using System.Collections.Generic;
using System.Windows.Input;

namespace BadanieKrwi.ViewModels
{
    public class TwojeBadanieViewModel : KlasaBazowa
    {
        #region Properties
        private List<object> _badania;
        public List<object> Badania
        {
            get => _badania;
            set
            {
                if(_badania != value)
                {
                    _badania = value;
                    OnPropertyChanged();
                }
            }
        }

        private object _wybraneBadanie;
        public object WybraneBadanie
        {
            get => _wybraneBadanie;
            set
            {
                if(_wybraneBadanie != value)
                {
                    _wybraneBadanie = value;
                    OnPropertyChanged();
                }
            }
        }

        #region Commands
        public ICommand SzczegolyCommand { get; set; }
        public ICommand WrocCommand { get; set; }

        #endregion Commands

        #endregion Properties

        #region Constructors
        public TwojeBadanieViewModel()
        {
            Inicjalizacja();
        }
        #endregion Constructors

        #region Methods
        #region Main

        private void Inicjalizacja()
        {
            InicjalizacjaBadan();
            InicjalizacjaKomend();
        }

        private void InicjalizacjaBadan()
        {
            _badania = new List<object>();
        }

        private void InicjalizacjaKomend()
        {
            SzczegolyCommand = new RelayCommand(ExecSzczegolyCommand, x => WybraneBadanie != null);
            WrocCommand = new RelayCommand(ExecWrocCommand);
        }

        #endregion Main

        private void ExecWrocCommand(object obj)
        {
            if (obj is TwojeBadanieOkno tbo)
            {
               // dorobic nastepnym razem ;) 
            }
        }

        private void ExecSzczegolyCommand(object obj)
        {
            
        }
        #endregion Methods















    }
}
