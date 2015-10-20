#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Parameters
{
    class Program
    {
        static void doWork()
        {
            //int i = 0;

            //Console.WriteLine(i); // 0

            //Pass.Value(i);

            //Console.WriteLine(i); // 0: As expected, the value is unchanged


            // ----------------------------------------------------------------


            //WrappedInt wi = new WrappedInt();

            //Console.WriteLine(wi.Number); // 0

            //Pass.Reference(wi);

            //Console.WriteLine(wi.Number); // 42: Because we are editing the object value.


            // ----------------------------------------------------------------


            int i = 0;

            Console.WriteLine(i); // 0

            Pass.RefValue(ref i);

            Console.WriteLine(i); // 42: The ref keyword allowed us to edit it directly.
        }

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
    }
}
