using Examples.Ferocia.TDCalculator.Domain.Interests;
using Examples.Ferocia.TDCalculator.Domain.Services;

namespace Examples.Ferocia.TDCalculator.Services.InterestServices
{
    internal class CompoundInterestCalculatorService : ICompoundInterestCalculatorService
    {
        ///Using https://moneysmart.gov.au/saving/compound-interest
        ///and its simplified form https://www.calculatorsoup.com/calculators/financial/compound-interest-calculator.php
        ///A = P(1 + r/n)^nt
        ///A = Final amount(principal + accrued interest)
        ///P = Principal starting amount
        ///r = Annual nominal interest rate as a decimal
        ///n = number of compounding periods per unit of time
        ///t = time compounded in years/months/quarter.
        public double CalculateCompoundedAmount(YearlyCompoundInterest compoundInterest)
        {            
            if (compoundInterest == null)
                throw new ArgumentNullException("Yearly Compound Interest cannot be null");

            var baseValue = 1 + ((compoundInterest.InterestRate) / (int)compoundInterest.Compounded);//(1 + r/n)
            var exponent = (int)compoundInterest.Compounded * compoundInterest.InvestmentYears;//nt
            var compoundedAmount = compoundInterest.InitialDeposit * Math.Pow(baseValue, exponent);//P(1 + r/n)^nt

            //var compoundedAmount = compoundInterest.InitialDeposit * Math.Pow(1 + compoundInterest.InterestRate / (int)compoundInterest.Compounded, (int)compoundInterest.Compounded * compoundInterest.InvestmentYears);
            return compoundedAmount;
        }
    }
}
