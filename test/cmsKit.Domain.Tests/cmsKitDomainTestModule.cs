using Volo.Abp.Modularity;

namespace cmsKit;

[DependsOn(
    typeof(cmsKitDomainModule),
    typeof(cmsKitTestBaseModule)
)]
public class cmsKitDomainTestModule : AbpModule
{

}
