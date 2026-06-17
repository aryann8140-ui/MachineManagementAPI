using System.ComponentModel.DataAnnotations;
using MachineManagementAPI.Models.Enum;

namespace MachineManagementAPI.Dtos
{
       public class CreateMachineDto
    {
        [Required]
        public string? Name{get; set;}
        public string? SerialNumber{get; set;}
        public string? Location{get; set;}
        public MachineStatus Status{get; set;}

    }
}