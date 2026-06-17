using MachineManagementAPI.Models;

namespace MachineManagementAPI.Repository.Interface
{
    public interface IMaintenanceRepo
    {
        public Task<IEnumerable<MaintenanceLog>> GetMaintenanceLogAsync();
        public Task<MaintenanceLog> CreateMaintenanceLogAsync(MaintenanceLog maintenanceLog);
    }
}