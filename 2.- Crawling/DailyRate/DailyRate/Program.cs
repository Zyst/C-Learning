using System;

namespace DailyRate
{
    /// <summary>
    /// While this entire "program" is extremely simple the main use of this exercise was 
    /// getting used to the Visual Studio debugger. 
    /// 
    /// Right now I'm using Visual Studio 2015, this debug sidebar really makes me feel like I'm living in the future!
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }

        void run()
        {
            double dailyRate = readDouble("Enter your daily rate: ");

            int noOfDays = readInt("Enter number of days: ");
            writeFee(calculateFee(dailyRate, noOfDays));
        }

        private void writeFee(double v)
        {
            Console.WriteLine("The consultant's fee is: {0}", v * 1.1);
        }

        private double calculateFee(double dailyRate, int noOfDays)
        {
            return dailyRate * noOfDays;
        }

        private int readInt(string v)
        {
            Console.Write(v);
            string line = Console.ReadLine();

            return int.Parse(line);
        }

        private double readDouble(string v)
        {
            Console.Write(v);
            string line = Console.ReadLine();

            return double.Parse(line);
        }
    }
}
