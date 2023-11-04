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

            //class = svazek z podobných kódu, používá se jako blueprint pro vytváření objektů(OOP)

            Messages.Hello();

            Messages.Waiting();

            Messages.Bye();

            Console.ReadKey();

        }

    }

}
