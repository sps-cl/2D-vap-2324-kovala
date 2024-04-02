using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uvod
{
    class Program
    {
        static void Main(string[] args)
        {
            int vysledek;
            Console.WriteLine("Vložte první číslo.");
            int c1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Vložte druhé číslo.");
            int c2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Vložte znaménko, který chcete použít. (+ , - , * , /)");
            string znamenko = Console.ReadLine();

            switch (znamenko)
            {
                case "+":
                    vysledek = c1 + c2;
                    Console.WriteLine("Výsledek: " + vysledek);
                    break;
                case "-":
                    vysledek = c1 - c2;
                    Console.WriteLine("Výsledek: " + vysledek);
                    break;
                case "*":
                    vysledek = c1 * c2;
                    Console.WriteLine("Výsledek: " + vysledek);
                    break;
                case "/":
                    vysledek = c1 / c2;
                    Console.WriteLine("Výsledek: " + vysledek);
                    break;
            }
            Console.ReadLine();
        }
    }
}