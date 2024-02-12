namespace LeMansAPI.Models;

public class Car
{
    public int Id { get; set; }
    public string Brand { get; set; } = null!;
    public string Model { get; set; } = null!;
    public int ProductionYear { get; set; }
    public float PeakPowerKw { get; set; }
}