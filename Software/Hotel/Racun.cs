using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class Racun
    {
        public DateTime Datum { get; set; }

        public double UkupniIznos { get; set; }

        public string NacinPlacanja { get; set; }

        public bool Placen { get; set; }

        public List<StavkaRacuna> Stavke { get; set; }

        public Racun()
        {

        }
        public double IzracunajUkupniIznos(List<StavkaRacuna> Stavke)
        {
            return IzracunajUkupniIznos(Stavke);
        }



    }
}
