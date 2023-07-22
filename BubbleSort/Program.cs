using System;

//int[] thearray = new int[6] { 6, 9, 1, 4, 10, 3 };

namespace BubbleSort
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

            int temp;

            WriteArray(thearray);
            WriteTime();

            for (int i = 0; i < thearray.Length; i++)
            {
                for (int j = 0;j < thearray.Length; j++)
                {
                    if (thearray[i] < thearray[j])
                    {
                       temp = thearray[i];
                       thearray[i] = thearray[j];
                       thearray[j] = temp;
                    }
                }
            }

            WriteTime();
            WriteArray(thearray);
        }
    }
}
