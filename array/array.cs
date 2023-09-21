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

            //array = je proměnná která dokáže uložit více hodnoty najednou

            //takto můžu deklarovat array bez toho abych věděla co v ní bude ale má fixní velikost(tady 4)
            String[] cars = new String[4]; 


            //String[] cars = { "BNW", "mustang" , "Cover" };


            //a takto přiřadím hodnotu
            cars[0] = "tesla";
            cars[1] = "mustank";
            cars[2] = "sdf";
            cars[3] = "tdfs";

            for (int i = 0; i < cars.Length; i++) 
            {

                Console.WriteLine(cars[i]);
            
            }

            /*
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars[2]);
            */

            Console.ReadKey();

        }
    }
}