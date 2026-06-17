using MachineManagementAPI.Dtos;
using MachineManagementAPI.Models.Enum;
using MachineManagementAPI.Services;
using MachineManagementAPI.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace MachineManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MachineController : ControllerBase
    {
        private readonly IMachineService _service;
        public MachineController(IMachineService service)
        {
            _service = service;
        }

        [HttpGet]
         public async Task<ActionResult<IEnumerable<MachineDto>>> GetAllMachineAsync()
        {
            var result = await _service.GetAllMachineAsync();
             return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MachineDto?>> GetMachineByIdAsync(int id)
        {
            var result = await _service.GetMachineByIdAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<MachineDto>> CreateMachineAsync(CreateMachineDto dto)
        {
            var result = await _service.CreateMachineAsync(dto);
            return Ok(result);  
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMachineAsync(int id , UpdateMachineDto dto)
        {
            await _service.UpdateMachineAsync(id,dto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMachineAsync(int id)
        {
            await _service.DeleteMachineAsync(id);
            return NoContent();
        }

        [HttpGet("MachineStatus/{status}")]
        public async Task<ActionResult<IEnumerable<MachineDto>>> GetMachineByStatus(MachineStatus status)
        {
            var result = await _service.GetMachineByStatus(status);
            return Ok(result);
        }
      

    } 
}