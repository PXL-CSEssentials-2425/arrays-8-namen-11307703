using System;
using System.Runtime.CompilerServices;


namespace Namen
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("==Namen in een array stockeren en afdrukken==");
            Console.WriteLine();


            Console.Write("Hoeveel namen wens je te beheren?: ");
            int aantalNamen = int.Parse(Console.ReadLine());

            string[] namen = new string[aantalNamen];
            for (int i = 0; i < namen.Length; i++)
            {
                Console.Write($"Geef naam {i+1}/{namen.Length}: ");
                namen[i] = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("==Namen afdrukken==");
            Console.WriteLine();
            for (int i = 0; i < namen.Length; i++)
            {
                Console.WriteLine($"Naam {i + 1} is {namen[i]}");
            }

            Console.ReadKey(true);
        }
    }
}
