using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Models.Common;
using Models.HangHoas;
using Models.HoaDons;

namespace Models.ChiTietHoaDons;

public class ChiTietHD:BaseEntity
{
    [Key]
    public int MaCt { get; set; }
    
    public int MaHd { get; set; }

    public int MaHh { get; set; }

    public double DonGia { get; set; }

    public int SoLuong { get; set; }

    public double GiamGia { get; set; }
    [ForeignKey("MaHd")]
    public virtual HoaDon HoaDons { get; set; } = null!;
    
    [ForeignKey("MaHh")]
    public virtual HangHoa HangHoas  { get; set; } = null!;
}