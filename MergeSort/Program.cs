using System;

namespace MS
{
    class Program
    {
        static void WriteTime()
        {
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss.fffff"));
        }

        static void WriteArray(int[] thearray)
        {
            for (int i = 0; i < thearray.Length; i++)
            {
                Console.Write("{0} ", thearray[i]);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int size = 1000;

            Random rnd = new Random();

            int r = rnd.Next(size);

            int[] thearray = new int[r];
            for (int i = 0; i < thearray.Length; i++)
            {
                thearray[i] = rnd.Next(size);
            }

            WriteArray(thearray);
            WriteTime();

            MS.MergeSortAlgorithm.MergeSort(thearray);

            WriteTime();
            WriteArray(thearray);
        }
    }
}
