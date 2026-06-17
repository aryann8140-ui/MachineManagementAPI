using MachineManagementAPI.Data;
using MachineManagementAPI.Models;
using MachineManagementAPI.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace MachineManagementAPI.Repository
{
    public class OperatorRepo : IOperatorRepo
    {

        private readonly EFContext _context;
        public OperatorRepo(EFContext context)
        {
            _context = context;
        }
       public async Task AssignOperatorAsync(int operatorId, int machineId)
        {
            
            var operatorEntity = await _context.Operator
                .FirstOrDefaultAsync(o => o.Id == operatorId);
            if(operatorEntity!=null){
            operatorEntity.AssignedMachineId = machineId;}

            await _context.SaveChangesAsync();

        }

    }
}