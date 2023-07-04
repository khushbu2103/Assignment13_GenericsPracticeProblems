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


            // Test cases with integers
            int result1 = FindMaxValue<int>.TestMaximum(25, 87, 43, 65, 32);
            Console.WriteLine("Test case 1 with integers: Max number: " + result1);
            int result2 = FindMaxValue<int>.TestMaximum(1, 2, 3, 4, 5);
            Console.WriteLine("Test case 2 with integers: Max number: " + result2);
            int result3 = FindMaxValue<int>.TestMaximum(6);
            Console.WriteLine("Test case 3 with integers: Max number: " + result3);
            int result4 = FindMaxValue<int>.TestMaximum();
            Console.WriteLine("Test case 4 with integers: Max number: " + result4);

            // Test cases with strings
            string result5 = FindMaxValue<string>.TestMaximum("banana", "apple", "cherry", "orange", "grape");
            Console.WriteLine("Test case 1 with strings: Max string: " + result5);

            string result6 = FindMaxValue<string>.TestMaximum("a", "b", "c", "d", "e");
            Console.WriteLine("Test case 2 with strings: Max string: " + result6);

            string result7 = FindMaxValue<string>.TestMaximum("abc");
            Console.WriteLine("Test case 3 with strings: Max string: " + result7);

            string result8 = FindMaxValue<string>.TestMaximum();
            Console.WriteLine("Test case 4 with strings: Max string: " + (result8 ?? "null"));

            // Test cases using the generic class
            FindMaxValue<int> maxInt = new FindMaxValue<int>(15, 10, 5, 20, 25);
            int result9 = maxInt.TestMaximum();
            Console.WriteLine("Test case using the generic class with integers: Max number: " + result9);

            FindMaxValue<string> maxString = new FindMaxValue<string>("banana", "apple", "cherry", "orange", "grape");
            string result10 = maxString.TestMaximum();
            Console.WriteLine("Test case using the generic class with strings: Max string: " + result10);

            Console.ReadLine();
        }

       
    }
}
