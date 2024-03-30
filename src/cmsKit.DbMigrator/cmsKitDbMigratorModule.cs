using cmsKit.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace cmsKit.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(cmsKitEntityFrameworkCoreModule),
    typeof(cmsKitApplicationContractsModule)
    )]
public class cmsKitDbMigratorModule : AbpModule
{
}
