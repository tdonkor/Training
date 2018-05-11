using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Generics
{
    class EntryPointcs
    {
        static void Main4()
        {
            //Console.WriteLine(AreEqual("string", "string")); // must be the same types to compare
            int[] array = { 3, 4, 2, 1, 5, 6, 7, 8, 9, 2, 2, 2, 1, 23, 3 };
            string[] strArray = { "wFWfw", "defwefwe", "fefef" };

          
            int[] sortedArray = Sort(array);
            string[] stringSortedArray = Sort(strArray);

            //Console.WriteLine(string.Join(", ", sortedArray));
            //Console.WriteLine(string.Join(", ", stringSortedArray));

            Person p1 = new Person() { Age = 10 };
            Person p2 = new Person() { Age = 10 }; ;

            Console.WriteLine("p1 equal to p2: " + AreEqual(p1,p2));

            Console.ReadKey();
        }

        // with int
        //public static int[] Sort(int[] array)
        //{
        //    int temp = 0;

        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        for (int j = 0; j < array.Length - 1; j++)
        //        {
        //            if (array[j] > array[j + 1])
        //            {
        //                temp = array[j + 1];
        //                array[j + 1] = array[j];
        //                array[j] = temp;
        //            }
        //        }
        //    }
        //    return array;
        //}

        //string
        //public static string[] Sort(string[] array)
        //{

        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        for (int j = i + 1; j < array.Length; j++)
        //        {
        //            if (array[i].CompareTo(array[j]) > 0)
        //            {
        //                string temp = array[i];
        //                array[i] = array[j];
        //                array[j] = temp;
        //            }
        //        }
        //    }
        //    return array;
        //}

        //Generic
        public static T[] Sort<T>(T[] array) where T : IComparable<T>
        {

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i].CompareTo(array[j]) > 0)
                    {
                        T temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }

        // T can be anything T - type
        public static bool AreEqual<T>(T num1, T num2 ) where T:IComparable<T>
        {
            return (num1.CompareTo(num2) == 0);
        }
    }
}
