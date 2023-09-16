internal class Program
{
    private static void Main(string[] args)
    {



        String fullName = "Adel";
        String phoneNumber = "123-456-7890";

        fullName = fullName.ToUpper();
        fullName = fullName.ToLower();
        Console.WriteLine(fullName);

        phoneNumber = phoneNumber.Replace("-", "");
        Console.WriteLine(phoneNumber);

        String userName = fullName.Insert(0,"Mr. ");
        Console.WriteLine(userName);

        Console.WriteLine(fullName.Length);

        String fistName = fullName.Substring(0,2);
        Console.WriteLine(fistName);

        Console.ReadKey();


    }
}