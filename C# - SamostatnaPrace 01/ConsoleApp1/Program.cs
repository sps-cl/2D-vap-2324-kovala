using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Zadej sekvenci čísel oddělených čárkou:");
                string input = Console.ReadLine();

                try
                {
                    int[] cisla = input.Split(',').Select(int.Parse).ToArray();

                    int min = cisla.Min();
                    int max = cisla.Max();
                    int maxDelkaIntervalu = GetMaxIncreasingSequenceLength(cisla);

                    Console.WriteLine($"Nejmenší číslo je {min}.");
                    Console.WriteLine($"Největší číslo je {max}.");
                    Console.WriteLine($"Délka nejdelšího vzestupného intervalu je {maxDelkaIntervalu}.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Chyba: Zadávejte pouze celá čísla oddělená čárkou.");
                }
            }
        }

        static int GetMaxIncreasingSequenceLength(int[] cisla)
        {
            int maxDelka = 0;
            int aktualniDelka = 1;

            for (int i = 1; i < cisla.Length; i++)
            {
                if (cisla[i] > cisla[i - 1])
                {
                    aktualniDelka++;
                    maxDelka = Math.Max(maxDelka, aktualniDelka);
                }
                else
                {
                    aktualniDelka = 1;
                }
            }

            return maxDelka;
        }
    }
}