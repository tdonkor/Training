using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Async
{
    class EntryPoint2
    {
        public static void Main1()
        {
            int count = 200000;
            char charToConcatenate = '1';

            Task<string> t = ConcatenateCharsAsync(charToConcatenate, count);

            Console.WriteLine("In Progress");

           // t.Wait(); //- not needed as await

           
            Console.WriteLine("The length of the result is " + t.Result.Length);



            Console.ReadKey();

        }

        public static string ConcatenateChars(char charToConcatenate, int count)
        {
            string concatenatedString = string.Empty;

            for (int i = 0; i < count; i++)
            {
                concatenatedString += charToConcatenate;
            }

            return concatenatedString;
        }

        public async static Task<string> ConcatenateCharsAsync(char charToConcatenate, int count)
        {

            //    Task<string> t = Task<string>.Factory.StartNew(() =>
            //    {
            //        return ConcatenateChars(charToConcatenate, count);
            //    });

            //    string result = await t;
            //    Console.WriteLine("Completed");
            //    return result;
            //replace wit:

            return await Task<string>.Factory.StartNew(() =>
            {
                return ConcatenateChars(charToConcatenate, count);
            });

        }
    }
}
