using MyApp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace MyApp.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(MyAppEntityFrameworkCoreDbMigrationsModule),
        typeof(MyAppApplicationContractsModule)
        )]
    public class MyAppDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
