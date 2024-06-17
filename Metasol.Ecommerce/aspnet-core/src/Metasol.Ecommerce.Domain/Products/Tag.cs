using Volo.Abp.Domain.Entities;

namespace Metasol.Ecommerce.Products;

public class Tag : Entity<string>
{
    public string Name { get; set; }
}