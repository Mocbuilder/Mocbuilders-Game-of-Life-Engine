using MGLE.Core.Cells;
using MGLE.Core.Worlds;

namespace MGLE.Core.Rules
{
    public class ConwayRule : IWorldRule
    {
        private readonly World _world;

        public ConwayRule(World world)
        {
            _world = world;
        }

        public void Apply(WorldState current, WorldState next)
        {
            throw new NotImplementedException();
        }

        private int CountLivingNeighbours(Position position, WorldState state)
        {
            int livingNeighbours = 0;

            foreach (Position neighbourPosition in _world.GetNeighbourPositions(position))
            {
                Position normalizedPosition = _world.NormalizePosition(neighbourPosition);

                if (!_world.IsPositionValid(normalizedPosition))
                    continue;

                Cell? neighbour = state.Cells.FirstOrDefault(
                    c => c.Position == normalizedPosition);

                if (neighbour?.State == CellState.Alive)
                    livingNeighbours++;
            }

            return livingNeighbours;
        }
    }
}