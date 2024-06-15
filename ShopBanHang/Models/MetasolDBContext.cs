using Microsoft.EntityFrameworkCore;
using Models.ChiTietHoaDons;
using Models.HangHoas;
using Models.HoaDons;
using Models.Loais;
using Models.NhaCungCaps;

namespace Models.MetaDBContext;

public class MetasolDBContext :DbContext
{
    public MetasolDBContext(DbContextOptions options) : base(options)
    {
        
    }

    #region DbSet
    public DbSet<HangHoa> HangHoa { get; set; }
    public DbSet<HoaDon> HoaDon { get; set; }
    public DbSet<NhaCungCap> NhaCungCap { get; set; }
    public DbSet<Loai> Loai { get; set; }
    public DbSet<ChiTietHD> ChiTietHoaDon { get; set; }
    
    #endregion
}