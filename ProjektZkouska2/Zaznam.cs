using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZkouska2
{
    class Zaznam
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int Vek { get; set; }
        public int Telefon { get; set; }

        public Zaznam(string jmeno, string prijmeni, int vek, int telefon)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            Telefon = telefon;
        }

        public override string ToString()
        {
            return Jmeno + "\t" + Prijmeni + "\t" + Vek + "\t" + Telefon;
        }
    }
}