using MachineManagementAPI.Data;
using MachineManagementAPI.Models;
using MachineManagementAPI.Models.Enum;
using MachineManagementAPI.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace MachineManagementAPI.Repository
{
    public class MachineRepo : IMachineRepo
    {
        private readonly EFContext _context;
        public MachineRepo(EFContext context)
        {
            _context = context ;
        }

        public async Task<IEnumerable<Machine>?> GetAllMachineAsync()
        {
            var machines = await _context.Machine.ToListAsync();
            return machines;

        }

        public async Task<Machine?> GetMachineByIdAsync(int id)
        {
            var machine = await _context.Machine.SingleOrDefaultAsync(m => m.Id == id);
            return machine ;
        }

        public async Task CreateMachineAsync(Machine machine)
        {
            _context.Add(machine);
            await _context.SaveChangesAsync();
        }
     
         public async Task UpdateMachineAsync(Machine machine)
        {
            _context.Update(machine);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteMachineAsync(int id)
        {
            var machine = await _context.Machine.SingleOrDefaultAsync(m => m.Id == id);
            if(machine!=null){
                _context.Machine.Remove(machine);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Machine>> GetMachineByStatus(MachineStatus status)
        {
            var machines = await _context.Machine.Where(m => m.Status == status).ToListAsync();
            return machines;

        }
       
    }
}