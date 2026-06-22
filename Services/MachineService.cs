using MachineManagementAPI.Dtos;
using MachineManagementAPI.Models;
using MachineManagementAPI.Models.Enum;
using MachineManagementAPI.Repository;
using MachineManagementAPI.Repository.Interface;
using MachineManagementAPI.Services.Interface;

namespace MachineManagementAPI.Services
{
    public class MachineService : IMachineService
    {
        private readonly IMachineRepo _repo;

        public MachineService(IMachineRepo repo)
        {
            _repo = repo;
        }

         public async Task<IEnumerable<MachineDto>?> GetAllMachineAsync()
        {
            var machines = await _repo.GetAllMachineAsync();
            if (machines == null)
            {
                throw new ArgumentNullException("No machine found");
            }
            return machines.Select(m=> new MachineDto
            {
                Name = m.Name,
                SerialNumber = m.SerialNumber,
                Location = m.Location,
                Status = m.Status,
                PurchaseDate = m.PurchaseDate
            });
              
        }

         public async Task<MachineDto?> GetMachineByIdAsync(int id)
        {
            if (id < 0)
            {
                throw new ArgumentException("Id can't be less than 0"); 
            }

            var machine = await _repo.GetMachineByIdAsync(id);
            if (machine == null)
            {
                throw new ArgumentNullException("No machine found");
            }
            return new MachineDto
            {
                Name = machine.Name,
                SerialNumber = machine.SerialNumber,
                Location = machine.Location,
                Status = machine.Status,
                PurchaseDate = machine.PurchaseDate
            };

        }

        public async Task CreateMachineAsync(CreateMachineDto dto)
        {
            var machine = new Machine
            {
                Name = dto.Name,
                SerialNumber = dto.SerialNumber,
                Location = dto.Location,
                Status = dto.Status,
            };
            
             if( string.IsNullOrWhiteSpace( machine.SerialNumber)|| string.IsNullOrWhiteSpace(machine.Location))
            {
                throw new ArgumentException("Enter Complete Machine Details");
            }

             await _repo.CreateMachineAsync(machine);
           
        }


        public async Task UpdateMachineAsync(int id , UpdateMachineDto dto)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Enter valid Id");
            }
            var machine = await _repo.GetMachineByIdAsync(id);
            if (machine == null)
            {
                throw new KeyNotFoundException("Machine is not present");
            }
                
            machine.Name = dto.Name;
            machine.SerialNumber=dto.SerialNumber;
            machine.Location=dto.Location;
            machine.Status=dto.Status;

            await _repo.UpdateMachineAsync(machine);

        }
          

        public async Task DeleteMachineAsync(int id)
        {
            var machine = await _repo.GetMachineByIdAsync(id);
            if (machine == null)
            {
                throw new KeyNotFoundException("No Machine found");
            }
            await _repo.DeleteMachineAsync(id);
        }

        public async Task<IEnumerable<MachineDto>> GetMachineByStatus(MachineStatus status)
        {
            var machines = await _repo.GetMachineByStatus(status);
            if (machines == null)
            {
                throw new KeyNotFoundException("No machine found");
            }
            return machines.Select(machine => new MachineDto
            {
                Name = machine.Name,
                SerialNumber = machine.SerialNumber,
                Location = machine.Location,
                Status = machine.Status,
                PurchaseDate = machine.PurchaseDate
            });
        }




    }

}