using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeMansAPI.Models;

[Table("RaceEntryResults")]
public class RaceEntryResult
{
    [Key]
    public int Id { get; set; }
    public Race Race { get; set; } = null!;
    public Car Car { get; set; } = null!;
    public Driver[] Drivers { get; set; } = null!;
    public PitStop[] PitStops { get; set; } = null!;
    public double MetersDriven { get; set; }
}