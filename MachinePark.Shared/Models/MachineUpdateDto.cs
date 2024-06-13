using MachinePark.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace MachinePark.Shared.Models
{
    public record MachineUpdateDto
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = default!;

        [Required]
        [EnumDataType(typeof(MachineStatus))]
        public MachineStatus Status { get; set; }

        [Required]
        public int MachineTypeId { get; set; } = 1;
    }
}
