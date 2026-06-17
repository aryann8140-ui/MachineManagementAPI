using MachineManagementAPI.Data;
using MachineManagementAPI.Models;
using MachineManagementAPI.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace MachineManagementAPI.Repository
{
    public class MaintenanceRepo : IMaintenanceRepo
    {
        private readonly EFContext _context;
        public MaintenanceRepo(EFContext context)
        {
            _context=context;
        }

        public async Task<IEnumerable<MaintenanceLog>> GetMaintenanceLogAsync()
        {
            var maintenanceLog = await _context.MaintenanceLog.ToListAsync();
            return maintenanceLog;
        }

        public async Task<MaintenanceLog> CreateMaintenanceLogAsync(MaintenanceLog maintenanceLog)
        {
             _context.Add(maintenanceLog);
             await _context.SaveChangesAsync();
             return maintenanceLog;
        }


    }
}