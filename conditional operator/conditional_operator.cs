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

            // conditional operator = používá se při podmínkách které jsou true nebo false

            double temperature = 20;
            String message;


            /*
            if (temperature >= 15)
            {
                message = "Je venku teplo obleč si";


            }
            else
            {
                message = "veku je zima vem si kabát";
            }
            */

            //tohle je zkrácený zápis if podmínek
            message = (temperature >= 15) ? "Je venku teplo" : "Je venku zima";

            Console.WriteLine(message);

            Console.ReadKey();

        }

    }
}