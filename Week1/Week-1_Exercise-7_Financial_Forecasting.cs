using System;

namespace InvestmentProjection
{
    class RecursionBasedForecast
    {
        
        public static double CalculateFutureAmount(double currentAmount, double rate, int period)
        {
            if (period == 0)
                return currentAmount;

            return CalculateFutureAmount(currentAmount, rate, period - 1) * (1 + rate);
        }

        
        static void Main(string[] args)
        {
            double baseValue = 3500;
            double rate = 0.06; 
            int duration = 5;   

            double projectedAmount = CalculateFutureAmount(baseValue, rate, duration);
            Console.WriteLine($"Projected value after {duration} years: ₹{projectedAmount:F2}");
        }
    }
}
