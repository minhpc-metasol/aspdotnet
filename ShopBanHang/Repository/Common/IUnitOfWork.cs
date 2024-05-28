using Repository.HangHoaRepositorys;

namespace Repository.Common;

public interface IUnitOfWork
{
    IHangHoaRepository HangHoas{ get; }
    Task CompleteAsync();
}