using Microsoft.Azure.Functions.Extensions.DependencyInjection;

[assembly:FunctionsStartup(typeof(Company.Application.Component.Service.Startup))]
namespace Company.Application.Component.Service
{

    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            // TODO Register Dependencies
            throw new System.NotImplementedException();
        }
    }
}
