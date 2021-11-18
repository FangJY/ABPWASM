using System.Threading.Tasks;

namespace ABPWASM.Data
{
    public interface IABPWASMDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
