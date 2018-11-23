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
            foreach(char ch in input)
            {
                if (ch == ' ' || !myQ.Contains(ch))
                {
                    myQ.Enqueue(ch);
                }
            }
            StringBuilder mySb = new StringBuilder();
            foreach (char ch in myQ)
            {
                mySb.Append(ch);
            }
            return mySb.ToString();
        }
    }
}
