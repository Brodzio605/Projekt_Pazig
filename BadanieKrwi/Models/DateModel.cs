﻿using System;
using System.Collections.Generic;

namespace BadanieKrwi.Models
{
    public class DateModel
    {
        public DateTime GotowaData => new DateTime(Data.Year, Data.Month, Data.Day
            , Godzina, Minuta, 0);

        public DateTime Data { get; set; }
        public int Godzina { get; set; }
        public int Minuta { get; set; }

        public List<int> Godziny { get; private set; }
        public List<int> Minuty { get; private set; }

        public DateModel()
        {
            Inicjalizacja();
        }

        private void Inicjalizacja()
        {
            Data = DateTime.Now;
            Godzina = Data.Hour;
            Minuta = Data.Minute;

            InicjalizacjaGodzin();
            InicjalizacjaMinut();
        }

        private void InicjalizacjaGodzin()
        {
            Godziny = new List<int>();
            for (int i = 1; i <= 24; i++)
                Godziny.Add(i);
        }

        private void InicjalizacjaMinut()
        {
            Minuty = new List<int>();
            for (int i = 1; i <= 60; i++)
                Minuty.Add(i);
        }
    }
}