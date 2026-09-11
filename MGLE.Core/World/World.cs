using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGLE.Core.World
{
    public class World
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public WorldState State { get; set; }
    }
}
