using ABPWASM.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ABPWASM.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class ABPWASMController : AbpController
    {
        protected ABPWASMController()
        {
            LocalizationResource = typeof(ABPWASMResource);
        }
    }
}