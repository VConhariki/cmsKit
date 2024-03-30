using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using cmsKit.Data;
using Volo.Abp.DependencyInjection;

namespace cmsKit.EntityFrameworkCore;

public class EntityFrameworkCorecmsKitDbSchemaMigrator
    : IcmsKitDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCorecmsKitDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the cmsKitDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<cmsKitDbContext>()
            .Database
            .MigrateAsync();
    }
}
