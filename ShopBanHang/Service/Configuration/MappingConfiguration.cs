using AutoMapper;
using Models.HangHoas;
using Service.HangHoaService.RequestDtos;

namespace Service.Configuration;

public class MappingConfiguration : Profile
{
    public MappingConfiguration()
    {
        CreateMap<HangHoa, HangHoaRequestDto>();
    }
}