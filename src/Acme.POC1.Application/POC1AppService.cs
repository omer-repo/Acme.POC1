using System;
using System.Collections.Generic;
using System.Text;
using Acme.POC1.Localization;
using Volo.Abp.Application.Services;

namespace Acme.POC1;

/* Inherit your application services from this class.
 */
public abstract class POC1AppService : ApplicationService
{
    protected POC1AppService()
    {
        LocalizationResource = typeof(POC1Resource);
    }
}
