using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class QuickSort
    {
        static int partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];                              //pivot is the line(number) before the last element like: 1 4 4 52 3 1 56 54 | 43
            int i = (low - 1);                                  //this is initially 0.
            for (int j = low; j < high; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;
            return i + 1;
        }
        public void quickSort(int[] arr, int low, int high)     //Divide & Coonquer Structure
        {
            if (low < high)
            {
                int pi = partition(arr, low, high);
                quickSort(arr, low, pi - 1);
                quickSort(arr, pi + 1, high);
            }
        }
    }
}
