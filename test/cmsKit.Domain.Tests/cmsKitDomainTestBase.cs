using Volo.Abp.Modularity;

namespace cmsKit;

/* Inherit from this class for your domain layer tests. */
public abstract class cmsKitDomainTestBase<TStartupModule> : cmsKitTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
