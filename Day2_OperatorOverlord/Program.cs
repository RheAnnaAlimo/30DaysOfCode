using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_OperatorOverlord
{
    class Program
    {
        static void Main(string[] args)
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine());
            int tip_percent = Convert.ToInt32(Console.ReadLine());
            int tax_percent = Convert.ToInt32(Console.ReadLine());
            solve(meal_cost, tip_percent, tax_percent);
        }
            //Task
            //Given the meal price(base cost of a meal), 
            //tip percent(the percentage of the meal price being added as tip), 
            //and tax percent(the percentage of the meal price being added as tax) for a meal, 
            //find and print the meal's total cost.

        static void solve(double meal_cost, int tip_percent, int tax_percent)
            {
            double tip = meal_cost * tip_percent / 100;
            double tax = meal_cost * tax_percent / 100;
            double totalCost = meal_cost + tip + tax;

            Console.WriteLine("The total meal cost is {0} dollars.", Math.Round(totalCost));
        }
    }
}
