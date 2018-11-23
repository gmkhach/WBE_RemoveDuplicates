/*
 * Write a method that takes a sentence and removes all duplicate characters except spaces.
 * Example: "Hello there, how are you?" will be returned as "Helo ther, w a yu?"
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.Write("Enter a sentence\n\n>>> ");
                    string input = Console.ReadLine().Trim();
                    Console.WriteLine($"\nResult: {RemoveDuplicates(input)}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.Write("\nPress Enter to try another sentence...");
                Console.ReadLine();
                Console.Clear();
            } while (true);
        }

        static string RemoveDuplicates(string input)
        {
            Queue<char> myQ = new Queue<char>();
            StringBuilder mySb = new StringBuilder();
            // collecting the unique characters
            foreach (char ch in input)
            {
                if (ch == ' ' || !myQ.Contains(ch))
                {
                    myQ.Enqueue(ch);
                }
            }
            // building the duplicate-free sentence
            foreach (char ch in myQ)
            {
                mySb.Append(ch);
            }
            return mySb.ToString();
        }
    }
}
