using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Delegates
{
    class EntryPoint3
    {
        public delegate bool CheckLengthOfString(string message);
        public delegate int GetLengths(string message);


        public static void Main7()
        {
            CheckLengthOfString d = LessThanFive;
            d += MoreThanFive;
            d += ExactlyFive;

            //List<bool> results = new List<bool>();

            //foreach (var del in d.GetInvocationList())
            //{
            //    results.Add((bool)del.DynamicInvoke("Message"));
            //    Console.WriteLine(string.Join(", ", results));

            //}

            //  List<bool> results = d.GetInvocationList().Select(del => (bool)del.DynamicInvoke("Message")).ToList();

            GetLengths g = x => x.Length;
                       g += x => x.Length + 2;
                       g += x => x.Length + 1;

            List<bool> results = GottaCatchEmAll<bool>(d, "Message");
            List<int> lengths = GottaCatchEmAll<int>(g, "Message");

            Console.WriteLine(string.Join(", ", results));
            Console.WriteLine(string.Join(", ", lengths));

            Console.ReadKey();
        }

        //using a generic method to catch all delegate returned values
        public static List<T> GottaCatchEmAll <T>(Delegate del, object parameter = null)
        {
            List<T> result = del.GetInvocationList()
                            .Select(d => (T)d.DynamicInvoke(parameter)).ToList();
            return result;
        }

        public static bool LessThanFive(string item)
        {
            return item.Length < 5;
        }

        public static bool MoreThanFive(string item)
        {
            return item.Length > 5;
        }

        public static bool ExactlyFive(string item)
        {
            return item.Length == 5;
        }
    }
}
