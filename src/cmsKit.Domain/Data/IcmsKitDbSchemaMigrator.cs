using System.Threading.Tasks;

namespace cmsKit.Data;

public interface IcmsKitDbSchemaMigrator
{
    Task MigrateAsync();
}
