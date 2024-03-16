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
                badanieWindow.Closing += ((sender, args) =>
                {
                    m.ShowInTaskbar = true;
                    m.WindowState = System.Windows.WindowState.Normal;
                });
                
                m.WindowState = System.Windows.WindowState.Minimized;
                m.ShowInTaskbar = false;
                badanieWindow.Show();
            }
        }

        private void ExecTwojeBadanieWidok(object obj)
        {
            if (obj is MenuOkno m)
            {
                TwojeBadanieOkno badanieWindow = new TwojeBadanieOkno();
                badanieWindow.Show();
                m.Close();
            }
        }

        private void ExecKalendarzWidok(object obj)
        {
            if (obj is MenuOkno m)
            {
                KalendarzBadanOkno kalendarz = new KalendarzBadanOkno();
                kalendarz.Show();
                m.Close();
            }
        }

        private void ExecKlinikiWidok(object obj)
        {
            if (obj is MenuOkno m)
            {
                KlinikiOkno klinikiWindow = new KlinikiOkno();
                klinikiWindow.Show();
                m.Close();
            }
        }

        private void ExecStatystykiWidok(object obj)
        {
            if (obj is MenuOkno m)
            {
                //Statystyki statystyki = new Kliniki();
                //statystyki.Show();
                m.Close();
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