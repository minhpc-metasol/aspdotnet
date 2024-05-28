using Microsoft.EntityFrameworkCore;

namespace Models.MetaDBContext;

public class MetasolDBContext :DbContext
{
    public MetasolDBContext(DbContextOptions options) : base(options)
    {
        
    }

    #region DbSet
    public DbSet<HangHoa.HangHoa> HangHoa { get; set; }
    
    #endregion
}