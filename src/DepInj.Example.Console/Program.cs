using Microsoft.Extensions.DependencyInjection;
using DepInj.Example.Core;

var services = new ServiceCollection();
services.AddTransient<ITextTransformer, StringCapitalise>();

var serviceProvider = services.BuildServiceProvider();

var transformer = serviceProvider.GetRequiredService<ITextTransformer>();

Console.WriteLine("Enter a string to capitalise:");
var input = Console.ReadLine();

var result = transformer.transform(input);
Console.WriteLine($"Result: {result}");
