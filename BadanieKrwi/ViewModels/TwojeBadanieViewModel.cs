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
            InicjalizacjaKomend();
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
