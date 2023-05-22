using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZkouska2
{
    internal class Evidence
    {
        private Databaze databaze;

        public Evidence()
        {
            databaze = new Databaze();
        }

        public void PridejPojistence()
        {
            Console.WriteLine("Zadejte jméno pojištěného: ");
            string jmeno;
            while (string.IsNullOrWhiteSpace(jmeno = Console.ReadLine()))
            {
                Console.WriteLine("Zadejte jméno znovu: ");
            }
            string jmenoBezMezer = jmeno.Trim();
            
            Console.WriteLine("Zadejte příjmení: ");
            string prijmeni;
            while (string.IsNullOrWhiteSpace(prijmeni = Console.ReadLine()))
            {
                Console.WriteLine("Zadejte příjmení znovu: ");
            }
            string prijmeniBezMezer = prijmeni.Trim();
            
            Console.WriteLine("Zadejte telefonní číslo: ");
            int telefon;
            while (!int.TryParse(Console.ReadLine(), out telefon))
                Console.WriteLine("Neplatné číslo, zadejte prosím znovu");
            
            Console.WriteLine("Zadejte věk: ");
            int vek;
            while (!int.TryParse(Console.ReadLine(), out vek))
                Console.WriteLine("Neplatný věk, zadejte prosím znovu");

            databaze.PridejPojistence(jmenoBezMezer, prijmeniBezMezer, vek, telefon);
        }

        public void VyhledejPojistence()
        {
            Console.WriteLine("Zadejte jméno pojištěného: ");
            string jmeno = Console.ReadLine();
            Console.WriteLine("Zadejte příjmení: ");
            string prijmeni = Console.ReadLine();
            Console.WriteLine();
            int vek;
            int telefon;
            // Vyhledání záznamu
            Zaznam zaznam = databaze.NajdiPojistencePodleJmenaAPrijmeni(jmeno, prijmeni);
            // Výpis záznamu
            if (zaznam != null)
            {                
                 Console.WriteLine(zaznam);
            }
            else
                // Nenalezený záznam
                Console.WriteLine("Nebyly nalezeny žádné záznamy.");
        }


        public void VypisPojistencu()
        {
            databaze.VypisPojistencu();
        }

        public void VypisMenu()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Evidence pojištěných");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
        }
    }
}