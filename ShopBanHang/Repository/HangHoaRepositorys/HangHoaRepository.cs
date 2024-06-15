using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Models.MetaDBContext;
using Models.HangHoas;
using Models.Common;

namespace Repository.HangHoaRepositorys;

public class HangHoaRepository : GenericRepository<HangHoa>,IHangHoaRepository
{
    public HangHoaRepository(MetasolDBContext context, ILogger logger)
        : base(context, logger)
    {
        
    }

    public async Task<IEnumerable<HangHoa>> GetTheoMaLoai(int maLoai)
    {
        var listHang = await _dbContext.HangHoa.Where(x => x.MaLoai == maLoai).ToListAsync();
        return listHang;
    }
}