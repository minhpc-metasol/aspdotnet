using Volo.Abp.Modularity;

namespace Metasol.Ecommerce.Admin;

public abstract class EcommerceApplicationTestBase<TStartupModule> : EcommerceTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
