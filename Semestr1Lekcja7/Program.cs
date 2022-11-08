using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestr1Lekcja7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //użytkownik wpisuje nazwa skróca pierwiastka lub liczba atomowa (np. H     1)

            Console.WriteLine("Podaj skróconą nazwę pierwiastka lub liczbę atomową");
            string danePierwiastka = Console.ReadLine();
            
            if (danePierwiastka == "H" || danePierwiastka == "1")
                Console.WriteLine("Szukany Pierwiastek to --> Wodór");
            else if (danePierwiastka == "CO" || danePierwiastka == "27")
                Console.WriteLine("Szukany Pierwiastek to --> Kobalt");
            else if (danePierwiastka == "K" || danePierwiastka == "19")
                Console.WriteLine("Szukany Pierwiastek to --> Potas");
            else if (danePierwiastka == "AG" || danePierwiastka == "47")
                Console.WriteLine("Szukany Pierwiastek to --> Srebro");
            else if (danePierwiastka == "AU" || danePierwiastka == "79")
                Console.WriteLine("Szukany Pierwiastek to --> Złoto");
            else if (danePierwiastka == "MG" || danePierwiastka == "12")
                Console.WriteLine("Szukany Pierwiastek to --> Magnez");
            else if (danePierwiastka == "HE" || danePierwiastka == "2")
                Console.WriteLine("Szukany Pierwiastek to --> Hel");

            

            Console.ReadLine();
        }
    }
}
