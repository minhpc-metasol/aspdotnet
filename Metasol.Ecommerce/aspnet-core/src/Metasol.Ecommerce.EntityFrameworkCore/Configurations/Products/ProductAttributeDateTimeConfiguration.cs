using Metasol.Ecommerce.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Metasol.Ecommerce.ProductCategories;

public class ProductAttributeDateTimeConfiguration: IEntityTypeConfiguration<ProductAttributeDateTime>
{
    public void Configure(EntityTypeBuilder<ProductAttributeDateTime> builder)
    {
        builder.ToTable(EcommerceConsts.DbTablePrefix + "ProductAttributeDateTimes");
        builder.HasKey(x => x.Id);


           
    }
}