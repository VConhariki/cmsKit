using Volo.Abp.GlobalFeatures;
using Volo.Abp.Threading;
using Volo.CmsKit.GlobalFeatures;

namespace cmsKit;

public static class cmsKitGlobalFeatureConfigurator
{
    private static readonly OneTimeRunner OneTimeRunner = new();

    public static void Configure()
    {
        GlobalFeatureManager.Instance.Modules.CmsKit(cmsKit =>
        {
            cmsKit.EnableAll();
        });
        GlobalFeatureManager.Instance.Enable<PagesFeature>();
        GlobalFeatureManager.Instance.Enable<CmsUserFeature>();
        GlobalFeatureManager.Instance.Enable<MediaFeature>();
        GlobalFeatureManager.Instance.Enable<BlogsFeature>();
        GlobalFeatureManager.Instance.Enable<CommentsFeature>();
        GlobalFeatureManager.Instance.Enable<TagsFeature>();

    }
}
