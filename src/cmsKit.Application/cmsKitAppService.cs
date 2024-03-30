using System;
using System.Collections.Generic;
using System.Text;
using cmsKit.Localization;
using Volo.Abp.Application.Services;

namespace cmsKit;

/* Inherit your application services from this class.
 */
public abstract class cmsKitAppService : ApplicationService
{
    protected cmsKitAppService()
    {
        LocalizationResource = typeof(cmsKitResource);
    }
}
