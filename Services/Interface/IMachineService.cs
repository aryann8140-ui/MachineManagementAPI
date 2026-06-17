using MachineManagementAPI.Dtos;
using MachineManagementAPI.Models.Enum;

namespace MachineManagementAPI.Services.Interface
{
    public interface IMachineService
    {
        public Task<IEnumerable<MachineDto>> GetAllMachineAsync();
        public Task<MachineDto?> GetMachineByIdAsync(int id);
        public Task<MachineDto> CreateMachineAsync(CreateMachineDto dto);
        public Task<MachineDto> UpdateMachineAsync(int id , UpdateMachineDto dto);
        public Task DeleteMachineAsync(int id);
        public Task<IEnumerable<MachineDto>> GetMachineByStatus(MachineStatus status);
        
    }    
}
