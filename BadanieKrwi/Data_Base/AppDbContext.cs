using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Storage;

namespace BadanieKrwi.Data_Base
{
    public class AppDbContext : DbContext
    {
        private readonly string _connString = ConfigurationManager
                                            .ConnectionStrings["ConnectionString"].ConnectionString;
    
        public DbSet<Uzytkownik> Uzytkownik { get; set; }
        public DbSet<Badania> Badania { get; set; }
        public DbSet<Kliniki> Kliniki { get; set; }

        public AppDbContext()
        {
            Database.EnsureCreated();
        }

        // uzycie SQL serwera i connectionString, który jest odczytywany z App.config
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_connString);
        }
    }
    
}
