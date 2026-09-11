using MGLE.Core.Cells;

public class WorldState
{
    public int Generation { get; }

    public List<Cell> Cells { get; set; } = new();

    public WorldState(int generation)
    {
        Generation = generation;
    }
}