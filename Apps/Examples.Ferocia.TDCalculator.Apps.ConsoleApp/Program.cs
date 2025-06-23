// See https://aka.ms/new-console-template for more information

using Examples.Ferocia.TDCalculator.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

var configuration = new ConfigurationBuilder()
    .SetBasePath(AppContext.BaseDirectory)
    .AddCommandLine(args)
    .Build();

var serviceProvider = new ServiceCollection()
    .AddSingleton<IConfiguration>(configuration)
    .AddLogging(builder => builder.AddConsole())
    .ConfigureServices()//Examples.Ferocia.TDCalculator.Services DI
    .BuildServiceProvider();

Console.WriteLine("Calculator started");
Console.Write("Press any key to exit.");
Console.ReadKey();