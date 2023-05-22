using ProjektZkouska2;

namespace ProjektZkouska
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Evidence evidence = new Evidence();
            char volba = '0';
            // hlavní cyklus
            while (volba != '4')
            {
                evidence.VypisMenu();
                Console.WriteLine();
                Console.WriteLine("Vyberte si akci:");
                Console.WriteLine("1 - Přidat nového pojištěného");
                Console.WriteLine("2 - Vypsat všechny pojištěné");
                Console.WriteLine("3 - Vyhledat pojištěného");
                Console.WriteLine("4 - Konec");

                volba = Console.ReadKey().KeyChar;
                Console.WriteLine();
                // reakce na volbu
                switch (volba)
                {
                    case '1':
                        Console.WriteLine();
                        evidence.PridejPojistence();
                        Console.WriteLine();
                        Console.WriteLine("Data byla uložena. Pokračujte libovolnou klávesou...");
                        break;
                    case '2':
                        Console.WriteLine();
                        evidence.VypisPojistencu();
                        Console.WriteLine();
                        Console.WriteLine("Pokračujte libovolnou klávesou...");
                        break;
                    case '3':
                        Console.WriteLine();
                        evidence.VyhledejPojistence();
                        Console.WriteLine();
                        Console.WriteLine("Pokračujte libovolnou klávesou...");
                        break;
                    case '4':
                        Console.WriteLine();
                        Console.WriteLine("Libovolnou klávesou ukončíte program...");
                        break;
                    default:
                        Console.WriteLine("Neplatná volba, stiskněte libovolnou klávesu a opakujte volbu.");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}