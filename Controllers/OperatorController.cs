using MachineManagementAPI.Services;
using MachineManagementAPI.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace MachineManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OperatorController : ControllerBase
    {
        private readonly IOperatorService  _service;
        public OperatorController(IOperatorService service)
        {
            _service = service;
        }

        [HttpPut]
       public async Task<IActionResult> AssignOperatorAsync(int operatorId, int machineId)
        {
            await _service.AssignOperatorAsync(operatorId,machineId);
            return NoContent();
        }


    }
}    