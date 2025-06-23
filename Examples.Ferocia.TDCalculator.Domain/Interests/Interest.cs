namespace Examples.Ferocia.TDCalculator.Domain.Interests
{
    public class Interest
    {
        public double InitialDeposit { get; private set; }
        public double InterestRatePercentage { get; private set; }
        public double InterestRate => InterestRatePercentage / 100;
        public double CurrentBalance { get; private set; }

        public Interest(
            double initialDeposit,
            double interestRate)
        {
            InitialDeposit = initialDeposit;
            InterestRatePercentage = interestRate;
            CurrentBalance = initialDeposit;
        }

        public void InterestPaid(double interest)
        {
            CurrentBalance = +interest;
        }
    }
}
