using Volo.Abp.Modularity;

namespace cmsKit;

[DependsOn(
    typeof(cmsKitApplicationModule),
    typeof(cmsKitDomainTestModule)
)]
public class cmsKitApplicationTestModule : AbpModule
{

}
