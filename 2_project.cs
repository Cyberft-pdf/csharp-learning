using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // This program counts the hypotenuse in triangle

            Console.WriteLine("Napište stranu A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Napište stranu b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt((a * a) + (b * b));

            Console.WriteLine("Přepona v zadaném trojúhelníku je: " + c);

            Console.ReadKey();

        }
    }
}