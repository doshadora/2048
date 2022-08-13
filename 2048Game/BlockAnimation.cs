using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048Game
{
    public class BlockAnimation
    {
        public BlockCommand Command;
        public IBlock block;
        public Point Location;
        public Point TargetLocation;
    }
}
