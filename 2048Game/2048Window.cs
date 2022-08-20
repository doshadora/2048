using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048Game
{
    public partial class _2048Window : Form
    {
        private readonly GameState gameState;
        private readonly HashSet<Keys> pressedKeys = new HashSet<Keys>();
        private int tickCount;

        public _2048Window()
        {
            InitializeComponent();
            DoubleBuffered = true;
            gameState = new GameState();
            var timer = new Timer();
            timer.Interval = 15;
            timer.Tick += TimerTick;
            timer.Start();
            // 6;6 - 6;112 - 112;6
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            foreach (var a in gameState.Animations)
            e.Graphics.ResetTransform();
            LabelScore.Text = Field.Scores.ToString();
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            pressedKeys.Add(e.KeyCode);
            Field.KeyPressed = e.KeyCode;
        }

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            pressedKeys.Add(e.KeyCode);
            Field.KeyPressed = pressedKeys.Any() ? pressedKeys.Min() : Keys.None;
        }

        private void TimerTick(object sender, EventArgs args)
        {
            if (tickCount == 0) gameState.BeginAct();
            foreach (var e in gameState.Animations)
                e.Location = new Point(e.Location.X + 4 * e.Command.DeltaX, e.Location.Y + 4 * e.Command.DeltaY);
            if (tickCount == 7)
                gameState.EndAct();
            tickCount++;
            if (tickCount == 8) tickCount = 0;
            Invalidate();
        }
    }
}
