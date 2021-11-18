using Volo.Abp.Settings;

namespace ABPWASM.Settings
{
    public class ABPWASMSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(ABPWASMSettings.MySetting1));
        }
    }
}
