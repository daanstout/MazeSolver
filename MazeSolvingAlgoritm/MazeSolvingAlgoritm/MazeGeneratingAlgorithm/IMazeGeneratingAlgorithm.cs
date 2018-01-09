using MazeSolvingAlgoritm.MazeMain;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeSolvingAlgoritm.MazeGeneratingAlgorithm {
    public interface IMazeGeneratingAlgorithm {
        void GenerateMaze(Maze maze);
    }
}
