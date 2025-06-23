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

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}
