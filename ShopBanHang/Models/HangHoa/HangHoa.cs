using System.ComponentModel.DataAnnotations;
using Models.ChiTietHoaDons;
using Models.Common;
using Models.Loais;
using Models.NhaCungCaps;

namespace Models.HangHoas
{
    public class HangHoa : BaseEntity
    {
        [Key] public int MaHh { get; set; }

        public string TenHh { get; set; } = null!;

        public string? TenAlias { get; set; }

        public int MaLoai { get; set; }

        public string? MoTaDonVi { get; set; }

        public double? DonGia { get; set; }

        public string? Hinh { get; set; }

        public DateTime NgaySx { get; set; }

        public double GiamGia { get; set; }

        public int SoLanXem { get; set; }

        public string? MoTa { get; set; }
        public string MaNcc { get; set; } = null!;

        public virtual Loai Loais { get; set; } = null!;

        public virtual NhaCungCap NhaCungCaps { get; set; } = null!;

        public virtual ICollection<ChiTietHD> ChiTietHoaDons { get; set; } = new List<ChiTietHD>();
    }
}