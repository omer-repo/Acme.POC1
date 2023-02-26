using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Acme.POC1;

[Dependency(ReplaceServices = true)]
public class POC1BrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "POC1";
}
