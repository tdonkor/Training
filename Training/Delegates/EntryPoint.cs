using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Delegates
{
    class EntryPoint
    {

       // public delegate bool Filters(string item);

        static void Main6()
        {
            string[] names = { "Alice", "John", "Bobby", "Kyle", "Scott", "Tod", "Sharon", "Armin", "George" };

            ////string for input bool for output Func delegate
            //Func<string, bool> lessThanFiveChars = LessThanFive;
            //Func<string, bool> MoreThanFiveChars = MoreThanFive;
            //Func<string, bool> ExactlyFiveChars = ExactlyFive;


            // using lambda
            Func<string, bool> lessThanFive = x => x.Length < 5;
            Func<string, bool> MoreThanFive = x  => x.Length > 5;
            Func<string, bool> ExactlyFive = x => x.Length == 5;

            // List<string> lessThanFiveChars = NamesFilter(names, ExactlyFive);

            //using Lambda
            //List<string> lessThanFiveChars = NamesFilter(names, item =>item.Length < 5);
            //List<string> moreThanFiveChars = NamesFilter(names, item => item.Length > 5);
            //List<string> exactlyFiveChars = NamesFilter(names, item => item.Length == 5);

            //using Func test
            List<string> namesLessThanFiveChars = ExtractStrings(names, LessThanFive);
            List<string> namesMoreThanFiveChars = ExtractStrings(names, MoreThanFive);
            List<string> namesExactlyFiveChars = ExtractStrings(names, ExactlyFive);

            //Action only takes inputs and returns voids Fuc returns something


             Console.WriteLine("Names less than five chars: " + string.Join(", ", namesLessThanFiveChars));
             Console.WriteLine("Names more than five chars: " + string.Join(", ", namesMoreThanFiveChars));
             Console.WriteLine("Names exactly five chars: " + string.Join(", ",  namesExactlyFiveChars));

            // Console.WriteLine("Names less than five chars: " + string.Join(", ", lessThanFiveChars));
            //Console.WriteLine("Names more than five chars: " + string.Join(", ", moreThanFiveChars));
            //Console.WriteLine("Names exactly five chars: " + string.Join(", ", exactlyFiveChars));

            Console.ReadKey();

        }


        //can use lambda
        //public static bool LessThanFive(string item)
        //{
        //    return item.Length < 5;
        //}

        //public static bool MoreThanFive(string item)
        //{
        //    return item.Length > 5;
        //}

        //public static bool ExactlyFive(string item)
        //{
        //    return item.Length == 5;
        //}


        //using Func
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

        //public static List<string> NamesFilter(string[] items, Filters filter) // filter is creating a new type
        //{
        //    List<string> result = new List<string>();

        //    foreach (var item in items)
        //    {
        //        if(filter(item))
        //        {
        //            result.Add(item);
        //        }
        //    }

        //    return result;
        //}



        //using Func
        public static List<string> ExtractStrings(string[] items, Func<string,bool> filter) // filter is creating a new type
        {
            List<string> result = new List<string>();

            foreach (var item in items)
            {
                if (filter(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }

    }
}
