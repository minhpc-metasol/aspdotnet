using System.ComponentModel.DataAnnotations;
using Models.Common;
using Models.HangHoas;

namespace Models.NhaCungCaps;

public class NhaCungCap : BaseEntity
{
    [Key]
    public string MaNcc { get; set; } = null!;

    public string TenCongTy { get; set; } = null!;

    public string Logo { get; set; } = null!;

    public string? NguoiLienLac { get; set; }

    public string Email { get; set; } = null!;

    public string? DienThoai { get; set; }

    public string? DiaChi { get; set; }

    public string? MoTa { get; set; }

    public virtual ICollection<HangHoa> HangHoas { get; set; } = new List<HangHoa>();
}