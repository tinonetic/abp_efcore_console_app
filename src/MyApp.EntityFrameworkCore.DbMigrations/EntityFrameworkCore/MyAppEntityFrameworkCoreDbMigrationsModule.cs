using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace MyApp.EntityFrameworkCore
{
    [DependsOn(
        typeof(MyAppEntityFrameworkCoreModule)
        )]
    public class MyAppEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<MyAppMigrationsDbContext>();
        }
    }
}
