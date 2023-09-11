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

            // tzv. logické operátory používají na zkountrolování jestli více než 1 podmínka je pravda nebo ne
            //&& (a)
            //|| (nebo)

            Console.WriteLine("Jaká je teplova venku?: ");
            double teplota = Convert.ToDouble(Console.ReadLine());

            if (teplota >= 10 && teplota <= 25)
            {
                Console.WriteLine("Venku je teplo");

            }
            else if (teplota <= -50 || teplota >= 50)
            {
                Console.WriteLine("Venku je hrozné horko nechoť tam");
            }



            Console.ReadKey();

        }
    }
}