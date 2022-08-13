using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048Game
{
    public class BlockCommand
    {
        public int DeltaX;
        public int DeltaY;
        public IBlock TransformTo;
    }
}
