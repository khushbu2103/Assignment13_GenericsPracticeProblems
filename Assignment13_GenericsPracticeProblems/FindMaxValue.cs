using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13_GenericsPracticeProblems
{
    public class FindMaxValue<T> where T : IComparable
    {
        public T x, y, z;
        public FindMaxValue(T a,T b,T c) 
        {
            x = a;
            y = b;
            z = c;
        }

        public static T FindMaximum(T first, T second, T third)
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

        public  void TestMax()
        {
            T res = FindMaximum(x, y, z);
            if (!(res.Equals(0)) || (res.Equals(null)))
            {
                Console.WriteLine("Max Value" + res);
            }
        }

       




    }
}
