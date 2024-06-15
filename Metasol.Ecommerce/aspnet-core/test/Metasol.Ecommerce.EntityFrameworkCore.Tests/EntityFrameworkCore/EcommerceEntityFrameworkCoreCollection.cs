using Xunit;

namespace Metasol.Ecommerce.EntityFrameworkCore;

[CollectionDefinition(EcommerceTestConsts.CollectionDefinitionName)]
public class EcommerceEntityFrameworkCoreCollection : ICollectionFixture<EcommerceEntityFrameworkCoreFixture>
{

}
