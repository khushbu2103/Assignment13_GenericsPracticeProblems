using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13_GenericsPracticeProblems
{
    public class FindMaxValue<T> where T : IComparable
    {
        private T[] values;

        public FindMaxValue(params T[] values)
        {
            this.values = values;
        }

        public T TestMaximum()
        {
            return FindMaxValue<T>.TestMaximum(values);
        }

        public static T TestMaximum(params T[] values)
        {
            if (values.Length == 0)
            {
                Console.WriteLine("No values provided");
                return default;
            }

            int n = values.Length;
            //bubble sort
            for (int i = 0; i < n - 1; i++)
            {
                bool swapped = false;
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (values[j].CompareTo(values[j+1]) > 0)
                    {
                        T temp = values[j];
                        values[j] = values[j+1];
                        values[j] = temp;
                        swapped = true;
                    }
                }
                if (swapped)
                {
                    break;
                }
            }
            return values[n - 1];

        }
    }
}
