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

            // method overloading = více metod může mít stejné jméno liší se v parametru(jejich počtu)


            double total; 

            total = Multiply(2, 7, 3);

            Console.WriteLine(total);

            Console.ReadKey();

        }

        static double Multiply(double x, double y)
        {
            return x * y;

        }


        static double Multiply(double x, double y, double z) 
        { 
        
            return (x * y * z);
        
        }
    }
}
