using Metasol.Ecommerce.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Metasol.Ecommerce.ProductCategories;

public class ProductAttributeVarcharConfiguration : IEntityTypeConfiguration<ProductAttributeVarchar>
{
    public void Configure(EntityTypeBuilder<ProductAttributeVarchar> builder)
    {
        builder.ToTable(EcommerceConsts.DbTablePrefix + "ProductAttributeVarchars");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Value).HasMaxLength(500);
    }
}