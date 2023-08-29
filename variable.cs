internal class Program
{
    private static void Main(string[] args)
    {
        //Console.Write("I like pizza");
        //Console.WriteLine("Its really good");

        //Tohle je komentář hahahah

        /*tohle
         * je 
         * taky 
         * komentář
         */

        
        int age = 12;

        double heght = 300.5;

        bool alive = true;

        char symbol = '@';

        String name = "Adelka";

        Console.WriteLine("Tvoje jméno je " + name);
        Console.WriteLine("Tvůj věk je " + age);
        Console.WriteLine("Tvoje výška je " + heght);
        Console.WriteLine("Jsi naživu " + alive);
        Console.WriteLine("Tvůj symbol je " + symbol);

        String userName = symbol + name;

        Console.WriteLine("Tvoje username je: " + userName);


        Console.ReadKey();

    }
}