namespace MachineManagementAPI.Models
{
    public class MaintenanceLog
    {
        public int Id{get; set;}
        public int MachineId{get; set;}
        public string? Description {get; set;}
        public string? PerformedBy {get; set;}
        public DateTime MaintenanceDate{get; set;}
        public decimal Cost {get; set;}

        public Machine? Machine {get; set;}
    }
}