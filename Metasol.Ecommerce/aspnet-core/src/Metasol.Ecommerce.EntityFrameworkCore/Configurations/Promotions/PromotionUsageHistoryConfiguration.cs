using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Metasol.Ecommerce.Promotions;

public class PromotionUsageHistoryConfiguration : IEntityTypeConfiguration<PromotionUsageHistory>
{
    public void Configure(EntityTypeBuilder<PromotionUsageHistory> builder)
    {
        builder.ToTable(EcommerceConsts.DbTablePrefix + "PromotionUsageHistories");
        builder.HasKey(x => x.Id);
    }
}