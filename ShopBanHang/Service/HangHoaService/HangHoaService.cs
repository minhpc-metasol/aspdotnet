using Microsoft.Extensions.Logging;
using Models.HangHoa;
using Repository.Common;

namespace Service.HangHoaService;

public class HangHoaService : IHangHoaService
{
    private readonly ILogger<HangHoa> _logger; // ILogger takes the type of the class as a parameter
    private readonly IUnitOfWork _unitOfWork; // readonly means that the variable can only be assigned a value in the constructor

    public HangHoaService(ILogger<HangHoa> logger,
        IUnitOfWork unitOfWork)
    {
        _logger = logger;
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<HangHoa>> GetAll()
    {
        var data = await _unitOfWork.HangHoas.GetAll();
        return data;
    }

    public async Task<HangHoa> GetById(int id)
    {
        var data = await _unitOfWork.HangHoas.GetById(id);
        return data;
    }

    public async Task<bool> CreateHangHoa(HangHoa hangHoa)
    {
        var isExist = await _unitOfWork.HangHoas.GetById(hangHoa.MaHh);
        if (isExist != null) return false;
        await _unitOfWork.HangHoas.Create(hangHoa);
        await _unitOfWork.CompleteAsync();
        return await Task.FromResult(true);
    }
    
    public async Task<bool> EditHangHoa(HangHoa hangHoa)
    {
        _unitOfWork.HangHoas.Update(hangHoa);
        await _unitOfWork.CompleteAsync();
        return await Task.FromResult(true);
    }

    public async Task<bool> DeleteHangHoa(int id)
    {
        await _unitOfWork.HangHoas.Delete(id);
        await _unitOfWork.CompleteAsync();
        return await Task.FromResult(true);
    }
}