using MachinePark.Domain.Enums;

namespace MachinePark.Web.Features.Machines.ViewModels
{
    public record MachineViewModel
    {
        public Guid Id { get; init; }
        public string? Name { get; init; }
        public MachineStatus Status { get; init; }
        public string? Type { get; init; }
    }
}
