
using FunctionApp1;

using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(Startup))]
namespace FunctionApp1
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            AddDependencies(builder);
        }

        private void AddDependencies(IFunctionsHostBuilder builder)
        {
            builder.Services.AddScoped<ITestService>(x =>
            {
                return new TestService();
            });
        }
    }
}