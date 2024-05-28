namespace Models.Common;

public class BaseEntity
{
    public DateTime? CreatedAt { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public string? UpdateBy { get; set; }
    public bool IsActive { get; set; }
}