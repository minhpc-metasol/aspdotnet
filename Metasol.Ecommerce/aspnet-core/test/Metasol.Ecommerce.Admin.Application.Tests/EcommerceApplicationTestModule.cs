using Metasol.Ecommerce.Admin;
using Volo.Abp.Modularity;

namespace Metasol.Ecommerce.Admin;

[DependsOn(
    typeof(EcommerceAdminHttpApiClientModule),
    typeof(EcommerceDomainTestModule)
)]
public class EcommerceApplicationTestModule : AbpModule
{

}
