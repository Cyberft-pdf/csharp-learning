using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace trenink_pole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program that stores elements in an array and prints them.
            /*
            int[] cisla = { 1, 2, 3, 4, 5, 6, };

            foreach (int i in cisla)
            {
                Console.WriteLine(i);
            }
            */






            //Write a C# Sharp program to read n values in an array and display them in reverse order.
            /*
            int[] cisla = { 1, 2, 3, 4, 5, 6 };

            Array.Reverse(cisla);

            foreach (int i in cisla) 
            {
                Console.WriteLine(i);

            }
            */





            //Write a program in C# Sharp to find the sum of all array elements.
            /*
                    int[] cisla = { 1, 2, 3, 4, 5, 6 };
               int sum = 0;

            for (int i = 0; i < cisla.Length; i++)
            {
                sum += cisla[i];
            }

            Console.WriteLine("Sum of array elements: " + sum);
            }
            */





            /*
             * 
             * 
            //Write a C# Sharp program to copy the elements of one array into another array.
            int[] cisla = { 1, 2, 3, 4, 5, 6 };

            int[] disla = cisla;

            foreach (int i in disla)
            {
                Console.WriteLine(i);
            }
            */




            //Write a C# Sharp program in to count duplicate elements in an array
            /*
            int[] cisla = { 1, 2, 3, 4,4, 5, 6, 5 };
            int pocitadlo = 0;

             Array.Sort(cisla);

            for (int i = 0; i < cisla.Length -1; i++)
            {
                if(cisla[i] == cisla[i + 1])
                {
                    pocitadlo++;

                };
            }
            Console.WriteLine(pocitadlo);

            */







            /*
            //Write a program in C# Sharp to print all unique elements in an array
            int[] cisla = { 1, 2, 3, 4, 4, 5, 6, 5 };
            int pocitadlo = 0;

            Array.Sort(cisla);

            for (int i = 1; i < cisla.Length - 1; i++)
            {
                if (cisla[i] != cisla[i + 1] && cisla[i] != cisla[i - 1])

                {
                    Console.WriteLine($"jedinečné: {cisla[i]}");
                    pocitadlo++;

                }
                else { 
                    Console.WriteLine($"duplicity: {cisla[i]}");
                }
            }
            Console.WriteLine(pocitadlo);
            */





            //Write a C# Sharp program to merge two arrays of the same size sorted in ascending order.
            /*

                 int[] cisla = { 1, 2, 3, 4, 4, 5, 6, 5 };
                 int[] cisla2 = { 1, 2, 3, 4, 4, 5, 6, 5 };

                 int[] spojeni = new int[cisla.Length + cisla2.Length];

                 int index = 0;


                 for (int i = 0; i < cisla.Length ; i++)
                 {
                     spojeni[index++] = cisla[i];
                     spojeni[index++] = cisla2[i];

                 }

                 foreach (int i in spojeni)
                 {
                     Console.WriteLine(i);
                 }

                 */

            //Write a C# Sharp program to find the maximum and minimum elements in an array.

            /*
            int[] cisla = { 1, 2, 3, 4, 4, 5, 6, 5 };

            Array.Sort(cisla);

            Console.WriteLine(cisla[0]);

            Console.WriteLine(cisla[cisla.Length -1]);
            */




            //Write a program in C# Sharp to separate odd and even integers into separate arrays.
            /*
            int[] cisla = { 1, 2, 3, 4, 4, 5, 6, 5 };

            int[] suda = new int[cisla.Length];
            int[] licha = new int[cisla.Length];

            for (int i = 0; i < cisla.Length; i++)
            {
                if (cisla[i] % 2 == 0)
                {
                    suda[i] = cisla[i];

                }
                else
                {
                    licha[i] = cisla[i];
                }
            }
            foreach (int i in suda)
            {
                Console.WriteLine(i);
            }
            foreach (int i in licha)
            {
                Console.WriteLine(i);
            }
            */



            /*
             * 
             * 
            //PYRAMID FINILY AM SMART YES 

            int user_input = Convert.ToInt32(Console.ReadLine());



            for (int i = 0; i < user_input; i++) 

            {      
                for (int k = user_input; k > i ; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {


                    Console.Write(" " + i);

                }
                Console.WriteLine();
            }
            */





            /*
            //Write a program in C# Sharp for a 2D array of size 3x3 and print the matrix.


            int[,] matrix = {
                { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } , { 7, 8, 9 }
            };




            for (int i = 0; i <  4; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    Console.Write(matrix[i, j] + " ");

                }
                Console.WriteLine();
            }

            */


            //Write a C# Sharp program for adding two matrices of the same size















            Console.ReadKey();

        }
    }
}