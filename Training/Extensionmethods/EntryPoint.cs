using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Training.Extensionmethods
{
    public static class EntryPoint
    {
        static void Main3()
        {
            Point pointOne = new Point(20, 30);
            Point pointTwo = new Point(10, 15);


            // int[] array = { 5, 3, 1, 2, 3, 9, 100, 1 };
            // Sort(array);
            // array.Sort(true); // using sort extention method
            // array.Reverse();

            //  Console.WriteLine(string.Join(", ", array));


            pointOne.DistanceTo(pointTwo);

            Console.ReadKey();
        }

       
    }
}
