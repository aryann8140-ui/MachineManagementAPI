using MachineManagementAPI.Models;

namespace MachineManagementAPI.Repository.Interface
{
    public interface IMaintenanceRepo
    {
        public Task<IEnumerable<MaintenanceLog>> GetMaintenanceLogAsync();
        public Task CreateMaintenanceLogAsync(MaintenanceLog maintenanceLog);
    }
}