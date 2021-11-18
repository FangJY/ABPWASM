using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ABPWASM.Data;
using Volo.Abp.DependencyInjection;

namespace ABPWASM.EntityFrameworkCore
{
    public class EntityFrameworkCoreABPWASMDbSchemaMigrator
        : IABPWASMDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreABPWASMDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the ABPWASMDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<ABPWASMDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
