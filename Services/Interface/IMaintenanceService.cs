using MachineManagementAPI.Dtos;

namespace MachineManagementAPI.Services.Interface
{
    public interface IMaintenanceService
    {
        public Task <IEnumerable<MaintenanceDto>> GetMaintenanceLogAsync();
        public Task<MaintenanceDto> CreateMaintenanceLogAsync(CreateMaintenanceDto dto);
        
    }
}