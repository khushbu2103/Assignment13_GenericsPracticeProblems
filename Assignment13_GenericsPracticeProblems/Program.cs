using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13_GenericsPracticeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the generics practice problem");


            // Test cases
            int result1= FindMaxInteger.FindMaximumInteger(10, 30, 60);
            Console.WriteLine("Test case 1: Max number at first position: " + result1);

            int result2 = FindMaxInteger.FindMaximumInteger(10, 30, 60);
            Console.WriteLine("Test case 2: Max number at second position: " + result2);

            int result3 = FindMaxInteger.FindMaximumInteger(10, 30, 60);
            Console.WriteLine("Test case 3: Max number at third position: " + result3);
            Console.ReadLine();
        }

       
    }
}
