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

            Console.WriteLine(num);


            Console.ReadKey();





        }
    }
}
