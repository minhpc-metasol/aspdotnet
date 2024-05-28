using Microsoft.AspNetCore.Mvc;
using Models.HangHoa;

namespace Service.HangHoaService;

public interface IHangHoaService
{
    Task<IEnumerable<HangHoa>> GetAll();
    Task<HangHoa> GetById(int id);
    Task<bool> CreateHangHoa(HangHoa hangHoa);
    
    Task<bool> EditHangHoa(HangHoa hangHoa);

    Task<bool> DeleteHangHoa(int id);
}