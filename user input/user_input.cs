internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Jaké je tvoje jméno");
        String name = Console.ReadLine();
        Console.WriteLine("Hello " + name );

        Console.WriteLine("Jaký je tvůj věk");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Hello " + name + " a je ti " + age);


        Console.ReadKey();

    }
}