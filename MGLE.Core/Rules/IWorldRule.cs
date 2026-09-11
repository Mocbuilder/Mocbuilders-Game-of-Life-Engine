using MGLE.Core.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGLE.Core.Rules
{
    public interface IWorldRule
    {
        void Apply(WorldState current, WorldState next);
    }
}
