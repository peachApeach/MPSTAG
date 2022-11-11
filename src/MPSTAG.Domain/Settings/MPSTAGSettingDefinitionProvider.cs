using Volo.Abp.Settings;

namespace MPSTAG.Settings;

public class MPSTAGSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(MPSTAGSettings.MySetting1));
    }
}
