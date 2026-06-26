namespace MachineManagementAPI.Dtos
{
      public class CreateMaintenanceDto
    {
        public int MachineId{get; set;}
        public string? Description {get; set;}
        public string? PerformedBy {get; set;}       
        public decimal Cost {get; set;}
    }
}