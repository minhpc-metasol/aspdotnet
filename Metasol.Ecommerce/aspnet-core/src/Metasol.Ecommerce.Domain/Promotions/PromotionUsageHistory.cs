using System;
using Volo.Abp.Domain.Entities;

namespace Metasol.Ecommerce.Promotions;

public class PromotionUsageHistory : Entity<Guid>
{
    public Guid PromotionId { get; set; }
    public Guid OrderId { get; set; }
}