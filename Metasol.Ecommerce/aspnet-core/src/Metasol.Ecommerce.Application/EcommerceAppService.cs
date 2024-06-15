using System;
using System.Collections.Generic;
using System.Text;
using Metasol.Ecommerce.Localization;
using Volo.Abp.Application.Services;

namespace Metasol.Ecommerce;

/* Inherit your application services from this class.
 */
public abstract class EcommerceAppService : ApplicationService
{
    protected EcommerceAppService()
    {
        LocalizationResource = typeof(EcommerceResource);
    }
}
