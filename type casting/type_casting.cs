internal class Program
{
    private static void Main(string[] args)
    {

        /*

        type casting = umět převést proměnnou z jiného datového typu do druhého

        */


        double a = 3.14;

        int b = Convert.ToInt32(a);

        int c =123;
        double d = Convert.ToDouble(c) + 0.1;

        int e = 321;
        String f = Convert.ToString(e);

        String g = "@";
        char h = Convert.ToChar(g);

        String i = "true";
        bool j = Convert.ToBoolean(i);



        Console.WriteLine(i);
        Console.WriteLine(j.GetType()); //Tímhle zjistím datový typ dané proměnné



        Console.ReadKey();

    }
}