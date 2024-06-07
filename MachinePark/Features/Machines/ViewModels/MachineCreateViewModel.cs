using MachinePark.Domain.Enums;

namespace MachinePark.Features.Machines.ViewModels
{
    public record MachineCreateViewModel
    {
        public string? Name { get; init; }
        public MachineStatus Status { get; init; }
    }
}
