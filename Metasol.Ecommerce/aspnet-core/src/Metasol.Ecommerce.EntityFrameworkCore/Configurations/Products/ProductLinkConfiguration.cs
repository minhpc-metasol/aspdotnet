using Metasol.Ecommerce.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Metasol.Ecommerce.ProductCategories;

public class ProductLinkConfiguration: IEntityTypeConfiguration<ProductLink>
{
    public void Configure(EntityTypeBuilder<ProductLink> builder)
    {
        builder.ToTable(EcommerceConsts.DbTablePrefix + "ProductLinks");
        builder.HasKey(x => new { x.ProductId, x.LinkedProductId });
    }
}