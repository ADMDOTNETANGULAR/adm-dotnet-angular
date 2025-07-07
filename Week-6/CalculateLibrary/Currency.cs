using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateLibrary
{
    public class Currency
    {
        public double ConvertToUSD(double amount, string currencyCode)
        {
            // This is a placeholder for actual conversion logic.
            // In a real application, you would use an API or a database to get the conversion rates.
            switch (currencyCode.ToUpper())
            {
                case "EUR":
                    return amount * 1.1; // Example conversion rate
                case "GBP":
                    return amount * 1.3; // Example conversion rate
                case "JPY":
                    return amount * 0.009; // Example conversion rate
                default:
                    throw new ArgumentException("Unsupported currency code.");
            }
        }
    }
}
