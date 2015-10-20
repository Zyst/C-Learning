using System;

namespace Extensions
{
	static class Util
	{
        /// <summary>
        /// Converts an integer to a specified base between 2 and 10
        /// </summary>
        /// <param name="i">Number to convert</param>
        /// <param name="baseToConvertTo">Base to Convert To</param>
        /// <returns>Number to convert converted to a specified base number.</returns>
		public static int ConvertToBase(this int i, int baseToConvertTo)
        {
            // If base is outside of our range throw exception and end.
            if (baseToConvertTo < 2 || baseToConvertTo > 10)
            {
                throw new ArgumentException("Value cannot be converted to base " + baseToConvertTo.ToString());
            }

            int result = 0;
            int iterations = 0;

            do
            {
                int nextDigit = i % baseToConvertTo;
                i /= baseToConvertTo;

                result += nextDigit * (int)Math.Pow(10, iterations);

                iterations++;
            }
            while (i != 0);

            return result;
        }
	}
}