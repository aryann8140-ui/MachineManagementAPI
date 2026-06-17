namespace MachineManagementAPI.Dtos
{
      public class MaintenanceDto
    {
        public int MachineId{get; set;}
        public string? Description {get; set;}
        public string? PerformedBy {get; set;}
        public DateTime MaintenanceDate{get; set;}
        public decimal Cost {get; set;}
    }    

}