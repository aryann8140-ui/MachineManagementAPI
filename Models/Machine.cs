using System.ComponentModel.DataAnnotations;
using MachineManagementAPI.Models.Enum;

namespace MachineManagementAPI.Models
{
    public class Machine
    {
        public int Id{get; set;}
        [Required]
        public string? Name{get; set;}
        public string? SerialNumber{get; set;}
        public string? Location{get; set;}
        public MachineStatus Status{get; set;}
        public DateTime PurchaseDate{get; set;}

        public ICollection<MaintenanceLog> MaintenanceLogs {get; set;} = new List<MaintenanceLog>();
       public ICollection<Operator> Operators {get; set;} = new List<Operator>();


    }
}