using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Training.LinqAndLambdas
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
           // string sentence = "I love cats";
            string[] catNames = { "Lucky", "Bella", "Luna", "Simba", "Oreo", "Toby", "Oscar", "Loki" };
            int[] numbers = { 5, 6, 3, 2, 1, 5, 6, 7, 8, 4, 234, 54, 14, 653, 3, 4, 5, 6, 7 };


            var catsWithA = from cat in catNames
                            where cat.Contains("a") && (cat.Length < 5)
                            select cat;


            var getTheNumbers = from number in numbers
                                where (number > 5)
                                where (number < 10)
                                orderby number
                                select number;

            List<int> newNumbers = new List<int>();
            foreach (var number in numbers)
            {
                if (number < 5)
                {
                    newNumbers.Add(number);
                }
            }

            Console.WriteLine(string.Join(", ", getTheNumbers));
            //Console.WriteLine(string.Join(", ", newNumbers));
           Console.WriteLine(string.Join(", ", catsWithA));

            Console.ReadKey();
        }
    }
}
