using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DevExtremeAngular.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class DevExtremeAngularDbContextFactory : IDesignTimeDbContextFactory<DevExtremeAngularDbContext>
{
    public DevExtremeAngularDbContext CreateDbContext(string[] args)
    {
        DevExtremeAngularEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<DevExtremeAngularDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new DevExtremeAngularDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../DevExtremeAngular.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
