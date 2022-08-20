
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048Game
{
    public interface IBlock
    {
        BlockCommand Act(int x, int y);
        bool DisappearsInConflict(IBlock block);
    }
}
