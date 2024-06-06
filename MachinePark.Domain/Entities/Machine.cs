using MachinePark.Domain.Enums;

namespace MachinePark.Domain.Entities
{
    public class Machine
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public MachineStatus Status { get; set; }
        public MachineType Type { get; set; } = default!;
    }
}
