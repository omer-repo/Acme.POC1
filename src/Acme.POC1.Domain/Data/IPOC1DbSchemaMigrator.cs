using System.Threading.Tasks;

namespace Acme.POC1.Data;

public interface IPOC1DbSchemaMigrator
{
    Task MigrateAsync();
}
