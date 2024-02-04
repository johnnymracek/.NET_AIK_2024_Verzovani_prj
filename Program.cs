using System;

namespace Verzovani

{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Získání vstupu od uživatele
            Console.WriteLine("Zadejte #1 číslo:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Zadejte #2 číslo:");
            int num2 = int.Parse(Console.ReadLine());

            // Výpočet průměru
            int prumer = (num1 + num2) / 2;

            // Výsledek
            Console.WriteLine("Průměr ze čísel {0} a {1} je: {2}", num1, num2, prumer);

            // tohle by se melo ulozit :)
        }
    }

}