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

            // method = spusní část kódu když je zavolán tzv. "invoked"
            //          benefit můžeme několikrát použít stejný kód bez opakováného přepisování

            //argumenty = co je postané metodám

            String name = "adel";
            int age = 10;


            /*
            když chci aby se i do jiné metody dostala proměnná z jiné metody tak musím napsat 
                      její název + závorky do, kterých napíšu jejich název př. name, age(oděluji je čárkou) 
                      dále je s datovým typem zapsat do začátky té jiné metody do která tu proměnou chci "poslat"
            */

            singHappyBirthday(name, age);


            Console.ReadKey();
        }

        static void singHappyBirthday(String name, int age)
        {
            Console.WriteLine("Vše nej k narozeninám");
            Console.WriteLine("Vše nej k narozeninám " + name);
            Console.WriteLine("Už ti je " + age);
            Console.WriteLine("Vše nej k narozeninám");


        }
    }
}
