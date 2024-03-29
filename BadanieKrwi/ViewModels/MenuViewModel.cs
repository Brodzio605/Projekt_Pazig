﻿using BadanieKrwi.Models;
using BadanieKrwi.Views;
using System;
using System.Windows.Input;

namespace BadanieKrwi.ViewModels
{
    public class MenuViewModel : KlasaBazowa
    {
        #region Properties

        public ICommand NoweBadanieCommand { get;set; }
        public ICommand TwojeBadaniaCommand { get; set; }
        public ICommand KalendarzBadanCommand { get; set; }
        public ICommand KlinikiCommand { get; set; }
        public ICommand StatystykiCommand { get; set; }
        public ICommand InformacjeCommand { get; set; }

        #endregion Properties

        #region Constructors
        public MenuViewModel()
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
            NoweBadanieCommand = new RelayCommand(ExecNoweBadanieWidok);
            TwojeBadaniaCommand = new RelayCommand(ExecTwojeBadanieWidok);
            KalendarzBadanCommand = new RelayCommand(ExecKalendarzWidok);
            KlinikiCommand = new RelayCommand(ExecKlinikiWidok);
            StatystykiCommand = new RelayCommand(ExecStatystykiWidok);
            InformacjeCommand = new RelayCommand(ExecInformacjeWidok);
        }

        #endregion Main
        private void ExecNoweBadanieWidok(object obj)
        {
            if(obj is MenuOkno m)
            {
                NoweBadanieOkno badanieWindow = new NoweBadanieOkno();
                (badanieWindow.DataContext as NoweBadaniaViewModel).NoweBadanie.CzyZmodyfikowano = false;
                if (badanieWindow.ShowDialog().Value)
                {

                }
            }
        }

        private void ExecTwojeBadanieWidok(object obj)
        {
            if (obj is MenuOkno m)
            {
                TwojeBadanieOkno badanieWindow = new TwojeBadanieOkno();
                badanieWindow.ShowDialog();
            }
        }

        private void ExecKalendarzWidok(object obj)
        {
            if (obj is MenuOkno m)
            {
                KalendarzBadanOkno kalendarz = new KalendarzBadanOkno();
                kalendarz.ShowDialog();
            }
        }

        private void ExecKlinikiWidok(object obj)
        {
            if (obj is MenuOkno m)
            {
                KlinikiOkno klinikiWindow = new KlinikiOkno();
                klinikiWindow.ShowDialog();
            }
        }

        private void ExecStatystykiWidok(object obj)
        {
            if (obj is MenuOkno m)
            {
                StatystykiOkno statystyki = new StatystykiOkno();
                statystyki.ShowDialog();
            }
        }

        private void ExecInformacjeWidok(object obj)
        {
            if (obj is MenuOkno m)
            {
                
                m.Close();
            }
        }
        #endregion Methods
    }
}
