using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte první komplexní číslo:");
            Console.Write("Realná část prvního čísla: ");
            double real1 = double.Parse(Console.ReadLine());
            Console.Write("Imaginární část prvního čísla: ");
            double imaginary1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nZadejte druhe komplexní číslo:");
            Console.Write("Reálná část druhého čísla: ");
            double real2 = double.Parse(Console.ReadLine());
            Console.Write("Imaginarni část druheho čísla: ");
            double imaginary2 = double.Parse(Console.ReadLine());

            //vytvoreni novych instanci tridy "ComplexNumber"
            ComplexNumber complex1 = new ComplexNumber(real1, imaginary1);
            ComplexNumber complex2 = new ComplexNumber(real2, imaginary2);

            //zavolani metod pro soucet a rozdil
            ComplexNumber soucet = complex1.Add(complex2); 
            ComplexNumber rozdil = complex1.Subtract(complex2);

            //zapis do konzole pro soucet a rozdil
            Console.WriteLine($"\nSoučet: {soucet.Real} + {soucet.Imaginary}i");
            Console.WriteLine($"Rozdíl: {rozdil.Real} + {rozdil.Imaginary}i");

            Console.ReadLine();
        }
    }
    //vytvoreni tridy "ComplexNumber"
    public class ComplexNumber
    {
        //verejne atributy Real a Imgainary
        public double Real;
        public double Imaginary;

        //kontruktor tridy ComplexNumber
        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        //metoda pro soucet komplexnich cisel
        public ComplexNumber Add(ComplexNumber other)
        {
            if (other != null)
            {
                return new ComplexNumber(this.Real + other.Real, this.Imaginary + other.Imaginary);
            }
            else
            {
                Console.WriteLine("Nesmí být prázdný.");
                return null;
            }
        }

        //metoda pro odecteni komplexnich cisel
        public ComplexNumber Subtract(ComplexNumber other)
        {
            if (other != null)
            {
                return new ComplexNumber(this.Real - other.Real, this.Imaginary - other.Imaginary);
            }
            else
            {
                Console.WriteLine("Nesmí být prázdný.");
                return null;
            }
        }
    }
}