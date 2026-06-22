using System.ComponentModel.DataAnnotations;
using MachineManagementAPI.Models.Enum;

namespace MachineManagementAPI.Dtos
{
       public class UpdateMachineDto
    {
        public int Id{get; set;}
        [Required]
        public string? Name{get; set;}
        public string? SerialNumber{get; set;}
        public string? Location{get; set;}
        public MachineStatus Status{get; set;}

    }
}