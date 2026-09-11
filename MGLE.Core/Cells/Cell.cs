using MGLE.Core.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGLE.Core.Cells
{
    public class Cell
    {
        public Position Position { get; }
        public CellState State { get; set; }

        public Cell(Position position, CellState state)
        {
            Position = position;
            State = state;
        }
    }
}
