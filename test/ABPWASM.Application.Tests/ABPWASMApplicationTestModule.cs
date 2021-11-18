using Volo.Abp.Modularity;

namespace ABPWASM
{
    [DependsOn(
        typeof(ABPWASMApplicationModule),
        typeof(ABPWASMDomainTestModule)
        )]
    public class ABPWASMApplicationTestModule : AbpModule
    {

    }
}