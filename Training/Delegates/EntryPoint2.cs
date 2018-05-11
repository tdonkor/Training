using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Delegates
{
    class EntryPoint2
    {
        public delegate void Printer(string message);


        public static void Main7()
        {
            Action<string> printer = Print;
            printer += PrintTwice;

            printer("Message");



            ////Delegate methods are publishers methods assigned to them are subscribers
            //Printer p = Print;
            //p += Print;
            //p += PrintTwice;
            //p += Print;
            //p += PrintTwice;
            //p += Print;

            //p -= PrintTwice;

            //p("message");

            //foreach (var del in p.GetInvocationList())  //list of all methods all assigned methods to the delegate chain
            //{
            //    Console.WriteLine(del.Method);
            //}

            //Delegate[] delegates = p.GetInvocationList();

            Console.ReadKey();
        }
        public static void Print(string message)
        {
           Console.WriteLine(message);
        }

        public static void PrintTwice(string message)
        {
            Console.WriteLine(message + " 1 ");
            Console.WriteLine(message + " 1 ");
        }
    }
}
