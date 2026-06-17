using MachineManagementAPI.Dtos;
using MachineManagementAPI.Services;
using MachineManagementAPI.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace MachineManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MaintenanceController : ControllerBase
    {
        private readonly IMaintenanceService  _service;
        public MaintenanceController(IMaintenanceService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task <ActionResult<IEnumerable<MaintenanceDto>>> GetMaintenanceLogAsync()
        {
            var result = await _service.GetMaintenanceLogAsync();
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<MaintenanceDto>> CreateMaintenanceLogAsync(CreateMaintenanceDto dto)
        {
            var result = await _service.CreateMaintenanceLogAsync(dto);
            return CreatedAtAction(nameof(GetMaintenanceLogAsync), null, result);
        }


    }
}