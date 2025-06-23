using Examples.Ferocia.TDCalculator.Domain.Services;
using Examples.Ferocia.TDCalculator.Services.InterestServices;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Ferocia.TDCalculator.Services
{
    public static class ServicesConfiguration
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            services.AddSingleton<ICompoundInterestCalculatorService, CompoundInterestCalculatorService>();
            return services;
        }
    }
}
