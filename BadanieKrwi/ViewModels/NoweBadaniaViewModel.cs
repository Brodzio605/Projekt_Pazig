using BadanieKrwi.Models;
using BadanieKrwi.Views;
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Input;

namespace BadanieKrwi.ViewModels
{
    public class NoweBadaniaViewModel : KlasaBazowa
    {
        #region Properties

        private DateTime _dataBadania;
        public DateTime DataBadania
        {
            get => _dataBadania;
            set
            {
                if (_dataBadania != value)
                {
                    _dataBadania = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _nazwaKliniki;
        public string NazwaKliniki
        {
            get => _nazwaKliniki;
            set
            {
                if (_nazwaKliniki != value)
                {
                    _nazwaKliniki = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _stezenieErytrocytowRbc;
        public int StezenieErytrocytowRbc
        {
            get => _stezenieErytrocytowRbc;
            set
            {
                if (_stezenieErytrocytowRbc != value)
                {
                    _stezenieErytrocytowRbc = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _hemoglobinaHb;
        public int HemoglobinaHb
        {
            get => _hemoglobinaHb;
            set
            {
                if (_hemoglobinaHb != value)
                {
                    _hemoglobinaHb = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _hematokrytHtc;
        public int HematokrytHtc
        {
            get => _hematokrytHtc;
            set
            {
                if (_hematokrytHtc != value)
                {
                    _hematokrytHtc = value;
                    OnPropertyChanged();
                }
            }
        }

        private double _sredniaObjetoscErytrocytuMcv;
        public double SredniaObjetoscErytrocytuMcv
        {
            get => _sredniaObjetoscErytrocytuMcv;
            set
            {
                if (_sredniaObjetoscErytrocytuMcv != value)
                {
                    _sredniaObjetoscErytrocytuMcv = value;
                    OnPropertyChanged();
                }
            }
        }

        private double _sredniaMasaHemoglobinyWErytrocycieMch;
        public double SredniaMasaHemoglobinyWErytrocycieMch
        {
            get => _sredniaMasaHemoglobinyWErytrocycieMch;
            set
            {
                if (_sredniaMasaHemoglobinyWErytrocycieMch != value)
                {
                    _sredniaMasaHemoglobinyWErytrocycieMch = value;
                    OnPropertyChanged();
                }
            }
        }

        private double _srednieStezenieHemoglobinyWErytrocytachMchc;
        public double SrednieStezenieHemoglobinyWErytrocytachMchc
        {
            get => _srednieStezenieHemoglobinyWErytrocytachMchc;
            set
            {
                if (_srednieStezenieHemoglobinyWErytrocytachMchc != value)
                {
                    _srednieStezenieHemoglobinyWErytrocytachMchc = value;
                    OnPropertyChanged();
                }
            }
        }

        private double _rozpietoscRozkladuObjetosciErytrocytowRdwCw;
        public double RozpietoscRozkladuObjetosciErytrocytowRdwCw
        {
            get => _rozpietoscRozkladuObjetosciErytrocytowRdwCw;
            set
            {
                if (_rozpietoscRozkladuObjetosciErytrocytowRdwCw != value)
                {
                    _rozpietoscRozkladuObjetosciErytrocytowRdwCw = value;
                    OnPropertyChanged();
                }
            }
        }

        private double _retikulocytyRc;
        public double RetikulocytyRc
        {
            get => _retikulocytyRc;
            set
            {
                if (_retikulocytyRc != value)
                {
                    _retikulocytyRc = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _stezenieLeukocytowWbc;
        public int StezenieLeukocytowWbc
        {
            get => _stezenieLeukocytowWbc;
            set
            {
                if (_stezenieLeukocytowWbc != value)
                {
                    _stezenieLeukocytowWbc = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _neutrofile;
        public int Neutrofile
        {
            get => _neutrofile;
            set
            {
                if (_neutrofile != value)
                {
                    _neutrofile = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _bazofile;
        public int Bazofile
        {
            get => _bazofile;
            set
            {
                if (_bazofile != value)
                {
                    _bazofile = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _eozynofile;
        public int Eozynofile
        {
            get => _eozynofile;
            set
            {
                if (_eozynofile != value)
                {
                    _eozynofile = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _limfocyty;
        public int Limfocyty
        {
            get => _limfocyty;
            set
            {
                if (_limfocyty != value)
                {
                    _limfocyty = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _monocyty;
        public int Monocyty
        {
            get => _monocyty;
            set
            {
                if (_monocyty != value)
                {
                    _monocyty = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _plytkiKrwiPlt;
        public int PlytkiKrwiPlt
        {
            get => _plytkiKrwiPlt;
            set
            {
                if (_plytkiKrwiPlt != value)
                {
                    _plytkiKrwiPlt = value;
                    OnPropertyChanged();
                }
            }
        }

        private double _sredniaObjetoscKrwiMpv;
        public double SredniaObjetoscKrwiMpv
        {
            get => _sredniaObjetoscKrwiMpv;
            set
            {
                if (_sredniaObjetoscKrwiMpv != value)
                {
                    _sredniaObjetoscKrwiMpv = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool _czyZapisac
            => DataBadania <= new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)
            && DataBadania > new DateTime(1900)
            && !string.IsNullOrWhiteSpace(NazwaKliniki)
            && _czyStezenieErytrocytowJestOk
            && _czyHemoglobina
            && _czyHematokryt
            && _czySredniaObjErytrocytow
            && _czySredniaMasaHemoglobiny
            && _czySrednieStezenieHemoglobiny
            && _czyRozpietoscRozkladu_Obj_Erytrocytow
            && _czyRetikulocyty
            && _czyStezenieLeukocytow
            && _czyNeutrofile
            && _czyBazofile
            && _czyEozynofile
            && _czyLimfocyty
            && _czyMonocyty
            && _czyPlytkiKrwi
            && _czySredniaObj
            ;

        private bool _czyStezenieErytrocytowJestOk => _stezenieErytrocytowRbc > 0;
        private bool _czyHemoglobina => _hemoglobinaHb > 0;
        private bool _czyHematokryt => _hematokrytHtc > 0;
        private bool _czySredniaObjErytrocytow => _sredniaObjetoscErytrocytuMcv > 0;
        private bool _czySredniaMasaHemoglobiny => _sredniaMasaHemoglobinyWErytrocycieMch > 0;
        private bool _czySrednieStezenieHemoglobiny => _srednieStezenieHemoglobinyWErytrocytachMchc > 0;

        private bool _czyRozpietoscRozkladu_Obj_Erytrocytow => _rozpietoscRozkladuObjetosciErytrocytowRdwCw > 0;

        private bool _czyRetikulocyty => _retikulocytyRc > 0;
        private bool _czyStezenieLeukocytow => _stezenieLeukocytowWbc > 0;

        private bool _czyNeutrofile => _neutrofile > 0;

        private bool _czyBazofile => _bazofile > 0;

        private bool _czyEozynofile => _eozynofile > 0;

        private bool _czyLimfocyty => _limfocyty > 0;
        private bool _czyMonocyty => _monocyty > 0;

        private bool _czyPlytkiKrwi => _plytkiKrwiPlt > 0;

        private bool _czySredniaObj => _sredniaObjetoscKrwiMpv > 0;
        #endregion Properties

        #region Commands
        public ICommand WrocCommand { get; set; }
        public ICommand ZapiszCommand { get; set; }

        #endregion Commands

        #region Constructors
        public NoweBadaniaViewModel()
        {
            Inicializacja();
        }

        #endregion Constructors

        #region Methods
        #region Main
        private void Inicializacja()
        {
            _dataBadania = DateTime.Now;

            InicjalizacjaKomend();
        }

        private void InicjalizacjaKomend()
        {
            WrocCommand = new RelayCommand(ExecWroc);
            ZapiszCommand = new RelayCommand(ExecZapisz, x => _czyZapisac);
        }

        #endregion Main

        private void ExecWroc(object obj)
        {
            if (obj is NoweBadanieOkno nbo)
            {
                MessageBoxResult result = MessageBox.Show("Czy na pewno chcesz cofnąć? Twoje dane nie zostaną zapisane", "Powrót", MessageBoxButton.YesNo, MessageBoxImage.Warning);

                if (result == MessageBoxResult.Yes)
                    nbo.Close();
            }

        }

        private void ExecZapisz(object obj)
        {
            if (obj is NoweBadanieOkno nbo)
            {
                MessageBoxResult result = MessageBox.Show("Twoje dane zostały zapisane", "Powrót", MessageBoxButton.OK, MessageBoxImage.Information);
                if (result == MessageBoxResult.OK)
                    nbo.Close();
            }
        }
        #endregion Methods
    }
}