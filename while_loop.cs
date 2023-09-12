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

            //while loop je smyčka, která nikdy nekončí (běží když je true) 

            Console.WriteLine("Zadej jméno");
            String jmeno = Console.ReadLine();

            while (jmeno == "") 
            {
                Console.WriteLine("Zadej jméno");
                jmeno = Console.ReadLine();
            }


            Console.WriteLine(jmeno);

            Console.ReadKey();

        }
    }
}