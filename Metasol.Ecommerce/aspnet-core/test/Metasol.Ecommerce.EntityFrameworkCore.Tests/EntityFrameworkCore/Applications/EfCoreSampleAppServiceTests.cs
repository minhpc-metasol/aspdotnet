using Metasol.Ecommerce.Samples;
using Xunit;

namespace Metasol.Ecommerce.EntityFrameworkCore.Applications;

[Collection(EcommerceTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<EcommerceEntityFrameworkCoreTestModule>
{

}
