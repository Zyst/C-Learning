using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ListVersusArray
{
    class Program
    {
        /// <summary>
        /// A really straightforward and superficial way to check if arrays or lists are faster.
        /// </summary>
        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void doWork()
        {
            const int goal = 10000000;
            Stopwatch stopWatch = new Stopwatch();

            List<int> list = new List<int>();
            int[] array = new int[goal];

            stopWatch.Start();
            for (int i = 0; i < goal; i++) // Fill up the List in a slow way.
            {
                list.Add(i);
            }
            stopWatch.Stop();
            Console.WriteLine("List took: {0} ms to be filled with {1} elements.", stopWatch.ElapsedMilliseconds, goal);
            stopWatch.Reset();

            stopWatch.Start();
            for (int i = 0; i < goal; i++)
            {
                array[i] = i;
            }
            stopWatch.Stop();
            Console.WriteLine("Array took: {0} ms to be filled with {1} elements.\n", stopWatch.ElapsedMilliseconds, goal);
            stopWatch.Reset();

            // ----------------------------------------------------------------
            // Now we'll check how fast access is on Lists and Arrays
            // ----------------------------------------------------------------

            stopWatch.Start();
            foreach (int i in list)
            {
                // Do nothing. We're just accessing the value.
            }
            stopWatch.Stop();
            Console.WriteLine("List took: {0} ms to access all of its {1} elements.", stopWatch.ElapsedMilliseconds, goal);
            stopWatch.Reset();

            stopWatch.Start();
            foreach (int i in array)
            {
                // Do nothing. We're just accessing the value.
            }
            stopWatch.Stop();
            Console.WriteLine("Array took: {0} ms to access all of its {1} elements.\n", stopWatch.ElapsedMilliseconds, goal);
            stopWatch.Reset();

            // ----------------------------------------------------------------
            // Now we'll check how fast editing all the values on either of them is
            // ----------------------------------------------------------------

            stopWatch.Start();
            for (int i = 0; i < goal; i++)
            {
                list[i]++;
            }
            stopWatch.Stop();
            Console.WriteLine("List took: {0} ms to add 1 to all of its {1} elements.", stopWatch.ElapsedMilliseconds, goal);
            stopWatch.Reset();

            stopWatch.Start();
            for (int i = 0; i < goal; i++)
            {
                array[i]++;
            }
            stopWatch.Stop();
            Console.WriteLine("Array took: {0} ms to add 1 to all of its {1} elements.", stopWatch.ElapsedMilliseconds, goal);
            stopWatch.Reset();
        }
    }
}
