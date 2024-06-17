using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Metasol.Ecommerce.Orders;

public class OrderItemConfiguration: IEntityTypeConfiguration<OrderItem>
{
    public void Configure(EntityTypeBuilder<OrderItem> builder)
    {
        builder.ToTable(EcommerceConsts.DbTablePrefix + "OrderItems");
        builder.HasKey(x => new { x.ProductId, x.OrderId });
        builder.Property(x => x.SKU)
            .HasMaxLength(50)
            .IsUnicode(false)
            .IsRequired();
    }
}