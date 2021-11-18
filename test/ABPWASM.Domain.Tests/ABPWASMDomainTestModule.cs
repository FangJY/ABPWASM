using ABPWASM.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ABPWASM
{
    [DependsOn(
        typeof(ABPWASMEntityFrameworkCoreTestModule)
        )]
    public class ABPWASMDomainTestModule : AbpModule
    {

    }
}