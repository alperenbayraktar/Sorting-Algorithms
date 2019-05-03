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
        static int global = 0;                      //We need this global value to know if we are at the last element of the line.
        static void Main(string[] args)
        {

            int[] lengths = new int[100];           // Creating the array that we hold length values for the loop below.
            int x = 0;                              // lengths go like 1000, 2000, 3000, 4000.........99000, 100000.
            for (int i = 0; i < lengths.Length; i++)
            {
                lengths[i] = x + 1000;
                x += 1000;
            }
            for (int k = 0; k < lengths.Length; k++)                          //100 different tests
            {
                for (int i = 0; i < lengths.Length; i++)                    //Testing with 100 different input sizes.
                {
                    Console.WriteLine("Array Length is: " + lengths[i]);
                    int[] input = createArray(lengths[i]);                  //Creating different sized, random valued input arrays.
                    //execute("insertion", input);                            //Sorting the same input array with different methods.
                    //execute("merge", input);
                    //execute("counting", input);
                    //execute("heap", input);
                    execute("quick", input);
                    global++;                                               //When this hits 99, we are going to get to a new line + new test
                }
                global = 0; //Need to reset the value for the next iteration.
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
        static int[] createArray(int length)                                //Creates an array with random valued numbers between 0,1000 for given size(length). 
        {
            int[] input = new int[length];
            Random random = new Random();
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = random.Next(0, 1000);
            }
            return input;
        }
        static int[] createBestArray(int length)                            //Creates the best case array for given size(length).
        {
            int[] input = new int[length];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = 1;
            }
            return input;
        }
        static void printArray(int[] arr)                                   //prints the array (for testing at development phase)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");

            Console.Write("\n");
        }
        static void execute(string selection, int[] input)                  //sorts for desired algorithm and input array. 
        {
            long basic = 0;
            string path = "";
            string pathTime = "";
            int[] output = new int[input.Length];
            Array.Copy(input, output, input.Length);                        //Copying the context of the input array to a new array to avoid losing content of input.
            StringResources sr = new StringResources();                     //This is the string resource class that we use to prevent code complexity.
            string title = "";
            var watch = System.Diagnostics.Stopwatch.StartNew();            //Starts the clock.
            switch (selection)
            {
                case "insertion":
                    title = sr.insertion;
                    path = "insertion.txt";
                    InsertionSort ins = new InsertionSort();
                    ins.sort(output);
                    basic = ins.basicOp;
                    break;
                case "merge":
                    title = sr.merge;
                    path = "merge.txt";
                    MergeSort mer = new MergeSort();
                    mer.mergeSort(output, 0, output.Length - 1);
                    basic = mer.basicOp;
                    break;
                case "counting":
                    title = sr.counting;
                    path = "counting.txt";
                    CountingSort con = new CountingSort();
                    con.sort(output);
                    basic = con.basicOp;
                    break;
                case "quick":
                    title = sr.quick;
                    path = "quick.txt";
                    pathTime = "quickTime.txt";
                    QuickSort quick = new QuickSort();
                    quick.quickSort(output, 0, output.Length - 1);
                    basic = quick.basicOp;
                    break;
                case "heap":
                    path = "heap.txt";
                    title = sr.heap;
                    HeapSort heap = new HeapSort();
                    heap.heapSort(output, output.Length);
                    basic = heap.basicOp;
                    break;
                default:
                    break;
            }
            Console.WriteLine(title);
            //Console.WriteLine(sr.init);                               //Testing at development phase
            //printArray(input);
            //Console.WriteLine(sr.sorted);
            //printArray(output);
            watch.Stop();                                                   //Stops the clock.
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.Write(sr.time);
            Console.WriteLine(elapsedMs);
            string time = "" + elapsedMs;
            string bS = "" + basic;
            Console.WriteLine();
            path = pathCreate(path);
            append(bS, path);
            pathTime = pathCreate(pathTime);
            append(time, pathTime);
        }
        static void append(string input, string path)           //Appends the new content to the input file.
        {
            using (StreamWriter file = new StreamWriter(@path, true))
            {
                if (global == 99)                             //When the global counter hits 99, appends the value and proceeds to the new line.
                {
                    file.Flush();
                    file.WriteLine(input);
                    file.Close();
                }
                else
                {                                            //Writes thhe value to the same line in data file.
                    file.Flush();
                    file.Write(input + " ");
                    file.Close();
                }
            }
        }
        static string pathCreate(string path)
        {
            string workingDirectory = Environment.CurrentDirectory;                     //To get to solutions directory for updating the data files.
            string fileLoc = Directory.GetParent(workingDirectory).Parent.FullName;
            path = fileLoc + "\\Resources\\" + path;
            return path;
        }
        static void theoreticals()
        {

        }
    }
    
}
