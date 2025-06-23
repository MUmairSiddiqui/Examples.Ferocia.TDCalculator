using Examples.Ferocia.TDCalculator.Domain.Interests;
using Examples.Ferocia.TDCalculator.Domain.Services;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Examples.Ferocia.TDCalculator.Services.InterestServices
{
    internal class CompoundInterestCalculatorService : ICompoundInterestCalculatorService
    {
        public double CalculateCompoundedAmount(YearlyCompoundInterest compoundInterest)
        {
            ///Using https://moneysmart.gov.au/saving/compound-interest
            ///and its simplified form https://www.calculatorsoup.com/calculators/financial/compound-interest-calculator.php
            ///A = P(1 + r/n)nt
            ///A = Final amount(principal + accrued interest)
            ///P = Principal starting amount
            ///r = Annual nominal interest rate as a decimal
            ///n = number of compounding periods per unit of time
            ///t = time compounded in years/months/quarter.
            var compoundedAmount = compoundInterest.InitialDeposit * Math.Pow(1 + compoundInterest.InterestRate / (int)compoundInterest.Compounded, (int)compoundInterest.Compounded * compoundInterest.InvestmentYears);
            return compoundedAmount;
        }
    }
}
