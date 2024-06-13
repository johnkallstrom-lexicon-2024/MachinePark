using MachinePark.Domain.Enums;
using System.Text.Json.Serialization;

namespace MachinePark.Shared.Models
{
    public record MachineDto
    {
        public Guid Id { get; init; }
        public string Name { get; init; } = default!;
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public MachineStatus Status { get; init; }
        public MachineTypeDto Type { get; set; } = default!;
    }
}
