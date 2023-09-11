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

            Random random = new Random();

            int num = random.Next(1, 7);
            double num2 = random.NextDouble();

            Console.WriteLine(num + num2);


            Console.ReadKey();



        }
    }
}