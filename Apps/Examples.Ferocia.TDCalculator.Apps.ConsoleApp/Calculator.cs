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
        }
    }
}
