using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // objext = je to instance tříd

            Human human1 = new Human();
            Human human2 = new Human();


            human1.name = "Cyber";
            human1.age = 20;

            human2.name = "kiki";
            human2.age = 22;

            human1.Eat();
            human1.Sleep();

            human2.Eat();
            human2.Sleep();

            Console.ReadKey();

        }

    }

    class Human
    {

        public String name;
        public int age;

        public void Eat () 
        {
            Console.WriteLine(name + " is eating");
        }
        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping");
        }
    }

}