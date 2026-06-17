namespace MachineManagementAPI.Services.Interface
{
    public interface IOperatorService
    {
        public Task AssignOperatorAsync(int operatorId, int machineId);
       
    }
}