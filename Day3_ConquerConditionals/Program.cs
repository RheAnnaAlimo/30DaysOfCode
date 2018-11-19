﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_ConquerConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            //Given an integer, n , perform the following conditional actions:
            //If n is odd, print Weird
            //If n is even and in the inclusive range of 2 to 5, print Not Weird
            //If n is even and in the inclusive range of 6 to 20, print Weird
            //If n is even and greater than 20, print Not Weird

            if (N % 2 == 1)
            {
                Console.WriteLine("Weird");
            }
            if (N % 2 == 0 && N>= 2 && N<5 )
            {
                Console.WriteLine("Not Weird");
            }
            if (N % 2 == 0 && N >= 6 && N <= 20)
            {
                Console.WriteLine("Weird");
            }
            if (N % 2 == 0 && N > 20)
            {
                Console.WriteLine("Not Weird");
            }
        }
    }
}
