using System;
using System.Collections.Generic;
using System.Text;
using ABPWASM.Localization;
using Volo.Abp.Application.Services;

namespace ABPWASM
{
    /* Inherit your application services from this class.
     */
    public abstract class ABPWASMAppService : ApplicationService
    {
        protected ABPWASMAppService()
        {
            LocalizationResource = typeof(ABPWASMResource);
        }
    }
}
