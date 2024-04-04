using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadanieKrwi.Data_Base
{
    public class Uzytkownik
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string HasloHash { get; set; }
    }
}
