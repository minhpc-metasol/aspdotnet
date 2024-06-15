using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Metasol.Ecommerce;

[Dependency(ReplaceServices = true)]
public class EcommerceBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Ecommerce";
}
