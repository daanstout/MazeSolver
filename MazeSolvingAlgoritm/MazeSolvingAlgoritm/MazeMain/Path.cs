using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeSolvingAlgoritm.MazeMain {
    public class Path : Node {
        public Path(int x, int y, int weight) : base(x, y, false, weight) { }

        public override void Draw(Graphics g) {
            base.Draw(g);
        }
    }
}
