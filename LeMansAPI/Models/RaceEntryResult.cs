namespace LeMansAPI.Models;

public class RaceEntryResult
{
    public int Id { get; set; }
    public Race Race { get; set; } = null!;
    public Driver[] Drivers { get; set; } = null!;
    public PitStop[] PitStops { get; set; } = null!;
    public double MetersDriven { get; set; }
}