using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Generics
{
    class EntryPoint2
    {
        public static void Main4(string[] args)
        {
            MyList<int> myIntList = new MyList<int>();
            MyList<int> firstIntList = new MyList<int>();
            MyList<int> secondIntList = new MyList<int>();



            //Console.WriteLine("Starting Capacity & Count: ");
            //Console.WriteLine(myIntList.Capacity);
            //Console.WriteLine(myIntList.Count);

            //myIntList.Add(5);
            //myIntList.Add(1);
            //myIntList.Add(1);

            //Console.WriteLine("\nEnding Capacity & Count: ");
            //Console.WriteLine(myIntList.Capacity);
            //Console.WriteLine(myIntList.Count);

            //Console.WriteLine($"\nNumber 1: {myIntList[0]}");

            firstIntList.Add(5);
            firstIntList.Add(1);
            firstIntList.Add(1);
            secondIntList.Add(1);
            secondIntList.Add(1);
            secondIntList.Add(1);

           
            MyList<int> result = firstIntList + secondIntList;
            Console.WriteLine($"Result: {result[1]}\n");
            Console.WriteLine(result.ToString());

            Console.ReadKey();
        }
    }
}
