using MachinePark.Domain.Enums;

namespace MachinePark.Shared.Models
{
    public record MachineDto
    {
        public Guid Id { get; init; }
        public string? Name { get; init; }
        public MachineStatus Status { get; init; }
        public string? Type { get; init; }
    }
}
