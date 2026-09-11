using MGLE.Core.Cells;

namespace MGLE.Core.Worlds;

public class WorldState
{
    public int Generation { get; }

    public List<Cell> Cells { get; set; } = new();

    public WorldState(int generation)
    {
        Generation = generation;
    }
}