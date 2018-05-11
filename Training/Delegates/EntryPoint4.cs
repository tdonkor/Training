using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Delegates
{
    class EntryPoint4
    {
        public static void Main6()
        {



            //Func<int, bool> checkIntergers = i => i < 8;
            //Console.WriteLine(checkIntergers(5));

            //Func<int, int, bool> checkIntergers = (i, j) => i < 8 + j;
            //Console.WriteLine(checkIntergers(1,2));

            //Action printSomething = () => Console.WriteLine("Printing");  // no inputs
            //printSomething();

            ////Anonymus method
            //Action<int, int> sumOfTwoNumbera = (i, j) =>
            //{
            //    Console.WriteLine("The i number is : " + i);
            //    Console.WriteLine("The j number is : " + j);
            //    Console.WriteLine("The sum of i+j number is : " + (i+j));
            //};

            //sumOfTwoNumbera(1, 2);



            string[] names = { "Alice", "John", "Bobby", "Kyle", "Scott", "Tod", "Sharon", "Armin", "George" };

            Func<string[], Func<string, bool>, List<string>> extractStrings = (array, filter) =>
            {
                List<string> result = new List<string>();

                foreach (var item in array)
                {
                    if (filter(item))
                    {
                        result.Add(item);
                    }
                }
                return result;
            };

            Func<string, bool> lessThanFive = x => x.Length < 5;
            Func<string, bool> moreThanFive = x => x.Length > 5;
            Func<string, bool> exactlyFive = x => x.Length == 5;

            List<string> namesLessThanFiveChars = extractStrings(names, lessThanFive);
            Console.WriteLine(string.Join(", ", namesLessThanFiveChars));

            List<string> namesMoreThanFiveChars = extractStrings(names, moreThanFive);
            Console.WriteLine(string.Join(", ", namesMoreThanFiveChars));

            List<string> namesWithexactlyFiveChars = extractStrings(names, exactlyFive);
            Console.WriteLine(string.Join(", ", namesWithexactlyFiveChars));


            Console.ReadKey();
        }
    }
}
