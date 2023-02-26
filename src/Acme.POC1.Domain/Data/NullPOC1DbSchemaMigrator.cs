using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.POC1.Data;

/* This is used if database provider does't define
 * IPOC1DbSchemaMigrator implementation.
 */
public class NullPOC1DbSchemaMigrator : IPOC1DbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
