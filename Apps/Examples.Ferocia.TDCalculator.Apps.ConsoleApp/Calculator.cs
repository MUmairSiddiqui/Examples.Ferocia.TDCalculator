using Examples.Ferocia.TDCalculator.Domain.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Ferocia.TDCalculator.Apps.ConsoleApp
{
    internal class Calculator(
        IConfiguration configuration,
        ILogger<Calculator> logger,
        ICompoundInterestCalculatorService calculatorService)
    {
        private readonly IConfiguration _configuration = configuration;
        private readonly ILogger<Calculator> _logger = logger;
        private readonly ICompoundInterestCalculatorService _calculatorService = calculatorService;

        /// <summary>
        /// Main calculator method that will be executed from Program
        /// </summary>
        public void Run()
        {
            Console.WriteLine("Enter the starting deposit amout (e.g.$10,000) and press [enter]. Please enter only numbers without the $ sign.");
            var isValid = double.TryParse(Console.ReadLine(), out double initialAmount);

            while (!isValid)
            {
                Console.WriteLine("Invalid initial deposit. Please enter the starting deposit amout (e.g.$10,000) and press [enter]. Please enter only numbers without the $ sign.");
                isValid = double.TryParse(Console.ReadLine(), out initialAmount);
            }

            Console.WriteLine("Enter the interest rate (e.g. 1.10) and press [enter]. Please enter without the % sign.");
            isValid = double.TryParse(Console.ReadLine(), out double interestRate);

            while (!isValid)
            {
                Console.WriteLine("Invalid interest rate. Please enter the interest rate (e.g. 1.10) and press [enter]. Please enter without the % sign.");
                isValid = double.TryParse(Console.ReadLine(), out interestRate);
            }

            Console.WriteLine("Enter the investment term (e.g. 3 years) and press [enter]. Please enter only the number of years as a number.");
            isValid = int.TryParse(Console.ReadLine(), out int investmentTerm);

            while (!isValid)
            {
                Console.WriteLine("Invalid investment term. Please enter the investment term (e.g. 3 years) and press [enter]. Please enter only the number of years as a number.");
                isValid = int.TryParse(Console.ReadLine(), out investmentTerm);
            }
            
        }
    }
}
