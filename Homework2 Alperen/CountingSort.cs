using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class CountingSort
    {
        public int basicOp = 0;
        public void sort(int[] data)
        {
            int min = data.Min();
            int max = data.Max();
            int[] count = new int[max - min + 1];
            int z = 0;

            for (int i = 0; i < count.Length; i++)
            {
                basicOp++;
                count[i] = 0;
            }

            for (int i = 0; i < data.Length; i++)
            {
                count[data[i] - min]++; //increments +1 the frequency of the number that we get from data array to hold how many times that it is occured.
                basicOp++;
            }
                
            for (int i = min; i <= max; i++)
            {
                while (count[i - min]-- > 0)
                {
                    basicOp++;
                    data[z] = i;
                    ++z;
                }
            }
        }
    }
}
