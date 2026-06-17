using MachineManagementAPI.Models;

namespace MachineManagementAPI.Repository.Interface
{
    public interface IOperatorRepo
    {
      public Task AssignOperatorAsync(int operatorId, int machineId);

}
}