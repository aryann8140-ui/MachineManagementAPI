namespace MachineManagementAPI.Models
{
    public class Operator
    {
        public int Id{get; set;}
        public string? Name{get; set;}
        public string? Email{get; set;}
        public int AssignedMachineId{get; set;}

        public Machine? Machine {get; set;}

    }
}