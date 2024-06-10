﻿using MachinePark.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace MachinePark.Shared.Models
{
    public record MachineEditDto
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = default!;

        [Required]
        [EnumDataType(typeof(MachineStatus))]
        public MachineStatus Status { get; set; }
    }
}