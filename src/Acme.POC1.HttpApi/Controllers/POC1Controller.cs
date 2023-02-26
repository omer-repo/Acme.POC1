using Acme.POC1.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.POC1.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class POC1Controller : AbpControllerBase
{
    protected POC1Controller()
    {
        LocalizationResource = typeof(POC1Resource);
    }
}
