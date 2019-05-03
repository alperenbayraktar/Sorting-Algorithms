using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class InsertionSort
    {
        public long basicOp = 0;
        public void sort(int[] input)
        {
            int n = input.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = input[i];
                int j = i - 1;
                while (j >= 0 && input[j] > key)
                {
                    basicOp++;
                    input[j + 1] = input[j];
                    j = j - 1;
                }
                input[j + 1] = key;
            }
        }
    }
}
