using BadanieKrwi.Models;
using BadanieKrwi.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Windows.Input;


namespace BadanieKrwi.ViewModels
{
    public class KlinikiViewModel : KlasaBazowa
    {
        
        #region Properties
        private ObservableCollection<Klinika> _kliniki;
        public ObservableCollection<Klinika> Kliniki
        {
            get => _kliniki;
            set
            {
                if(_kliniki != value)
                {
                    _kliniki = value;
                    OnPropertyChanged();
                }
            }
        }
        private Klinika _wybranaKlinika;
        public Klinika WybranaKlinika
        {
            get => _wybranaKlinika;
            set
            {
                if(_wybranaKlinika != value)
                {
                    _wybranaKlinika = value;
                    NowaKlinika = new Klinika(_wybranaKlinika);
                    OnPropertyChanged();
                }
            }
        }

        private Klinika _nowaKlinika;
        public Klinika NowaKlinika
        {
            get => _nowaKlinika;
            set
            {
                if(_nowaKlinika != value)
                {
                    _nowaKlinika = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool czyMoznaZapisac
        => NowaKlinika?.Id != Guid.NewGuid()
            && !string.IsNullOrWhiteSpace(NowaKlinika?.Informacja)
            && !string.IsNullOrWhiteSpace(NowaKlinika?.Adres)
            && !string.IsNullOrWhiteSpace(NowaKlinika?.Telefon);
        #endregion Properties

        #region Commands
        public ICommand WrocCommand { get; set; }
        public ICommand ZapiszCommand { get; set; }
        public ICommand NowyCommand { get; set; }

        #endregion Commands

        #region Constructors
        public KlinikiViewModel()
        {
            Inicjalizacja();
            WczytajKliniki();
        }
        #endregion Constructors

        #region Methods
        #region Main
        private void Inicjalizacja()
        {
            //Kliniki = new ObservableCollection<Klinika>()
            //{
                 
            //};

            //WybranaKlinika = Kliniki[0];
            InicjalizacjaKomend();
        }

        private void InicjalizacjaKomend()
        {
            WrocCommand = new RelayCommand(ExecWroc);
            ZapiszCommand = new RelayCommand(ExecZapisz, x => czyMoznaZapisac);
            NowyCommand = new RelayCommand(ExecNowy);
        }

        private bool Aktualizuj()
        {
            if (WybranaKlinika != null)
            {
                
                WybranaKlinika.AktualizujKlinike(NowaKlinika);
                App.Baza.Update(WybranaKlinika);
                return App.Baza.SaveChanges() > 0;
            }
            else if (WybranaKlinika==null)
            {
                App.Baza.Add(NowaKlinika);
                return App.Baza.SaveChanges() > 0;
            }
            return false;
            
        }

        #endregion Main
        private void ExecWroc(object obj)
        {
            if (obj is KlinikiOkno ko)
                ko.Close();
        }

        private void ExecZapisz(object obj)
        {
            if (obj is KlinikiOkno ko && Aktualizuj())
                ko.Close();
        }

        private void ExecNowy(object obj)
        {
            WybranaKlinika = null;
            NowaKlinika = new Klinika() { Id = Guid.NewGuid() };
        }
        private void WczytajKliniki()
        {
            // inicjalizacja kolekcji, w parametrze przekazujemy cala liste, zaczytujemy wszytskuch pacjentów
            Kliniki = new ObservableCollection<Klinika>(App.Baza.Kliniki.ToList());
        }
        #endregion Methods 
    }
}