﻿using BadanieKrwi.Models;
using BadanieKrwi.Views;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace BadanieKrwi.ViewModels
{
    public class SzczegolyStezeniaSubstancjiViewModel : KlasaBazowa
    {
        #region Properties
        private SeriesCollection _serieNaWykresie;
        public SeriesCollection SerieNaWykresie
        {
            get => _serieNaWykresie;
            set
            {
                if (_serieNaWykresie != value)
                {
                    _serieNaWykresie = value;
                    OnPropertyChanged();
                }
            }
        }

        private List<string> _etykietyX;
        public List<string> EtykietyX
        {
            get => _etykietyX;
            set
            {
                if (_etykietyX != value)
                {
                    _etykietyX = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _naglowek;
        public string Naglowek
        {
            get => _naglowek;
            set
            {
                if(_naglowek  != value)
                {
                    _naglowek = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion Properties

        #region Commands
        public ICommand WrocCommand { get; set; }
        #endregion Commands

        #region Constructors
        public SzczegolyStezeniaSubstancjiViewModel()
        {
            Inicjalizacja();
        }
        #endregion Constructors

        #region Methods
        #region Main
        private void Inicjalizacja()
        {
            InicjalizacjaWykres(null);
            InicjalizacjaKomend();
        }

        public void InicjalizacjaWykres(string nazwaStezeniaSubstancji)
        {
            if (string.IsNullOrWhiteSpace(nazwaStezeniaSubstancji))
            {
                Naglowek = "Jakaś tam nazwa stężenia substancji";
                SerieNaWykresie = new SeriesCollection()
                {
                    new LineSeries
                    {
                        Values = new ChartValues<int>{2,4,6,7,10,18,20,21,30 }
                    }
                };

                EtykietyX = new List<string> { "2", "4", "6", "7", "10", "18", "20", "21", "30" };

                return;
            }

            Naglowek = nazwaStezeniaSubstancji;
            var inty = GeneratorUnikalnychLiczbCalkowitych(1, 100, 15);
            SerieNaWykresie = new SeriesCollection()
            {
                new LineSeries
                {
                    Values = new ChartValues<int>(inty)
                }
            };

            inty.ForEach(x => EtykietyX.Add(x.ToString()));

        }

        static List<int> GeneratorUnikalnychLiczbCalkowitych(int start, int koniec, int iloscLiczbDoWygenerowania)
        {
            if (iloscLiczbDoWygenerowania > (koniec - start + 1))
            {
                throw new ArgumentException("Liczba unikalnych liczb nie może przekraczać rozmiaru zakresu.");
            }

            List<int> result = new List<int>();
            Random rand = new Random();
            HashSet<int> usedNumbers = new HashSet<int>();

            while (result.Count < iloscLiczbDoWygenerowania)
            {
                int randomNumber = rand.Next(start, koniec + 1);
                if (!usedNumbers.Contains(randomNumber))
                {
                    result.Add(randomNumber);
                    usedNumbers.Add(randomNumber);
                }
            }

            return result;
        }

        private void InicjalizacjaKomend()
        {
            WrocCommand = new RelayCommand(ExecWroc);
        }
        #endregion Main

        private void ExecWroc(object obj)
        {
            if (obj is SzczegolyStezeniaSubstancjiOkno sssOkno)
                sssOkno.Close();
        }

        #endregion Methods
    }
}
