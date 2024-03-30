using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace cmsKit.Web;

[Dependency(ReplaceServices = true)]
public class cmsKitBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "cmsKit";
}
