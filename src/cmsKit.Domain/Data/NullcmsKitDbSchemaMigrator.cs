using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace cmsKit.Data;

/* This is used if database provider does't define
 * IcmsKitDbSchemaMigrator implementation.
 */
public class NullcmsKitDbSchemaMigrator : IcmsKitDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
