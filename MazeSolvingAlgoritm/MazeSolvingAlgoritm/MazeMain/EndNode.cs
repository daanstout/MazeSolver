using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeSolvingAlgoritm.MazeMain {
    public class EndNode : Path{
        public EndNode(int x, int y) : base(x, y, 1) { }

        public override void Draw(Graphics g) {
            g.FillRectangle(new SolidBrush(Color.Red), x * Global.mazeSize, y * Global.mazeSize, Global.mazeSize, Global.mazeSize);
            base.Draw(g);

            if (Maze.solved)
                DrawPath(g);
        }
    }
}
