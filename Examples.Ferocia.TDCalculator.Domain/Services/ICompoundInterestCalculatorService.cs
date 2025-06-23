using Examples.Ferocia.TDCalculator.Domain.Interests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Ferocia.TDCalculator.Domain.Services
{
    public interface ICompoundInterestCalculatorService
    {
        public double CalculateCompoundedAmount(YearlyCompoundInterest compoundInterest);
    }
}
