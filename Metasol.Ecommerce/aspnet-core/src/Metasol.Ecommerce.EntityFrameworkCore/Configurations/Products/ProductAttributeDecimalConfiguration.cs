using Metasol.Ecommerce.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Metasol.Ecommerce.ProductCategories;

public class ProductAttributeDecimalConfiguration : IEntityTypeConfiguration<ProductAttributeDecimal>
{
    public void Configure(EntityTypeBuilder<ProductAttributeDecimal> builder)
    {
        builder.ToTable(EcommerceConsts.DbTablePrefix + "ProductAttributeDecimals");
        builder.HasKey(x => x.Id);
    }
}