using AS2;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;

namespace AS2
{
    class Program
    { 
        public static void Main(string[] args)
        {
            //Manually build DI Container

            //1.builder The DI Container
            var serviceCollection = new ServiceCollection();

            // 2. Register the Service

            //let the container to know wha tvalue to use for the dependent string to be injected into the service
            serviceCollection.AddTransient<CalculatorController>(_ => new CalculatorController(new SimpleCalculator(), "-"));
            //serviceCollection.AddTransient<ICalculator, SimpleCalculator>(); // seems useless in this case..

            // build the dependency service provider
            var serviceProvider = serviceCollection.BuildServiceProvider();

            // 3. get the required service
            var runner = serviceProvider.GetRequiredService<CalculatorController>();

            Console.WriteLine(runner.Calculate(8, 9));
            Console.ReadLine();



            //Or do it another way

            //var calculatorController = new CalculatorController(new SimpleCalculator(), "+");
            //Console.WriteLine(calculatorController.Calculate(8, 7, "+"));
            //Console.ReadLine();
        }
    }

}