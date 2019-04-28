using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lengths = new int[100];           // Creating the array that we hold length values for the loop below.
            int x = 0;                              // lengths go like 5000, 10000, 15000, 20000.........495000, 500000.
            for (int i = 0; i < 100; i++)
            {
                lengths[i] = x + 5000;
                x += 5000;
            }

            for (int i = 0; i<lengths.Length;i++)
            {
                Console.WriteLine("Array Length is: " + lengths[i]);
                int[] input = createArray(lengths[i]);            
                execute("insertion", input);
                execute("merge", input);
                execute("counting", input);
                execute("heap", input);
                execute("quick", input);
            }
            //for (int i = 0; i < lengths.Length; i++)
            //{
            //    Console.WriteLine("Array Length is: " + lengths[i]);
            //    int[] input = createBestArray(lengths[i]);
            //    execute("insertion", input);
            //    execute("merge", input);
            //    execute("counting", input);
            //    execute("heap", input);
            //    execute("quick", input);
            //}
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
        static int[] createBestArray(int length)
        {
            int[] input = new int[length];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = 1;
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
            string path = "";
            int[] output = new int[input.Length];
            Array.Copy(input, output, input.Length);
            StringResources sr = new StringResources();
            string title = "";
            var watch = System.Diagnostics.Stopwatch.StartNew();
            switch (selection)
            {
                case "insertion":
                    title = sr.insertion;
                    path = "insertion.txt";
                    InsertionSort ins = new InsertionSort();
                    ins.sort(output);
                    break;
                case "merge":
                    title = sr.merge;
                    path = "merge.txt";
                    MergeSort mer = new MergeSort();
                    mer.mergeSort(output, 0, output.Length - 1);
                    break;
                case "counting":
                    title = sr.counting;
                    path = "counting.txt";
                    CountingSort con = new CountingSort();
                    con.sort(output);
                    break;
                case "quick":
                    title = sr.quick;
                    path = "quick.txt";
                    QuickSort quick = new QuickSort();
                    quick.quickSort(output, 0, output.Length - 1);
                    break;
                case "heap":
                    path = "heap.txt";
                    title = sr.heap;
                    HeapSort heap = new HeapSort();
                    heap.heapSort(output, output.Length );
                    break;
                default:
                    break;
            }
            Console.WriteLine(title);
            //Console.WriteLine(sr.init);
            //printArray(input);
            //Console.WriteLine(sr.sorted);
            //printArray(output);
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.Write(sr.time);
            Console.WriteLine(elapsedMs);
            string time = "" + elapsedMs;
            Console.WriteLine();
            append(time, path);
        }
        static void append(string input,string path)           //Adds input to the out.txt
        {
            using (StreamWriter file = new StreamWriter(@path, true))          
            {
                file.WriteLine(input);
            }
        }
    }
    
}
