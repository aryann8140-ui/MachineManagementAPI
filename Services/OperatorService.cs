using MachineManagementAPI.Repository;
using MachineManagementAPI.Repository.Interface;
using MachineManagementAPI.Services.Interface;

namespace MachineManagementAPI.Services
{
    public class Operatorservice : IOperatorService
    {
        private readonly IOperatorRepo _repo;
        private readonly IMachineRepo _machineRepo;
        public Operatorservice(IOperatorRepo repo , IMachineRepo machineRepo)
        {
            _repo = repo;
            _machineRepo = machineRepo;
        }

        public async Task AssignOperatorAsync(int operatorId, int machineId)
        {
            var machine = await _machineRepo.GetMachineByIdAsync(machineId);

            if (machine == null)
                throw new Exception("Machine not found.");

            await _repo.AssignOperatorAsync(operatorId, machineId);
        }

    }
}