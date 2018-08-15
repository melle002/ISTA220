using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyRate
{
    class Program
    {
        private double calculateFee(double theDailyRate = 500.0, int no0fDays = 1)

        {
            Console.WriteLine("calculateFee using two optional parameters");
            return theDailyRate * no0fDays;

        }
        
        private double calculateFee(double dailyRate = 500.0)

        {
            Console.WriteLine("calculateFee using one optional parameter");
            int defaultNo0fDays = 1;
            return dailyRate * defaultNo0fDays;

        }

        private double calculateFee()

        {
            Console.WriteLine("caculateFee using hardcoded values");
            double defaultDailyRate = 400.0;
            int defaultNn0fDays = 1;
            return defaultDailyRate * defaultNn0fDays;

        }
        static void Main(string[] args)
        {
            (new Program()).run();
        }

        public void run()
        {
            double fee = calculateFee(theDailyRate : 375.0);
            Console.WriteLine($"Fee is {fee}");

        }
    }
}
