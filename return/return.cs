using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // return = vrací data zpátky kde ta metoda byla vyvolána


            double x;
            double y;
            double result;

            Console.WriteLine("Napiš číslo 1: ");
            x = double.Parse(Console.ReadLine());


            Console.WriteLine("Napiš číslo 2: ");
            y = double.Parse(Console.ReadLine());

            result = Multiply(x, y);

            Console.WriteLine(result);

            Console.ReadKey();

        }

        static double Multiply(double x, double y)
        {
            return x * y;

        }
    }
}