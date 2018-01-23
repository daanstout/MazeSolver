using MazeSolvingAlgoritm.MazeMain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeSolvingAlgoritm {
    public static class Global {
        public static bool showDistance;
        public static int mazeSize = 10;
        public static bool noDelay = false;

        public static int Heuristic(Node a, Node b) {
            return Math.Abs(a.x - b.x) + Math.Abs(a.y - b.y);
        }
    }
}
