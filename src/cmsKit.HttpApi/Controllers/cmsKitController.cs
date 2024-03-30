using cmsKit.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace cmsKit.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class cmsKitController : AbpControllerBase
{
    protected cmsKitController()
    {
        LocalizationResource = typeof(cmsKitResource);
    }
}
