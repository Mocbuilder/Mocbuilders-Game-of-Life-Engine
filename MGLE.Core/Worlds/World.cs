using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGLE.Core.Worlds
{
    public class World
    {
        public int Width { get; }
        public int Height { get; }
        public WorldState State { get; set; }
        public bool WrapAround { get; }

        public World(int width, int height, bool wrapAround)
        {
            Width = width;
            Height = height;
            State = new WorldState(0);
            WrapAround = wrapAround;
        }

        public List<Position> GetNeighbourPositions(Position position)
        {
            List<Position> neighbours = new();

            for (int x = -1; x <= 1; x++)
            {
                for (int y = -1; y <= 1; y++)
                {
                    if (x == 0 && y == 0)
                        continue;

                    neighbours.Add(new Position(
                        position.X + x,
                        position.Y + y
                    ));
                }
            }

            return neighbours;
        }

        public bool IsPositionValid(Position position)
        {
            return position.X >= 0 &&
                   position.X < Width &&
                   position.Y >= 0 &&
                   position.Y < Height;
        }

        public Position NormalizePosition(Position position)
        {
            if (!WrapAround)
                return position;

            int x = position.X;
            int y = position.Y;

            if (x < 0)
                x = Width - 1;
            else if (x >= Width)
                x = 0;

            if (y < 0)
                y = Height - 1;
            else if (y >= Height)
                y = 0;

            return new Position(x, y);
        }
    }
}
