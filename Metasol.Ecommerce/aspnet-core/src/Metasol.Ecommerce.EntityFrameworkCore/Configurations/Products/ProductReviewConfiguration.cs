using Metasol.Ecommerce.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Metasol.Ecommerce.ProductCategories;

public class ProductReviewConfiguration : IEntityTypeConfiguration<ProductReview>
{
    public void Configure(EntityTypeBuilder<ProductReview> builder)
    {
        builder.ToTable(EcommerceConsts.DbTablePrefix + "ProductReviews");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Title)
            .HasMaxLength(250)
            .IsRequired();

    }
}