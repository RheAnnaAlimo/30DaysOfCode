using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_DoubleDownOnDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            // Declare second integer, double, and String variables.
            int num;
            double fullnum;
            string quotes;

            // Read and save an integer, double, and String to your variables.
            num = Convert.ToInt32(Console.ReadLine());
            fullnum = Convert.ToDouble(Console.ReadLine());
            quotes = Console.ReadLine();

            // Print the sum of both integer variables on a new line.
            Console.WriteLine(num + i);

            // Print the sum of the double variables on a new line.
            Console.WriteLine(string.Format("{0:0.0}", fullnum + d));

            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine(s + quotes);
        }
    }
}
