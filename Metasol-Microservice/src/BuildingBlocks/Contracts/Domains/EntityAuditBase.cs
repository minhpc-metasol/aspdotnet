using Contracts.Domains.Interfaces;

namespace Contracts.Domains;

public abstract class EntityAuditBase<T> : EntityBase<T>
    // , IAuditable  - after authen then using it
{
    public DateTimeOffset CreatedDate { get; set; }
    public DateTimeOffset? LastModifieDate { get; set; }
}