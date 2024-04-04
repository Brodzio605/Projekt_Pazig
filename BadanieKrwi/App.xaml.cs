using BadanieKrwi.Data_Base;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace BadanieKrwi
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static AppDbContext Baza { get; set; }


        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Baza = new AppDbContext();
        }
    }
}
