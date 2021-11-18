using ABPWASM.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace ABPWASM.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(ABPWASMEntityFrameworkCoreModule),
        typeof(ABPWASMApplicationContractsModule)
        )]
    public class ABPWASMDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
