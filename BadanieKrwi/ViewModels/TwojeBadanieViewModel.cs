using BadanieKrwi.Models;
using BadanieKrwi.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Linq;

namespace BadanieKrwi.ViewModels
{
    public class TwojeBadanieViewModel : KlasaBazowa
    {
        #region Properties
        private ObservableCollection<BadanieModel> _badania;
        public ObservableCollection<BadanieModel> Badania
        {
            get => _badania;
            set
            {
                if (_badania != value)
                {
                    _badania = value;
                    OnPropertyChanged();
                }
            }
        }

        private BadanieModel _wybraneBadanie;
        public BadanieModel WybraneBadanie
        {
            get => _wybraneBadanie;
            set
            {
                if (_wybraneBadanie != value)
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
            WczytajBadania();
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
            _badania = new ObservableCollection<BadanieModel>()
            {
                 new BadanieModel()
                 {
                     NazwaBadania = "Badanie ",
                     NazwaKliniki = "Klinika ",
                     DataBadania = DateTime.Now,
                     PlytkiKrwiPlt = 1,
                     SredniaObjetoscKrwiMpv = 2,
                     Monocyty = 3,
                     Bazofile = 1,
                     Eozynofile = 14,
                     HematokrytHtc = 15,
                     HemoglobinaHb  = 22,
                     Limfocyty = 33,
                     Neutrofile  = 23,
                     RetikulocytyRc = 15,
                     RozpietoscRozkladuObjetosciErytrocytowRdwCw = 1,
                     SredniaMasaHemoglobinyWErytrocycieMch = 4,
                     SredniaObjetoscErytrocytuMcv = 7,
                     SrednieStezenieHemoglobinyWErytrocytachMchc = 3,
                     StezenieErytrocytowRbc = 4,
                     StezenieLeukocytowWbc = 4,
                     Zelazo = 2,
                     Magnez = 1
                 },
                 new BadanieModel()
                 {
                     NazwaBadania = "Badanie 2",
                     NazwaKliniki = "Klinika 2",
                     DataBadania = DateTime.Now.AddDays(2),
                     PlytkiKrwiPlt = 1,
                     SredniaObjetoscKrwiMpv = 2,
                     Monocyty = 4,
                     Bazofile = 1,
                     Eozynofile = 14,
                     HematokrytHtc = 15,
                     HemoglobinaHb  = 22,
                     Limfocyty = 22,
                     Neutrofile  = 25,
                     RetikulocytyRc = 7,
                     RozpietoscRozkladuObjetosciErytrocytowRdwCw = 1,
                     SredniaMasaHemoglobinyWErytrocycieMch = 9,
                     SredniaObjetoscErytrocytuMcv = 2,
                     SrednieStezenieHemoglobinyWErytrocytachMchc = 3,
                     StezenieErytrocytowRbc = 4,
                     StezenieLeukocytowWbc = 4,
                     Zelazo = 2,
                     Magnez = 1
                 },
                 new BadanieModel()
                 {
                     NazwaBadania = "Badanie 3",
                     NazwaKliniki = "Klinika 3",
                     DataBadania = DateTime.Now.AddDays(1).AddHours(4),
                     PlytkiKrwiPlt = 1,
                     SredniaObjetoscKrwiMpv = 2,
                     Monocyty = 34,
                     Bazofile = 12,
                     Eozynofile = 9,
                     HematokrytHtc = 7,
                     HemoglobinaHb  = 22,
                     Limfocyty = 15,
                     Neutrofile  = 23,
                     RetikulocytyRc = 15,
                     RozpietoscRozkladuObjetosciErytrocytowRdwCw = 1,
                     SredniaMasaHemoglobinyWErytrocycieMch = 4,
                     SredniaObjetoscErytrocytuMcv = 5,
                     SrednieStezenieHemoglobinyWErytrocytachMchc = 5,
                     StezenieErytrocytowRbc = 6,
                     StezenieLeukocytowWbc = 7,
                     Zelazo = 2,
                     Magnez = 1
                 },
            };
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
                tbo.Close();
        }

        private void ExecSzczegolyCommand(object obj)
        {
            BadanieOkno bo = new BadanieOkno();
            (bo.DataContext as BadanieViewModel).NaglowekOkna = $"Szczegóły Badnia: {WybraneBadanie.NazwaBadania}";
            (bo.DataContext as BadanieViewModel).OryginalneBadanie = WybraneBadanie;
            (bo.DataContext as BadanieViewModel).WybraneBadanie = new BadanieModel(WybraneBadanie);
            if(bo.ShowDialog().Value)
            {
                Badania[Badania.IndexOf(WybraneBadanie)] = (bo.DataContext as BadanieViewModel).WybraneBadanie;
            }
            WybraneBadanie = null;
        }
        private void WczytajBadania()
        {
            // inicjalizacja kolekcji, w parametrze przekazujemy cala liste, zaczytujemy wszytskuch pacjentów
            Badania = new ObservableCollection<BadanieModel>(App.Baza.Badania.ToList());
        }
        #endregion Methods

    }
}
