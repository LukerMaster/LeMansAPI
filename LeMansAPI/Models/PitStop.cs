namespace LeMansAPI.Models;

public class PitStop
{
    public int Id { get; set; }
    public float LitersRefueled { get; set; }
    public int NumOfTiresChanged { get; set; }

    /// <summary>
    /// If null, no driver swaps in this PitStop
    /// </summary>
    public Driver? NewDriver { get; set; }
    public string? NotesOfRepairs { get; set; }
    public string? OtherNotes { get; set; }
}