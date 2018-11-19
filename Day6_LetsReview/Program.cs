using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_LetsReview
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task
            //Given a string, S, of length N that is indexed from 0 to N-1, 
            //print its even-indexed and odd-indexed characters as 2 space-separated strings on a single line.
            //The first line contains an integer,  (the number of test cases). 
            //Each line i of the T subsequent lines contain a String, S.

            int T = Convert.ToInt32(Console.ReadLine());
            string[] s1 = new string[T];

            int i = 0;
            while (i < T)
            {
                string s = Console.ReadLine();
                s1[i++] = s;
            }

            i = 0;
            while (i < T)
            {
                char[] c1 = s1[i].ToCharArray();
                string even = "";
                string odd = "";
                for (int j = 0; j < c1.Length; j++)
                {
                    if (j % 2 == 0) even += c1[j];
                    if (j % 2 != 0) odd += c1[j];
                }
                Console.WriteLine(even + " " + odd);
                i++;
            }
        }
    }
}
