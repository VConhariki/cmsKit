using Volo.Abp.Modularity;

namespace cmsKit;

public abstract class cmsKitApplicationTestBase<TStartupModule> : cmsKitTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
