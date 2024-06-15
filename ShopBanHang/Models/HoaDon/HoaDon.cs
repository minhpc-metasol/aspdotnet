using System.ComponentModel.DataAnnotations;
using Models.Common;
using Models.HangHoas;

namespace Models.HoaDons;

public class HoaDon:BaseEntity
{
    [Key]
    public int MaHd { get; set; }
    
    public string MaKh { get; set; } = null!;
    
    public DateTime NgayDat { get; set; }
    
    public DateTime? NgayCan { get; set; }
    
    public DateTime? NgayGiao { get; set; }
    
    public string? HoTen { get; set; }
    
    public string DiaChi { get; set; } = null!;
    
    public string CachThanhToan { get; set; } = null!;
    
    public string CachVanChuyen { get; set; } = null!;
    
    public double PhiVanChuyen { get; set; }
    
    public int MaTrangThai { get; set; }
    
    public string? MaNv { get; set; }
    
    public string? GhiChu { get; set; }
    
    public virtual ICollection<HangHoa> HangHoas { get; set; }  = new List<HangHoa>();
}