using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Program care va afisa ultima cifra a unui numar intreg citit de la tastaura*/

            int i;
            int lastDigit;

            Console.WriteLine("Introduceti numarul:" + "\n");
            i=int.Parse(Console.ReadLine());

            lastDigit = i % 10;

            Console.WriteLine("\n" + "Ultima cifra a numarului introdus este " + lastDigit + ".");

        }
    }
}
