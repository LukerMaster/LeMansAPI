using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeMansAPI.Models;

[Table("Cars")]
public class Car
{
    [Key]
    public int Id { get; set; }
    public string Brand { get; set; } = null!;
    public string Model { get; set; } = null!;
    public int ProductionYear { get; set; }
    public float PeakPowerKw { get; set; }
    public float CurbWeightKg { get; set; }
}