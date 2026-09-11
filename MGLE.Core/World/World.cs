using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGLE.Core.World
{
    public class World
    {
        public int Width { get; }
        public int Height { get; }
        public WorldState State { get; set; }

        public World(int width, int height)
        {
            Width = width;
            Height = height;
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
    }
}
