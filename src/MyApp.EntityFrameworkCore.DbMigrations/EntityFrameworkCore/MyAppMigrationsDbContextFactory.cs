using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MyApp.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class MyAppMigrationsDbContextFactory : IDesignTimeDbContextFactory<MyAppMigrationsDbContext>
    {
        public MyAppMigrationsDbContext CreateDbContext(string[] args)
        {
            MyAppEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<MyAppMigrationsDbContext>()
                .UseMySql(configuration.GetConnectionString("Default"), ServerVersion.FromString("8.0.21-mysql"));

            return new MyAppMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../MyApp.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
