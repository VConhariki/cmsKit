using cmsKit.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace cmsKit.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class cmsKitPageModel : AbpPageModel
{
    protected cmsKitPageModel()
    {
        LocalizationResourceType = typeof(cmsKitResource);
    }
}
