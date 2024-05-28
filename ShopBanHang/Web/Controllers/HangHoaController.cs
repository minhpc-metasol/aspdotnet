using Microsoft.AspNetCore.Mvc;
using Models.HangHoa;
using Repository.Common;
using Service.HangHoaService;

namespace Web.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HangHoaController:ControllerBase
{
    private readonly ILogger<HangHoa> _logger; // ILogger takes the type of the class as a parameter
    private readonly IHangHoaService _service; // readonly means that the variable can only be assigned a value in the constructor


    public HangHoaController(ILogger<HangHoa> logger,
        IHangHoaService service)
    {
        _logger = logger;
        _service = service;
    }
    public static List<HangHoa> listHangHoas = new List<HangHoa>();

    [HttpGet]
    [Route("get-all")]
    public IActionResult GetAll()
    {
        return Ok(_service.GetAll().Result);
    }
    [HttpGet("{id}/detail")]
    public async Task<IActionResult> GetById(string id)
    {
        try
        {
            // // LinQ [object] Query
            var hanghoa = await _service.GetById(int.Parse(id));
            if(hanghoa == null)
            {
                return Ok($"Khong tim thay hang hoa ID: {id}.");
            }

            return Ok(hanghoa);
        }
        catch
        {
            return BadRequest();
        }
        
    }
    
    [HttpPost]
    public IActionResult Create(HangHoa hangHoa)
    {
        
        try
        {
            if (hangHoa == null)
            {
                return Ok(new
                {
                    Success = true, Message = "Không có data nào thêm mới"
                });
            }
            // LinQ [object] Query
            var createHangHoa = _service.CreateHangHoa(hangHoa).Result;
            return createHangHoa? Ok(new
            {
                Success = true, Message = "Thêm mới thành công", Data = hangHoa
            }):NotFound();
        }
        catch
        {
            return BadRequest();
        }
    }
    
    [HttpPut("update/{id:int}")]
    public async Task<IActionResult> Edit(int id,[FromBody]HangHoa editHangHoa)
    {
        if (id != editHangHoa.MaHh)
        {
            return BadRequest("ID in URL and request body do not match.");
        }

        // LinQ [object] Query
        var hangHoa = _service.GetById(id).Result;
        if (hangHoa == null)
        {
            return NotFound($"Hang Hoa with ID {id} not found.");
        }

        //Update
        hangHoa.MaNcc = editHangHoa.MaNcc;
        hangHoa.DonGia = editHangHoa.DonGia;
        hangHoa.TenAlias = editHangHoa.TenAlias;

        var result = await _service.EditHangHoa(hangHoa);
        return result ? Ok(hangHoa): BadRequest($"Khong tao duoc hang hoa ID: {id}.");
        
    }
    
    [HttpDelete("delete/{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        //Update
        var result = _service.DeleteHangHoa(id);
        return await result ? Ok($"Xoa thanh cong ID: {id}.") : BadRequest($"Khong xoa duoc hang hoa ID: {id}.");
    }
}