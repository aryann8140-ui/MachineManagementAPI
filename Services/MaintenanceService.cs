using MachineManagementAPI.Dtos;
using MachineManagementAPI.Models;
using MachineManagementAPI.Repository;
using MachineManagementAPI.Repository.Interface;
using MachineManagementAPI.Services.Interface;

namespace MachineManagementAPI.Services
{
    public class MaintenanceService : IMaintenanceService
    {
        private readonly IMaintenanceRepo _repo;
        public MaintenanceService(IMaintenanceRepo repo)
        {
            _repo = repo;
        }

       public async Task<IEnumerable<MaintenanceDto>> GetMaintenanceLogAsync()
        {
            var maintenance = await _repo.GetMaintenanceLogAsync();
            return maintenance.Select(m=> new MaintenanceDto{
            MachineId = m.MachineId ,
            Description = m.Description ,
            PerformedBy = m.PerformedBy,
            MaintenanceDate = m.MaintenanceDate,
            Cost = m.Cost
        });

        }

        public async Task<MaintenanceDto> CreateMaintenanceLogAsync(CreateMaintenanceDto dto)
        {
            var maintenance = new MaintenanceLog
            {
                MachineId = dto.MachineId,
                Description = dto.Description,
                PerformedBy = dto.PerformedBy,
                Cost = dto.Cost
            };

            var create = await _repo.CreateMaintenanceLogAsync(maintenance);
            
            return new MaintenanceDto
            {
                MachineId = create.MachineId,
                Description = create.Description,
                PerformedBy = create.PerformedBy,
                Cost = create.Cost
            };       


        
    }
}
}