using System;
using System.Collections.Generic;
using System.Text;
using Metasol.Ecommerce.Localization;
using Volo.Abp.Application.Services;

namespace Metasol.Ecommerce.Admin;

/* Inherit your application services from this class.
 */
public abstract class EcommerceAdminAppService : ApplicationService
{
    protected EcommerceAdminAppService()
    {
        LocalizationResource = typeof(EcommerceResource);
    }
}
