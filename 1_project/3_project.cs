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

           do
            {

            

            double num1 = 0;
            double num2 = 0;
            double result = 0;


            Console.WriteLine("--------------------------");
            Console.WriteLine("Kalkulačka");
            Console.WriteLine("--------------------------");

            Console.WriteLine("Zadej číslo 1: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Zadej číslo 2: ");
            num2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Co chcete dělat?: ");
            Console.WriteLine("\t+: přidat");
            Console.WriteLine("\t-: odebrat");
            Console.WriteLine("\t*: násobit");
            Console.WriteLine("\t/: dělit");

            switch(Console.ReadLine())
            {
                case "+":
                    result= num1 + num2;
                    Console.WriteLine($"Tvé číslo vyšlo: {num1} + {num2} = " + result);
                    break;

                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"Tvé číslo vyšlo: {num1} - {num2} = " + result);
                    break;

                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"Tvé číslo vyšlo: {num1} * {num2} =" + result);
                    break;

                case "/":
                    result = num1 / num2;
                    Console.WriteLine($"Tvé číslo vyšlo: {num1} / {num2} = " + result);
                    break;

                default:
                    Console.WriteLine("Nic si si nevybral:(");
                    break;
            }

                Console.WriteLine("Chtěl by jsi pokračovat Y/N");
            } while (Console.ReadLine().ToUpper() == "Y");


            Console.WriteLine("Tak ahoj");
            Console.ReadKey();

        }
    }
}
