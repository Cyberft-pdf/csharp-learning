using System;
using System.IO;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DU3_2C_Steinerova
{
    internal class Program
    {
        class Polozka
        {
            public String Jmeno { get; set; }
            public bool Alkohol { get; set; }
            public String Popis { get; set; }


            //konstruktor
            public Polozka(String jmeno, bool alkohol, string popis)
            {
                Jmeno = jmeno;
                Alkohol = alkohol;
                Popis = popis;
            }

        }
        static void Main(string[] args)
        {       
            //!Pozor tento program vytváří soubor uctenka.txt a otevírá ho!(179-189 line)
                    
            Console.Clear();
            string line = new string('=', Console.WindowWidth);
              
                                                                                                                                      //(to má být planeta)
              string text = "         *                *                                     *                                   *    __|=|__       " +
                            "                 *                                                                                      (  _  _  _ )    " +
                            "                         Welcome to the Inn of the Celestial Café. What would you like to order?         `/  ||  \\` " +
                            "        *                             *                                                            *           -|=|-         " +
                            "              *                                                      *                                          *       ";
              Console.WriteLine(line);
              for (int i = 0; i <= text.Length; i++)
              {
                  Console.Clear();
                  Console.WriteLine(" ");
                  Console.SetCursorPosition(0, 9);
                  Console.WriteLine(line);
                  Console.SetCursorPosition(0, 10);
                  Console.Write(text.Substring(0, i));
                  Thread.Sleep(10);
              }

              Console.WriteLine(line);

              Polozka[,,] menu = {
                              {
                                  {new Polozka("Galactic Water", false, "pure hydration from distant stars"), new Polozka( "Neutron Nectar", false, "captivating, mysterious stellar concoction"), new Polozka("Radiant Green Tea", false, "cosmic calmness in every sip") },
                                  {new Polozka("Supernova Smoothie", false, "fruity explosion, thrilling taste ride"), new Polozka("Luna Latte", false, "velvety comfort, lunar tranquility captured"), new Polozka("Interplanetary Iced Chai", false, "earthy warmth meets interstellar chill")}
                              },
                              {
                                 { new Polozka("Exoplanet Beer", true, "bold brew for cosmic exploration"), new Polozka("Cosmic Cocktail", true, "layers of interstellar flavor adventure"), new Polozka( "Astro Citrus Splash", true, "celestial burst on your palate")},
                                 { new Polozka("Galactic Gin Fusion", true, "botanical blend from distant galaxies"), new Polozka("Meteorite Wine", true, "celestial vintage, taste the stars"), new Polozka( "Stellar Spice Rum Punch", true, "warmth of stars in punch")}
                              }
                            };
              string odpoved = "";
              do 
              {                                   //O - kategorie nealkoholické
                  VypisMenu("\nnon-alcoholic beverages: ", menu, 0);
                  VypisMenu("\nalcoholic beverages: ", menu, 1);
                  Console.WriteLine("\n"+line);
                                          
                  String napoj_uzivatel = Console.ReadLine().ToLower();

                  Polozka napoj_uzivatel_hledani = Najit(menu, napoj_uzivatel);
                  //když nápoj nenajde
                  if (napoj_uzivatel_hledani == null)
                  {
                      Console.WriteLine($"We do not serve {napoj_uzivatel}");
                  }
                  //když najde nápoj / kontroluje jestli je alko.
                  else if (napoj_uzivatel_hledani.Alkohol == true)
                  { 
                      //řešení zadání špatného formátu 
                      try { 
                          Console.WriteLine($"\nAhh very good choice. I describe it as ´{napoj_uzivatel_hledani.Popis}´ \nAnd how old are you, young gun?");
                      
                          int vek_uzivatel = Convert.ToInt32(Console.ReadLine());
                          int vek_uzivatel_bool = vek_uzivatel;
                          //kontrola věku 
                          if (Vek(vek_uzivatel_bool) == true)
                          {
                              Console.WriteLine($"\n{napoj_uzivatel} was served, enjoy");
                              ObjednavkaZapis($"Order: {napoj_uzivatel} -  {DateTime.Now}");
                          }
                          else
                          {   // >18
                              Console.ForegroundColor = ConsoleColor.Red;
                              Console.WriteLine($"\nWe cannot provide {napoj_uzivatel} to individuals under the age of 18 and your age is {vek_uzivatel}");
                              Thread.Sleep(1000);
                              Console.WriteLine("I will begin counting to five. Please leave!");
                              for (int i = 1; i <= 5; i++ )
                              {   
                                  Thread.Sleep(1000);
                                  Console.WriteLine(i);
                              }
                              Console.WriteLine("BANG!");
                              Thread.Sleep(1000);
                          
                              Environment.Exit(0);
                          }
                      }
                      catch (FormatException ex )
                      { 
                          Console.WriteLine ($"Bad format!!({ex.Message})");
                      }
                  }
                  //není alko.
                  else
                  {
                      ObjednavkaZapis($"Order: {napoj_uzivatel} -  {DateTime.Now}");
                      Console.WriteLine($"\nAhh very good choice. I describe it as ´{napoj_uzivatel_hledani.Popis}´. \nThank you, for ordering {napoj_uzivatel}");
                  }
                  Console.ForegroundColor= ConsoleColor.White;
                  Console.WriteLine(line);

                  Console.WriteLine("\nWould you like to order something else? y/n");
                  
                  odpoved = Console.ReadLine();
                  Console.Clear();   
              }while (odpoved.ToLower() == "y");
            
            Console.WriteLine(line);
            Console.SetCursorPosition(34,10);
            Console.WriteLine("Thank you for visiting my Inn of the Celestial Café\n\n\n\n\n\n\n\n");
            Console.WriteLine(line);
            Console.ReadKey();
        }
        //používám static void = nevrací žádnou realnou hodnotu jenom vypisuje 
        static void VypisMenu(String kategorie, Polozka[,,] menu, int index)
        {
            Console.WriteLine(kategorie);
            //
            for (int i = 0; i < menu.GetLength(1); i++)
            {
                //
                for (int j = 0; j < menu.GetLength(2); j++)
                {   
                     
                     Console.WriteLine($"- {menu[index,i, j].Jmeno}");
                    
                }
            }
        }
        static bool Vek(int age)
        {
            //vráti true pokud je věk 18 nebo více jinak false
            return age >= 18;
        }

        static Polozka Najit(Polozka[,,] menu, String Jmeno)
        { 
            // O = kategorie
            for(int i = 0; i < menu.GetLength(0); i++)
            {
                // 1 = typ nápojů
                for(int j = 0;j < menu.GetLength(1); j++) 
                {   // 2 = konkrétní nápoj
                    for(int k = 0;  k < menu.GetLength(2); k++) 
                    {   
                        //kontrolování spravného 
                        if (menu[i, j, k].Jmeno.ToLower() == Jmeno.ToLower())
                        {
                            return menu[i, j, k];
                        }

                    }
                }
            }
            //když nenajde žádný nápoj => jinak error
            return null;
        }
        //ukládání objednávek
        static void ObjednavkaZapis(string objednavka)
        {
            string soubor = "uctenka.txt";

            using (StreamWriter writer = new StreamWriter(soubor, true)) 
            {
                writer.WriteLine(objednavka);
            }

            Process.Start("notepad.exe", soubor);
        }
    }   
}