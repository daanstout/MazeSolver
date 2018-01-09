using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeSolvingAlgoritm.MazeMain {
    public class Wall : Node{
        public Wall(int x, int y) : base(x, y, true, 5) { }

        public override void Draw(Graphics g) {
            g.FillRectangle(new SolidBrush(Color.Blue), x * Global.mazeSize, y * Global.mazeSize, Global.mazeSize, Global.mazeSize);

            base.Draw(g);
        }
    }
}
