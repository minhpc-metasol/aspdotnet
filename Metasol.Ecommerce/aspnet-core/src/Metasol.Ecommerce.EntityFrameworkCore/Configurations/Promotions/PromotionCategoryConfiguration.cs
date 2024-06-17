using Metasol.Ecommerce.Promotions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Metasol.Ecommerce.Promotions;

public class PromotionCategoryConfiguration: IEntityTypeConfiguration<PromotionCategory>
{
    public void Configure(EntityTypeBuilder<PromotionCategory> builder)
    {
        builder.ToTable(EcommerceConsts.DbTablePrefix + "PromotionCategories");
        builder.HasKey(x => x.Id);
    }
}