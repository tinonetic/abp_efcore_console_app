using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyApp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace MyApp.Console
{

    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(MyAppDomainModule),
        typeof(MyAppEntityFrameworkCoreModule)
    )]
    public class ConsoleModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var configuration = context.Services.GetConfiguration();
            var hostEnvironment = context.Services.GetSingletonInstance<IHostEnvironment>();

            context.Services.AddHostedService<ConsoleHostedService>();
        }
    }
}
