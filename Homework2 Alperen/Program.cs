using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputInsertion = { 12, 11, 13, 5, 6 };
            Console.WriteLine("InsertionSort: ");
            InsertionSort ins = new InsertionSort();
            ins.sort(inputInsertion);
            printArray(inputInsertion);

            int[] inputMerge = { 76, 89, 23, 1, 55, 78, 99, 12, 65, 100 };
            Console.WriteLine("MergeSort: ");
            MergeSort mer = new MergeSort();
            mer.mergeSort(inputMerge, 0, inputMerge.Length - 1);
            printArray(inputMerge);

            int[] inputCount = { 762, 819, 235, 12, 545, 178, 99, 12, 645, 100 };
            Console.WriteLine("CountingSort: ");
            CountingSort con = new CountingSort();
            con.sort(inputCount);
            printArray(inputCount);

            int[] inputQuick = { 67, 12, 95, 56, 85, 1, 100, 23, 60, 9 };
            Console.WriteLine("Quick Sort: ");
            Console.Write("Initial array is: ");
            printArray(inputQuick);
            QuickSort quick = new QuickSort();
            quick.quickSort(inputQuick, 0, inputQuick.Length - 1);
            Console.Write("Sorted Array is: ");
            printArray(inputQuick);

            int[] inputHeap = { 55, 25, 89, 34, 12, 19, 78, 95, 1, 100 };
            Console.WriteLine("Heap Sort: ");
            Console.Write("Initial array is: ");
            printArray(inputHeap);
            HeapSort heap = new HeapSort();
            heap.heapSort(inputHeap, 10);
            Console.Write("Sorted Array is: ");
            printArray(inputHeap);
        }
        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");

            Console.Write("\n");
        }
    }
}
