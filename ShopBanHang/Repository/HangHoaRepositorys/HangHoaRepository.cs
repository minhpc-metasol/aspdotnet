using Microsoft.Extensions.Logging;
using Models.MetaDBContext;
using Models.HangHoa;
using Models.Common;

namespace Repository.HangHoaRepositorys;

public class HangHoaRepository : GenericRepository<HangHoa>,IHangHoaRepository
{
    public HangHoaRepository(MetasolDBContext context, ILogger logger)
        : base(context, logger)
    {
        
    }

}