using Volo.Abp.Settings;

namespace Acme.POC1.Settings;

public class POC1SettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(POC1Settings.MySetting1));
    }
}
