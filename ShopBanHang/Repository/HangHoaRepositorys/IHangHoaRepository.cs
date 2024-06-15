using Models.Common;
using Models.HangHoas;

namespace Repository.HangHoaRepositorys;

public interface IHangHoaRepository : IGenericRepository<HangHoa>
{
    Task<IEnumerable<HangHoa>> GetTheoMaLoai(int maLoai);
}