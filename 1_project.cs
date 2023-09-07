internal class Program
{
    private static void Main(string[] args)
    {

         //This code is simple calculator of this you can buy with your budget


        Console.WriteLine("|----------------------------------------|");
        Console.WriteLine(" ");
        Console.WriteLine("   Ahoj, vítej ve kalkulačce rozpočtu");
        Console.WriteLine(" ");
        Console.WriteLine("|----------------------------------------|");
        Console.WriteLine(" ");
        Console.Write("   Zde na napiš kolik chceš utratit: ");
        int odpovedUtrata = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" ");
        Console.WriteLine("|----------------------------------------|");

        Console.WriteLine(" ");
        Console.Write("           Jaký je tvůj limit: ");
        int odpovedLimit = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" ");
        Console.WriteLine("|----------------------------------------|");



        int castkaPoOdecteni = odpovedLimit - odpovedUtrata;

        if (castkaPoOdecteni <=0)
        {
            Console.WriteLine(" ");
            Console.WriteLine("  Boužel tohle přesahuje tvůj limit:(");
            Console.WriteLine(" ");
        }
        else
        {
            Console.WriteLine(" ");
            Console.WriteLine("         Zbývá ti " + castkaPoOdecteni + " Kč");
            Console.WriteLine(" ");
        }


        Console.WriteLine("|----------------------------------------|");



        Console.ReadKey();


    }
}