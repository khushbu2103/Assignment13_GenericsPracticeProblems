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
            string result1= FindMaxValue.FindMaximumString("ghi", "def", "abc");
            Console.WriteLine("Test case 1: Max number at first position: " + result1);

            string result2 = FindMaxValue.FindMaximumString("ghi", "def", "abc");
            Console.WriteLine("Test case 2: Max number at second position: " + result2);

            string result3 = FindMaxValue.FindMaximumString("ghi", "def", "abc");
            Console.WriteLine("Test case 3: Max number at third position: " + result3);
            Console.ReadLine();
        }

       
    }
}
