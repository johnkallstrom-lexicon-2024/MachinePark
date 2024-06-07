using MachinePark.Domain.Enums;

namespace MachinePark.ViewModels
{
    public record MachineCreateOrEditViewModel
    {
        public string? Name { get; init; }
        public MachineStatus Status { get; init; }
    }
}
