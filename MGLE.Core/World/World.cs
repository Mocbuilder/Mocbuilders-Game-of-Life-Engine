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
    }
}
