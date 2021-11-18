using ABPWASM.Localization;
using Volo.Abp.AspNetCore.Components;

namespace ABPWASM.Blazor
{
    public abstract class ABPWASMComponentBase : AbpComponentBase
    {
        protected ABPWASMComponentBase()
        {
            LocalizationResource = typeof(ABPWASMResource);
        }
    }
}
