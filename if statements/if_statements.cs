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

            Console.Write("Jaký je tvůj věk? : ");
            int vek = Convert.ToInt32(Console.ReadLine());

            if (vek >= 18)
            {
                Console.WriteLine("Můžete vstoupit");
            }
            else if (vek < 0)
            {

                Console.WriteLine("Nemůže ti být méně tež 1");

            }
            else
            {
                Console.WriteLine("Buď ti není 18 let nebo si zadal špatný formát čísla");
            }


            Console.ReadKey();

        }
    }
}