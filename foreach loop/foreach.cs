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
            //foreach loop = a simpler way to interate over an array, but its less flexible 

            String[] cars = { "BMW", "Mustang" };



            foreach (String car in cars)
            { 
                Console.WriteLine(car);
            }

            Console.ReadKey();

        }
    }
}
