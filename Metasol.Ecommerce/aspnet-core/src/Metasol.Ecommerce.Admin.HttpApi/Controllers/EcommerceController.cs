using Metasol.Ecommerce.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Metasol.Ecommerce.Admin.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class EcommerceController : AbpControllerBase
{
    protected EcommerceController()
    {
        LocalizationResource = typeof(EcommerceResource);
    }
}
