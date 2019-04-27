﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Homework2.InsertionSort;
using static Homework2.MergeSort;

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
