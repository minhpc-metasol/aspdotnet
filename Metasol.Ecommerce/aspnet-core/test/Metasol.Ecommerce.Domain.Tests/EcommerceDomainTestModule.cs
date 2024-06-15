using Volo.Abp.Modularity;

namespace Metasol.Ecommerce;

[DependsOn(
    typeof(EcommerceDomainModule),
    typeof(EcommerceTestBaseModule)
)]
public class EcommerceDomainTestModule : AbpModule
{

}
