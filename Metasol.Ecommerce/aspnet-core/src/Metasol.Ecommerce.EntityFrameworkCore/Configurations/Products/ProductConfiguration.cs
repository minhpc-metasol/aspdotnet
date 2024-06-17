using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Metasol.Ecommerce.ProductCategories;

public class ProductConfiguration: IEntityTypeConfiguration<Products.Product>
{
    public void Configure(EntityTypeBuilder<Products.Product> builder)
    {
        builder.ToTable(EcommerceConsts.DbTablePrefix + "Products");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(x => x.Code)
            .HasMaxLength(50)
            .IsUnicode(false)
            .IsRequired();

        builder.Property(x => x.Slug)
            .HasMaxLength(50)
            .IsUnicode(false)
            .IsRequired();

        builder.Property(x => x.SKU)
            .HasMaxLength(50)
            .IsUnicode(false)
            .IsRequired();


        builder.Property(x => x.ThumbnailPicture)
            .HasMaxLength(250);

        builder.Property(x => x.SeoMetaDescription)
            .HasMaxLength(250);

        builder.Property(x => x.CategoryName)
            .HasMaxLength(250);

        builder.Property(x => x.CategorySlug)
            .HasMaxLength(250);
    }
}