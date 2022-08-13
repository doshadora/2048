using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048Game
{
    public class Block : IBlock
    {
        public int value;
        public Block()
        {
            Random rnd = new Random();
            value = rnd.Next(100) < 80 ? 2 : 4;
        }

        public BlockCommand Act(int x, int y)  // in - current coordinates on field
        {
            throw new NotImplementedException();
            int deltaX = 0;
            int deltaY = 0;

            int borderX = 0;
            int borderY = 0;

            if (Field.KeyPressed == Keys.Right)
            {
                borderX = Field.FieldWidth - 1;
                deltaX = x == borderX ? 0 : GetDeltaX(x ,borderX);
            }
        }

        public bool DisappearsInConflict(IBlock block)
        {
            throw new NotImplementedException();
        }

        public int GetDrawingPriority()
        {
            throw new NotImplementedException();
        }

        private int GetDeltaX(int startLoc, int endLoc)
        {
            int newLoc = 0;
            return newLoc;
        }
    }

    public class BlockFixed : IBlock
    {
        public BlockCommand Act(int x, int y)
        {
            throw new NotImplementedException();
        }

        public bool DisappearsInConflict(IBlock block)
        {
            throw new NotImplementedException();
        }

        public int GetDrawingPriority()
        {
            throw new NotImplementedException();
        }
    }
}
