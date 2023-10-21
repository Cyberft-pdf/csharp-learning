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

            //multidimensional arrays = umí uskladnit více řádků dat 


            String[,] parkingLot = { { "Mustang", "F-150", "Explorer" }, 
                                    { "Corvette", "Camaro", "Silverado" }, 
                                    { "Corolla", "Camry", "Rav4" } 
                                    };

            parkingLot[0, 2] = "fusion";

            /*
              
            Vice dimenzionální array se dá vypsat i foreach 
            
            foreach (String car in parkingLot) 
            { 
                
                Console.WriteLine(car);
            
            }
            */

            for (int i = 0; i < parkingLot.GetLength(0); i++) 
            {
            
                for (int j = 0; j  < parkingLot.GetLength(1); j++)
                {
                    Console.Write(parkingLot[i, j] + " ");

                }
                Console.WriteLine();
            
            }

            Console.ReadKey();

        }

    }
}