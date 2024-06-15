using Volo.Abp.Modularity;

namespace Metasol.Ecommerce;

public abstract class EcommerceApplicationTestBase<TStartupModule> : EcommerceTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
