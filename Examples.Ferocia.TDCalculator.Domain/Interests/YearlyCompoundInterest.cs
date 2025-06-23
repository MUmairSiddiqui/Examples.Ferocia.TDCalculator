using Examples.Ferocia.TDCalculator.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Ferocia.TDCalculator.Domain.Interests
{
    public class YearlyCompoundInterest : Interest
    {
        public int InvestmentYears { get; private set; }
        public InterestCompound Compounded { get; private set; }

        public YearlyCompoundInterest(
            double initialDeposit,
            double interestRate,
            int investmentYears,
            InterestCompound compounded)
            : base(
                  initialDeposit,
                  interestRate)
        {
            InvestmentYears = investmentYears;
            Compounded = compounded;
        }
    }
}
