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
            //params keyword = může vzít větší škálu argumentů

            double total = CheckOut(3.99, 5.88, 15, 16);

            Console.WriteLine(total);
            Console.ReadKey();


        }

        static double CheckOut(params double[] prices) 
        {


            double total = 0;

            foreach (double price in prices)
            {

                total += price;
            }
        
            return total;
        
        }


    }
}