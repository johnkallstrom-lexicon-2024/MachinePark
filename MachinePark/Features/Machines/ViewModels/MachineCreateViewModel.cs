using MachinePark.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace MachinePark.Features.Machines.ViewModels
{
    public record MachineCreateViewModel
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = default!;

        [Required]
        [EnumDataType(typeof(MachineStatus))]
        public MachineStatus Status { get; set; }
    }
}
