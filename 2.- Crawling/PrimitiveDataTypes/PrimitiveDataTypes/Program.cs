using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveDataTypes
{
    /// <summary>
    /// Data Types Example
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int exampleInteger     = 1;
            long exampleLong       = 1000000;
            float exampleFloat     = 1.11F;
            double exampleDouble   = 1.1234567890;
            decimal exampleDecimal = 1029999912312312515151231231M;
            string exampleString   = "You're an animal Jim";
            char exampleChar       = 'z';
            bool exampleBoolean    = true;

            // We print out the variables in order, with a brief explanation
            Console.WriteLine("Different Data Types!");

            Console.WriteLine("An Integer is a round number like: " + exampleInteger.ToString());

            Console.WriteLine("A Long is a 64bit integer: " + exampleLong.ToString());

            Console.WriteLine("A Float is a number with decimal points, it has to finish with the letter 'F': " + exampleFloat.ToString());

            Console.WriteLine("A Double is a 64 bit number with decimal points: " + exampleDouble.ToString());

            Console.WriteLine("A Decimal is a turbo long number, it has to finish with the letter 'M': " + exampleDecimal.ToString());

            Console.WriteLine("A string is a sentence between quotation marks \"Like so\": " + exampleString);

            Console.WriteLine("A char is a single letter, it is set between single quotation marks 'a': " + exampleChar);

            Console.WriteLine("A boolean is a 2 bit variable that can be true or false: " + exampleBoolean.ToString());

        }
    }
}
