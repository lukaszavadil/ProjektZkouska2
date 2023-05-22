using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZkouska2
{
    class Databaze
    {
        private List<Zaznam> zaznamy;

        public Databaze()
        {
            zaznamy = new List<Zaznam>();
        }

        public void PridejPojistence(string jmeno, string prijmeni, int vek, int telefon)
        {
            zaznamy.Add(new Zaznam(jmeno, prijmeni, vek, telefon));
        }

        public Zaznam NajdiPojistencePodleJmenaAPrijmeni(string jmeno, string prijmeni)
        {
            foreach (Zaznam i in zaznamy)
            {
                if ((i.Jmeno == jmeno) && (i.Prijmeni == prijmeni))
                    return i;
            }
            return null;

        }

        public List<Zaznam> NajdiPojistence()
        {
            List<Zaznam> nalezene = new List<Zaznam>();
            foreach (Zaznam i in zaznamy)
            {
                nalezene.Add(i);
            }
            return nalezene;
        }

        public void VypisPojistencu()
        {
            foreach (Zaznam z in zaznamy)
                Console.WriteLine(z);
        }
    }
}
