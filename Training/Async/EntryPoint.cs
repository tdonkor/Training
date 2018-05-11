using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Async
{
    class EntryPoint
    {
        public static void Main2()
        {
            int count = 200000;
            char charToConcatenate = '1';

            //Task is used for void methods
            //Task t = new Task(ConcatenateChars); // requirs an Action delegate that takes no input 
            //use the task Factory however if it requires an input use lambda anonymous method
            //Task t = Task.Factory.StartNew(() => 
            //{
            //    ConcatenateChars(charToConcatenate, count);
            //}); // can emit curly brackets


            // to return something from the method will need func need to give it a generic task and tell it the type and use 
            // the Result property
            Task<string> t = Task.Factory.StartNew(() => ConcatenateChars(charToConcatenate, count)); // can emit curly brackets

            //t.Start();

            Console.WriteLine("In Progress");

            t.Wait();

            Console.WriteLine("Completed");
            Console.WriteLine("The length of the result is " + t.Result.Length);



            Console.ReadKey();

        }

        public static string  ConcatenateChars(char charToConcatenate, int count)
        {
            string concatenatedString = string.Empty;

            for (int i = 0; i < count; i++)
            {
                concatenatedString += charToConcatenate;
            }

            return concatenatedString;
        }
    }
}
