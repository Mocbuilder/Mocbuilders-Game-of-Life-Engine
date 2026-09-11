using MGLE.Core.World;

namespace MGLE.Core.Rules
{
    public interface IWorldRule
    {
        void Apply(WorldState current, WorldState next);
    }
}