#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace StructsAndEnums
{
    class Program
    {
        static void doWork()
        {
            //Month first = Month.January;

            //Console.WriteLine(first); // January

            //first++; // What, this works?!

            //Console.WriteLine(first); // February

            // ----------------------------------------------------------------

            //Month second = Month.December;

            //Console.WriteLine(second); // December

            //second++;

            //Console.WriteLine(second); // 12

            // ----------------------------------------------------------------

            Date defaultDate = new Date();

            Console.WriteLine(defaultDate); // January 1 1900

            Date weddingAniversary = new Date(2013, Month.July, 4);

            Console.WriteLine(weddingAniversary); // July 4 2013

            Date weddingAniversaryCopy = weddingAniversary;

            Console.WriteLine("\nValue of copy is {0}\n", weddingAniversaryCopy); // Value of copy is July 4 2013

            weddingAniversary.AdvanceMonth();

            Console.WriteLine("New value of weddingAniversary is {0}", weddingAniversary); // New value of weddingAniversary is August 4 2013

            Console.WriteLine("Value of copy is still {0}", weddingAniversaryCopy); // Value of copy is still July 4 2013
        }

        static void Main()
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
    }
}
