using Examples.Ferocia.TDCalculator.Domain.Enums;
using Examples.Ferocia.TDCalculator.Domain.Interests;
using Examples.Ferocia.TDCalculator.Domain.Services;
using Examples.Ferocia.TDCalculator.Services.InterestServices;

namespace Examples.Ferocia.TDCalculator.Tests.Services
{
    public class CompoundInterestCalculatorServiceTests
    {
        private ICompoundInterestCalculatorService _compoundInterestCalculatorService;

        [SetUp]
        public void Setup()
        {
            _compoundInterestCalculatorService = new CompoundInterestCalculatorService();
        }

        //[Test]
        [TestCase(10000, 1.10, 3, InterestCompound.Monthly, ExpectedResult = 10335)]
        public int Calculate_ExpectedCompoundedAmount(
            double initialDeposit,
            double interestRate,
            int investmentYears,
            InterestCompound interestCompound)
        {
            var compoundedAmount = _compoundInterestCalculatorService.CalculateCompoundedAmount(
                new YearlyCompoundInterest(
                    initialDeposit,
                    interestRate,
                    investmentYears,
                    interestCompound));

            return (int)Math.Round(compoundedAmount);
        }
    }
}
