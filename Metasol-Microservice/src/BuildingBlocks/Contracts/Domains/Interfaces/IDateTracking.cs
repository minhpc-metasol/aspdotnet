namespace Contracts.Domains.Interfaces;

public interface IDateTracking
{
    DateTimeOffset CreatedDate { get; set; }
    DateTimeOffset? LastModifieDate { get; set; }
}