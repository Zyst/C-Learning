using System;

namespace DailyRate
{
    /// <summary>
    /// Overloading and Optional test
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }


        // Use one of the double fees below for functionality testing
        void run()
        {
            // double fee = calculateFee(); // 400

            // double fee = calculateFee(650.0); // 650

            // double fee = calculateFee(500.0, 3); // 1500

            // double fee = calculateFee(dailyRate: 375.0); // 375

            // double fee = calculateFee(noOfdays: 4); // 2000

            // double fee = calculateFee(theDailyRate: 375.0); // 375. having changed this from 'dailyRate' to 
                                                              // 'theDailyRate' allows both methods to exist.

            // Use any of the above 

            Console.WriteLine("Fee is {0}", fee);
        }

        // 'dailyRate' renamed to 'theDailyRate' to test more optionals stuff
        private double calculateFee(double theDailyRate = 500.0, int noOfdays = 1)
        {
            Console.WriteLine("calculateFee using two optional parameters.");

            return theDailyRate * noOfdays;
        }

        private double calculateFee(double dailyRate = 500.0)
        {
            Console.WriteLine("calculateFee using one optional parameter");

            int defaultNoOfDays = 1;

            return dailyRate * defaultNoOfDays;
        }

        private double calculateFee()
        {
            Console.WriteLine("calculateFee using hardcoded values");

            double defaultDailyRate = 400.0;
            int defaultNoOfDays = 1;

            return defaultDailyRate * defaultNoOfDays;
        }
    }
}
