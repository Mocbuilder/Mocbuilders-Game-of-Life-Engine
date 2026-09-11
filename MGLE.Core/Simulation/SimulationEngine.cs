using MGLE.Core.Rules;
using MGLE.Core.World;

public class SimulationEngine
{
    public World World { get; }
    public IWorldRule Rule { get; }

    public SimulationEngine(World world, IWorldRule rule)
    {
        World = world;
        Rule = rule;
    }

    public void Step()
    {
        WorldState current = World.State;
        WorldState next = new(current.Generation + 1);

        Rule.Apply(current, next);

        World.State = next;
    }
}