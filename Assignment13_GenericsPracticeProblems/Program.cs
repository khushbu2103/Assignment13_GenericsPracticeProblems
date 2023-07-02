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
            float result1= FindMaxValue.FindMaximumInteger(45.67f, 76.76f, 60.87f);
            Console.WriteLine("Test case 1: Max number at first position: " + result1);

            float result2 = FindMaxValue.FindMaximumInteger(45.67f, 76.76f, 60.87f);
            Console.WriteLine("Test case 2: Max number at second position: " + result2);

            float result3 = FindMaxValue.FindMaximumInteger(45.67f, 76.76f, 60.87f);
            Console.WriteLine("Test case 3: Max number at third position: " + result3);
            Console.ReadLine();
        }

       
    }
}
