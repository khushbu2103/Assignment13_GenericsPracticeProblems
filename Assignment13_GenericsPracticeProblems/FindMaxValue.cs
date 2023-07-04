using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13_GenericsPracticeProblems
{
    public class FindMaxValue
    {
        public static T FindMaximum<T>(T first, T second, T third) where T : IComparable<T>
        {


            if (first.CompareTo(second) >= 0 && first.CompareTo(third) >= 0)
            {
                Console.WriteLine("{0} is greater value", first);
                return  first;
            }
            else if (second.CompareTo(first) >= 0 && second.CompareTo(third) >= 0)
            {
                Console.WriteLine("{0} is greater value", second);
                return  second;
            }
            else
            {
                Console.WriteLine("{0} is greater value", third);
                return  third;
            }
        }

       




    }
}
