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
            // string interpolation = vypisování pomocí {} do string literal

            String jmeno = "Cyber";
            String prijmeni = "Ft";

            Console.WriteLine($"Tvoje jmeno je: {jmeno,-5}, {prijmeni}");

            Console.ReadKey();

        }

    }
}