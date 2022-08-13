using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048Game
{
    internal class Field
    {
        public static IBlock[,] field;
        public static bool GameOver;
        public static int Scores;
        public static Keys KeyPressed;
        public static int FieldWidth => field.GetLength(0);
        public static int FieldHeight => field.GetLength(1);
        public static void CreateMap()
        {

        }
    }
}
