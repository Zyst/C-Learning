using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectionDemo
{
    class Program
    {
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
            //Calculator calculator = new Calculator();

            //Console.WriteLine("{0} / {1} = {2}", 120, 15, calculator.Divide(125, 15));

            //Console.WriteLine("Program finishing.");

            using (Calculator calculator = new Calculator())
            {
                Console.WriteLine("{0} / {1} = {2}", 120, 0, calculator.Divide(125, 0));
            }

            Console.WriteLine("Program finishing");
        }
    }
}
