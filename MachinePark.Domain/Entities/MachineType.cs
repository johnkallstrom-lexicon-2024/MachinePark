namespace MachinePark.Domain.Entities
{
    public class MachineType
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        public ICollection<Machine> Machines { get; set; } = [];
    }
}
