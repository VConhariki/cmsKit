using Volo.Abp.Settings;

namespace cmsKit.Settings;

public class cmsKitSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(cmsKitSettings.MySetting1));
    }
}
