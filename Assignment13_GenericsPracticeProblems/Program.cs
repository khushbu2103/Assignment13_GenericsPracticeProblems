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
            int result1= FindMaxValue.FindMaximum(25, 87, 43);
            Console.WriteLine("Test case 1: Max number at first position: " + result1);

            float result2 = FindMaxValue.FindMaximum(65.76f, 87.98f, 32.45f);
            Console.WriteLine("Test case 2: Max number at second position: " + result2);

            string result3 = FindMaxValue.FindMaximum("ghi", "def", "abc");
            Console.WriteLine("Test case 3: Max number at third position: " + result3);
            Console.ReadLine();
        }

       
    }
}
