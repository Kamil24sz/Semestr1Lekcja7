using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep_internetowy_ćwiczenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w naszym sklepie");
            Console.WriteLine("Wybierz interesujący Cię produkt");

            float cena1 = 200f;
            float cena2 = 150f;
            float cena3 = 30f;
            const string KOD = "giganci2022";
            bool znizka = false;

            Console.WriteLine($"1 - Klawiatura Gamingowa Logitech - {cena1}zł");
            Console.WriteLine($"2 - Mysz Dell - {cena2}zł");
            Console.WriteLine($"3 - Podkładka po mysz - {cena3}zł");

            int wybór = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj kod promocyjny");
            string kodUzytkownika = Console.ReadLine();
            if (kodUzytkownika == KOD)
                znizka = true;


            if(wybór == 1)
            {
                if(znizka)
                    Console.WriteLine($"Do zapłaty {cena1 * 0.85}zł");
                else
                    Console.WriteLine($"Do zapłaty {cena1}zł");
            }
            else if (wybór == 2)
            {
                if(znizka)
                    Console.WriteLine($"Do zapłaty {cena2 * 0.85}zł");
                else
                    Console.WriteLine($"Do zapłaty {cena2}zł");
            }
            else if (wybór == 3)
            {
                if(znizka)
                    Console.WriteLine($"Do zapłaty {cena3 * 0.85}zł");
                else
                    Console.WriteLine($"Do zapłaty {cena3}zł");
            }   


            Console.ReadLine();

        }
    }
}
