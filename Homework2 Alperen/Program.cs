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
            int[] s = { 10, 20, 30, 40, 50, 32, 34, 54, 5476, 23 };
            execute("quick", s);
            int[] lengths = { 100, 500, 1000, 5000, 10000 };
            for (int i = 0; i<lengths.Length;i++)
            {
                int[] input = createArray(lengths[i]);
                execute("insertion", input);
                execute("merge", input);
                execute("counting", input);
                execute("quick", input);
                execute("heap", input);
                Console.Write("test");
            }     
        }
        static int[] createArray(int length)
        {
            int[] input = new int[length];
            Random random = new Random();
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = random.Next(0, 1000);
            }
            return input;
        }
        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");

            Console.Write("\n");
        }
        static void execute(string selection, int[] input)
        {
            int[] output = new int[input.Length];
            Array.Copy(input, output, input.Length);
            StringResources sr = new StringResources();
            string title = "";
            var watch = System.Diagnostics.Stopwatch.StartNew();
            switch (selection)
            {
                case "insertion":
                    title = sr.insertion;
                    InsertionSort ins = new InsertionSort();
                    ins.sort(output);
                    break;
                case "merge":
                    title = sr.merge;
                    MergeSort mer = new MergeSort();
                    mer.mergeSort(output, 0, output.Length - 1);
                    break;
                case "counting":
                    title = sr.counting;
                    CountingSort con = new CountingSort();
                    con.sort(output);
                    break;
                case "quick":
                    title = sr.quick;
                    QuickSort quick = new QuickSort();
                    quick.quickSort(output, 0, output.Length - 1);
                    break;
                case "heap":
                    title = sr.heap;
                    HeapSort heap = new HeapSort();
                    heap.heapSort(output, 10);
                    break;
                default:
                    break;
            }
            Console.WriteLine(title);
            Console.WriteLine(sr.init);
            printArray(input);
            Console.WriteLine(sr.sorted);
            printArray(output);
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.Write(sr.time);
            Console.WriteLine(elapsedMs);
            Console.WriteLine();
        }
    }
}
