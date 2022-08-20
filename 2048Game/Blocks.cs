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
                deltaX = x == borderX ? 0 : GetDeltaX(y, x, borderX);
            }
            else if (Field.KeyPressed == Keys.Left)
            {
                borderX = 0;
                deltaX = x == borderX ? 0 : GetDeltaX(y, x, borderX);
            }
            else if (Field.KeyPressed == Keys.Down)
            {
                borderY = Field.FieldHeight - 1;
                deltaY = y == borderY ? 0 : GetDeltaY(x, y, borderY);
            }
            else if (Field.KeyPressed == Keys.Up)
            {
                borderY = 0;
                deltaY = y == borderY ? 0 : GetDeltaY(x, y, borderY);
            }

            return new BlockCommand
            {
                DeltaX = deltaX,
                DeltaY = deltaY
            };
        }

        public bool DisappearsInConflict(IBlock block)
        {
            throw new NotImplementedException();
        }

        private int GetDeltaX(int col, int startLoc, int endLoc)
        {
            int newLoc = startLoc;
            int i = startLoc < endLoc ? 1 : -1;
            bool finished = false;
            while (!finished)
            {
                // if block can move further then move it, if it's not the end of field
                if (Field.field[col, startLoc] is null)
                    if (startLoc != endLoc)
                        startLoc += i;
                    else finished = true;
                else finished = true;
            }
            return startLoc - newLoc;
        }

        private int GetDeltaY(int row, int startLoc, int endLoc)
        {
            int newLoc = startLoc;
            int i = startLoc < endLoc ? 1 : -1;
            bool finished = false;
            while (!finished)
            {
                if (Field.field[startLoc, row] is null)
                    if (startLoc != endLoc)
                        startLoc += i;
                    else finished = true;
                else finished = true;
            }
            return startLoc - newLoc;
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
    }
}
