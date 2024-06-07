using MachinePark.Domain.Enums;

namespace MachinePark.Features.Machines.ViewModels
{
    public record MachineEditViewModel
    {
        public string? Name { get; init; }
        public MachineStatus Status { get; init; }
    }
}
