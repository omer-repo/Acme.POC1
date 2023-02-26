using Volo.Abp.Modularity;

namespace Acme.POC1;

[DependsOn(
    typeof(POC1ApplicationModule),
    typeof(POC1DomainTestModule)
    )]
public class POC1ApplicationTestModule : AbpModule
{

}
