using Acme.POC1.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Acme.POC1.Blazor;

public abstract class POC1ComponentBase : AbpComponentBase
{
    protected POC1ComponentBase()
    {
        LocalizationResource = typeof(POC1Resource);
    }
}
