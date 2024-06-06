namespace MachinePark.Domain.Entities
{
    public class MachineType
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        public Guid MachineId { get; set; }
        public Machine Machine { get; set; } = default!;
    }
}
