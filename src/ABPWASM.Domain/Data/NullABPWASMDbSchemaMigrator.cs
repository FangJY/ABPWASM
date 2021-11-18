using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ABPWASM.Data
{
    /* This is used if database provider does't define
     * IABPWASMDbSchemaMigrator implementation.
     */
    public class NullABPWASMDbSchemaMigrator : IABPWASMDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}