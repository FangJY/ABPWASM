﻿using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ABPWASM.Blazor
{
    [Dependency(ReplaceServices = true)]
    public class ABPWASMBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "ABPWASM";
    }
}
