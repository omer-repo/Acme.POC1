using Acme.POC1.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Acme.POC1.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(POC1EntityFrameworkCoreModule),
    typeof(POC1ApplicationContractsModule)
    )]
public class POC1DbMigratorModule : AbpModule
{

}
