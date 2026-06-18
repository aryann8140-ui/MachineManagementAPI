using MachineManagementAPI.Models.Enum;
using Machine = MachineManagementAPI.Models.Machine;

namespace MachineManagementAPI.Repository.Interface
{
    public interface IMachineRepo
    {
        public Task<IEnumerable<Machine>> GetAllMachineAsync();
        public Task<Machine?> GetMachineByIdAsync(int id);
        public Task CreateMachineAsync(Machine machine);
        public Task<Machine> UpdateMachineAsync(Machine machine);
        public Task DeleteMachineAsync(int id);
        public Task<IEnumerable<Machine>> GetMachineByStatus(MachineStatus status);

    }
}