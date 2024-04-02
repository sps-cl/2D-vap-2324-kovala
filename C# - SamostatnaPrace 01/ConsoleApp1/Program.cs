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
            Console.WriteLine("Zadej sekvenci čísel.");
            string input = Console.ReadLine();
            string[] cislaString = input.Split(',');
            int minCislo = int.MaxValue;
            int maxCislo = int.MinValue;
            int aktualniInterval = 1;
            int maxInterval = 1;
            int predesleCislo = int.MinValue;

            foreach (string cisloString in cislaString)
            {
                if (int.TryParse(cisloString, out int cislo))
                {
                    if (cislo < minCislo)
                    {
                        minCislo = cislo;
                    }

                    if (cislo > maxCislo)
                    {
                        maxCislo = cislo;
                    }

                    if (predesleCislo < cislo)
                    {
                        aktualniInterval++;
                    }
                    else
                    {
                        if (aktualniInterval > maxInterval)
                        {
                            maxInterval = aktualniInterval;
                        }

                        aktualniInterval = 1;
                    }

                    predesleCislo = cislo;
                }
                else
                {
                    Console.WriteLine("Nezadali jste platné číslo. Zadejte sekvenci čísel znovu.");
                    Main(args);
                }
            }

            if (aktualniInterval > maxInterval)
            {
                maxInterval = aktualniInterval;
            }

            Console.WriteLine($"Nejmenší číslo je {minCislo}.");
            Console.WriteLine($"Největší číslo je {maxCislo}.");
            Console.WriteLine($"Délka nejdelšího vzestupného intervalu je {maxCislo}.");
        }
    }
}