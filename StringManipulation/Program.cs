using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //string hello = "This is some text";
            //var upperHello = hello.ToUpper();

            //Console.WriteLine(upperHello);


            //if (string.IsNullOrWhiteSpace(hello)) 
            //{

            //    Console.WriteLine("Nothing here");
            //}

            //var both = string.Concat(hello, upperHello, "Even More Text");

            //var length = upperHello.Length;

            //Console.WriteLine(length);
            //Console.ReadLine();






           // /*
           // 3.24 Afternoon String Lab NOT OPTIMIZED
           // */

           ////Instantiate the string as an array of strings
           //string[] stringArray = new string[] { "This", "is", "a", "string", "of", "text" };

           ////Concat each array index as a single string in reverse order
           //string stringArrayReverse = (stringArray[5] + " " + stringArray[4] + " " + stringArray[3] + " " + stringArray[2] + " " + stringArray[1] + " " + stringArray[0]);

           ////Print stringArrayReverse to the console
           //Console.WriteLine(stringArrayReverse);

           ////Concat each array index as a single string in normal order and transform text to uppercase.
           //string stringArrayUpperCase = (stringArray[0] + " " + stringArray[1] + " " + stringArray[2] + " " + stringArray[3] + " " + stringArray[4] + " " + stringArray[5]).ToUpper();

           ////Print stringArrayUpperCase to the console
           //Console.WriteLine(stringArrayUpperCase);

           ////Concat every string as a single string seperated by commas
           //string stringArrayCommas = (stringArray[0] + "," + stringArray[1] + "," + stringArray[2] + "," + stringArray[3] + "," + stringArray[4] + "," + stringArray[5]);

           //Console.WriteLine(stringArrayCommas);

           //Console.ReadLine();






            /*
            3.24 afternoon string lab OPTIMIZED
            */

            //Init String
            Console.WriteLine("Write a sentence, any sentence that you would like!");
            var inputString = Console.ReadLine();

            //Split words and insert into an array
            string[] words = inputString.Split(' ');

            //Reverse the order of the array
            Array.Reverse(words);

            //Iterate over each array item
            foreach (var item in words)
            {
                //Convert Array item to string
                string reversedString = item.ToString() + " ";
                //Print to the console
                Console.Write(reversedString);
            }

            //Insert Line Breaks
            Console.WriteLine(" ");
            //Insert Line Breaks
            Console.WriteLine(" ");


            //Correct the order of the array
            Array.Reverse(words);

            //Iterate over each array item
            foreach (var item in words)
            {
                //Convert Array item to string
                string nonReversedString = (item.ToString() + " ").ToUpper();
                //Print to the console
                Console.Write(nonReversedString);
            }

            //Insert Line Breaks
            Console.WriteLine(" ");
            //Insert Line Breaks
            Console.WriteLine(" ");

            
            //Iterate over each array item
            foreach (var item in words)
            {
                //Convert Array item to string seperated by commas
                string commaSeperatedString = (item.ToString() + ",");

                //Print to the console
                Console.Write(commaSeperatedString);

            }

            Console.ReadLine();

        }
    }
}
