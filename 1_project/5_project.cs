using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DU1_2C_Steinerova
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string line = new string('=', Console.WindowWidth);
            Console.WriteLine(line);

            string text = "Hello! Welcom to time units converter \n\n\n\n";

            for (int i = 0; i <= text.Length; i++)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - i / 2, Console.WindowHeight / 5);
                Console.Write(text.Substring(0, i));
                Thread.Sleep(100);
            }

            Console.WriteLine(line);
            Console.WriteLine(" ");


            Console.SetCursorPosition(46, 13);
            Console.Write("What is your name?: ");

            string odpoved_jmeno = Console.ReadLine();

            Console.SetCursorPosition(51, 16);
            Console.WriteLine($"Hello {odpoved_jmeno}!");
            Thread.Sleep(1000);

            Console.WriteLine(" ");

            Console.SetCursorPosition(37, 18);
            Console.Write("Zadejte počet a časovou jenotku např. 48h\n");
            Console.SetCursorPosition(35, 20);
            Console.Write("(d = den, h = hodina ,m = minuta, s = sekunda): ");
            String odpoved_pocet = Convert.ToString(Console.ReadLine());


            switch (odpoved_pocet)
            {
                // ošetření mínusového čísla 
                case String zapor when zapor.Contains("-"):
                    Console.WriteLine("Neplatná volba, číslo nemůže být v mínusu");
                    break;

                case String sekunda when sekunda.Contains("s"):
                    String pocet_bez_jednotky_s = odpoved_pocet.Replace("s", "");
                    double odpoved_pocet_int_s = Convert.ToDouble(pocet_bez_jednotky_s);

                    double sekunky_vypocet_s = odpoved_pocet_int_s;
                    double minut_vypocet_s = odpoved_pocet_int_s / 60;
                    double minut_vypocet_zaok_s = Math.Round(minut_vypocet_s, 2);
                    double hodin_vypocet_s = minut_vypocet_s / 60;
                    double hodin_vypocet_zaok_s = Math.Round(hodin_vypocet_s, 2);

                    Console.SetCursorPosition(49, 27);
                    Console.WriteLine($"To je {sekunky_vypocet_s} (sekundy)");
                    Console.SetCursorPosition(49, 25);
                    Console.WriteLine($"To je {minut_vypocet_zaok_s} (minuty)");
                    Console.SetCursorPosition(49, 23);
                    Console.WriteLine($"To je {hodin_vypocet_zaok_s}  (hodiny)");
                    break;


                case String minuta when minuta.Contains("m"):
                    String pocet_bez_jednotky_m = odpoved_pocet.Replace("m", "");
                    double odpoved_pocet_int_m = Convert.ToDouble(pocet_bez_jednotky_m);

                    double sekunky_vypocet_m = odpoved_pocet_int_m * 60;
                    double minut_vypocet_m = odpoved_pocet_int_m;
                    double hodin_vypocet_m = minut_vypocet_m / 60;
                    double hodin_vypocet_zaok_m = Math.Round(hodin_vypocet_m, 2);

                    Console.SetCursorPosition(49, 27);
                    Console.WriteLine($"To je {sekunky_vypocet_m} (sekundy)");
                    Console.SetCursorPosition(49, 25);
                    Console.WriteLine($"To je {minut_vypocet_m} (minuty)");
                    Console.SetCursorPosition(49, 23);
                    Console.WriteLine($"To je {hodin_vypocet_zaok_m}  (hodiny)"); 
                    break;


                case String hodina when hodina.Contains("h"):
                    String pocet_bez_jednotky_h = odpoved_pocet.Replace("h", "");
                    double odpoved_pocet_int_h = Convert.ToDouble(pocet_bez_jednotky_h);

                    double sekunky_vypocet_h = (odpoved_pocet_int_h *60) * 60;
                    double minut_vypocet_h = odpoved_pocet_int_h * 60;
                    double hodin_vypocet_h = odpoved_pocet_int_h;
                    double den_vypocet_h = hodin_vypocet_h / 24;
                    double den_vypocet_zaok_h = Math.Round(den_vypocet_h, 0);
                    double den_vypocet_zbytek_h = odpoved_pocet_int_h - (den_vypocet_zaok_h * 24);

                    Console.SetCursorPosition(49, 27);
                    Console.WriteLine($"To je {sekunky_vypocet_h} (sekundy)");
                    Console.SetCursorPosition(49, 25);
                    Console.WriteLine($"To je {minut_vypocet_h} (minuty)");
                    Console.SetCursorPosition(49, 23);
                    Console.WriteLine($"To je {hodin_vypocet_h} (hodiny)");
                    Console.SetCursorPosition(49, 21);
                    Console.WriteLine($"To je {den_vypocet_zaok_h}(den) a {den_vypocet_zbytek_h}(hodiny)");

                    break;

                case String den when den.Contains("d"):
                    String pocet_bez_jednotky_d = odpoved_pocet.Replace("d", "");
                    double odpoved_pocet_int_d = Convert.ToDouble(pocet_bez_jednotky_d);

                    double sekunky_vypocet_d = (((odpoved_pocet_int_d * 24) * 60)* 60);
                    double minut_vypocet_d = (odpoved_pocet_int_d * 24) * 60;
                    double hodin_vypocet_d = odpoved_pocet_int_d * 24;
                    double den_vypocet_d = odpoved_pocet_int_d;

                    Console.SetCursorPosition(49, 27);
                    Console.WriteLine($"To je {sekunky_vypocet_d} (sekundy)");
                    Console.SetCursorPosition(49, 25);
                    Console.WriteLine($"To je {minut_vypocet_d} (minuty)");
                    Console.SetCursorPosition(49, 23);
                    Console.WriteLine($"To je {hodin_vypocet_d} (hodiny)");
                    Console.SetCursorPosition(49, 21);
                    Console.WriteLine($"To je {den_vypocet_d} (den)");
                    break;

            }

            Console.ReadKey();

        }
    }
}
