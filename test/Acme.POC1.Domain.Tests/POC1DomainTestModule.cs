using Acme.POC1.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Acme.POC1;

[DependsOn(
    typeof(POC1EntityFrameworkCoreTestModule)
    )]
public class POC1DomainTestModule : AbpModule
{

}
