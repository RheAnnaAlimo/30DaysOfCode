using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_InTheLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());

            //Given an integer, n, print its first 10 multiples. 
            //Each multiple n * i (where 1 < i < 10 ) should be printed on a new line in the form: n x i = result.

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(N + " x " + i + " = " + (N * i));
            }
        }
    }
}
