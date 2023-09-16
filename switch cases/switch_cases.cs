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

            // tzv. switch cases je efektivnější alternativa k if podmínkám

            Console.WriteLine("Jaký je dneska den?:");
            String den = Console.ReadLine();


                  //sem vložím to s čím chci pracovat
            switch (den)
            {

                case "Pondělý":
                    Console.WriteLine("Je to pondělý");
                    break;

                case "uterý":
                    Console.WriteLine("Je to uterý");
                    break;

                case "středa":
                    Console.WriteLine("Je to středa");
                    break;

                case "čtvrtek":
                    Console.WriteLine("Je to čtvrtek");
                    break;

                case "Pátek":
                    Console.WriteLine("Je to Pátek");
                    break;

                case "sobota":
                    Console.WriteLine("Je to sobota");
                    break;

                case "Neděle":
                    Console.WriteLine("Je to Neděle");
                    break;
                default:
                    Console.WriteLine("Musíš napsat den v týdnu");
                    break;

            }



            Console.ReadKey();

        }
    }
}
