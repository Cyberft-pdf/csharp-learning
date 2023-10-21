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
            //exception = errori, které se objeví během spuštění

            /*
              try = zkusí code, který je považán za nebezpečný
              catch = chytí a vyřeší výjimku 
              finally = vždy se spustí
            */

            try 
            { 

                Console.WriteLine("Zadej číslo 1: ");
                double x = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Zadej číslo 2: ");
                double y = Convert.ToDouble(Console.ReadLine());

                double result = x * y;

                Console.WriteLine("Výsledek" + result);

            }
            catch (FormatException e)
            {
                Console.WriteLine("Zadej jenom číslo prosím: ");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Zadej číslo ne nulové: ");
            }
            finally 
            {
                Console.WriteLine("Díky za využití");
                    
            }

        }

    }
}
