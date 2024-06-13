namespace MachinePark.Shared.Models
{
    public record StatisticsDto
    {
        public int TotalMachines { get; init; }
        public int TotalOnline { get; init; }
        public int TotalOffline { get; init; }
        public int Excavators { get; init; }
        public int WheelLoaders { get; init; }
        public int Dozers { get; init; }
    }
}
