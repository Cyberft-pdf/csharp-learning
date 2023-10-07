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
                Console.WriteLine("Welcome to the quadratic equation calculator");
                Console.WriteLine(" ");
                Console.WriteLine("------------------------------------------");


                Console.WriteLine(" ");
                Console.Write("Enter a:");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(" ");
                Console.Write("Enter b:");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(" ");
                Console.Write("Enter c:");
                double c = Convert.ToDouble(Console.ReadLine());


                double diskriminant = ((b * b) - 4 * a * c);


                if (diskriminant < 0)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("It is not possible to calculate");


                }
                else if (diskriminant > 0)
                {

                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine(" ");

                    Console.WriteLine("The discriminant is positive, I can count");
                    Console.WriteLine(" ");

                    double vypocet_X = ((-b - Math.Sqrt(diskriminant)) / 2*a);
                    double vypocet_X2 = ((-b + Math.Sqrt(diskriminant)) / 2 * a);
                    Console.WriteLine(" ");

                    Console.WriteLine("positive result is " + vypocet_X);
                    Console.WriteLine(" ");

                    Console.WriteLine("the negative result is " + vypocet_X2);

                }

                else
                {

                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine(" ");
                    Console.WriteLine("The discriminant is equal to zero");
                    double vypocet_X3 = (-b / 2 * a);
                    Console.WriteLine(" ");

                    Console.WriteLine("result equal " + vypocet_X3);
                    Console.WriteLine(" ");

                    Console.WriteLine("----------------------------------------------");

                }

             }

            Console.ReadKey();






        }
    }
}
