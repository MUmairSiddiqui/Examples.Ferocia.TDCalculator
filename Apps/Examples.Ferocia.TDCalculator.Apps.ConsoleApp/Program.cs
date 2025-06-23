// See https://aka.ms/new-console-template for more information

using Examples.Ferocia.TDCalculator.Apps.ConsoleApp;
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
    .AddSingleton<Calculator>()
    .ConfigureServices()//Examples.Ferocia.TDCalculator.Services DI
    .BuildServiceProvider();

Console.WriteLine("Calculator started");

var calculator = serviceProvider.GetRequiredService<Calculator>();
calculator.Run();

Console.Write("Press any key to exit.");
Console.ReadKey();