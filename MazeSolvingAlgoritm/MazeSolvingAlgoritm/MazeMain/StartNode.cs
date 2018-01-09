using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeSolvingAlgoritm.MazeMain {
    public class StartNode : Path{
        public StartNode(int x, int y) : base(x, y, 0) { }

        public override void Draw(Graphics g) {
            g.FillRectangle(new SolidBrush(Color.Green), x * Global.mazeSize, y * Global.mazeSize, Global.mazeSize, Global.mazeSize);
        }
    }
}
