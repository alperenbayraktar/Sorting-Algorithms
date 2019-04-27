using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Application
    {
        static void Main(string[] args)
        {
            int[] arr = { 67, 12, 95, 56, 85, 1, 100, 23, 60, 9 };
            int n = 10, i;
            Console.WriteLine("Quick Sort");
            Console.Write("Initial array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            QuickSort quick = new QuickSort();
            quick.quickSort(arr, 0, 9);
            Console.Write("\nSorted Array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.Write("\n\n");


            //HEAPSORT

            int[] arr2 = { 55, 25, 89, 34, 12, 19, 78, 95, 1, 100 };
            int m = 10, j;
            Console.WriteLine("Heap Sort");
            Console.Write("Initial array is: ");
            for (j = 0; j < m; j++)
            {
                Console.Write(arr2[j] + " ");
            }
            HeapSort heap = new HeapSort();
            heap.heapSort(arr2, 10);
            Console.Write("\nSorted Array is: ");
            for (j = 0; j < n; j++)
            {
                Console.Write(arr2[j] + " ");
            }
        }
    }
}
