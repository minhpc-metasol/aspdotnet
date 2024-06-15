using System.ComponentModel.DataAnnotations;
using Models.Common;
using Models.HangHoas;

namespace Models.Loais;

public class Loai : BaseEntity
{
    [Key]
    public int MaLoai { get; set; }

    public string TenLoai { get; set; } = null!;

    public string? TenLoaiAlias { get; set; }

    public string? MoTa { get; set; }

    public string? Hinh { get; set; }

    public virtual ICollection<HangHoa> HangHoas { get; set; } = new List<HangHoa>();
}