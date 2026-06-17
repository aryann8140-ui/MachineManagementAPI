using System.ComponentModel.DataAnnotations;
using MachineManagementAPI.Models.Enum;

namespace MachineManagementAPI.Dtos
{
       public class MachineStatusDto
    {
        [Required]
        public string? Name{get; set;}
        public MachineStatus Status{get; set;}

    }
}