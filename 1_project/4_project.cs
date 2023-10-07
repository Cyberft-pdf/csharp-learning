using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool run = true;

            while(run)

            {

                Console.WriteLine("------------------------------------------");
                Console.WriteLine(" ");
                Console.WriteLine("Vítej v kalkulačce kvadratické rovnice");
                Console.WriteLine(" ");
                Console.WriteLine("------------------------------------------");


                Console.WriteLine(" ");
                Console.Write("Zadej a:");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(" ");
                Console.Write("Zadej b:");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(" ");
                Console.Write("Zadej c:");
                double c = Convert.ToDouble(Console.ReadLine());


                double diskriminant = ((b * b) - 4 * a * c);


                if (diskriminant < 0)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Není možné vypočítat");


                }
                else if (diskriminant > 0)
                {

                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine(" ");

                    Console.WriteLine("Diskriminant je kladný můžu počítat");
                    Console.WriteLine(" ");

                    double vypocet_X = ((-b - Math.Sqrt(diskriminant)) / 2*a);
                    double vypocet_X2 = ((-b + Math.Sqrt(diskriminant)) / 2 * a);
                    Console.WriteLine(" ");

                    Console.WriteLine("kladný vysledek je " + vypocet_X);
                    Console.WriteLine(" ");

                    Console.WriteLine("záporný vysledek je " + vypocet_X2);

                }

                else
                {

                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine(" ");
                    Console.WriteLine("Dikrimant je roven nule");
                    double vypocet_X3 = (-b / 2 * a);
                    Console.WriteLine(" ");

                    Console.WriteLine("výsledek roven " + vypocet_X3);
                    Console.WriteLine(" ");

                    Console.WriteLine("----------------------------------------------");

                }

             }

            Console.ReadKey();






        }
    }
}
