using MazeSolvingAlgoritm.MazeMain;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeSolvingAlgoritm.MazeGeneratingAlgorithm {
    public class BinaryRecursiveMazeGeneration : IMazeGeneratingAlgorithm {
        Random rand = new Random();


        public void GenerateMaze(Maze maze) {
            if (maze == null)
                return;
            else {
                maze.Empty();
                GenerateMaze(maze, maze.width - 2, maze.height - 2, 1, 1, rand.Next(1, 3) % 2 == 0);
            }
        }

        private void GenerateMaze(Maze maze, int width, int height, int x, int y, bool horizontal) {
            if (!Global.noDelay)
                while (!MazeSolver.doStep) { }
            MazeSolver.doStep = false;

            if (horizontal) { // Horizontal Wall
                if (width == 1)
                    return;
                else {
                    int half = y + ((height + 1) / 2) - 1;
                    for (int i = x; i <= width + x - 1; i++) {
                        maze.SetNode(i, half, true);
                    }
                    int gap = rand.Next(1, width / 2 + 2) * 2 - 2 + x;
                    maze.SetNode(gap, half, false);

                    GenerateMaze(maze, width, height / 2, x, y, !horizontal);
                    GenerateMaze(maze, width, height / 2, x, y + (height / 2) + 1, !horizontal);
                }
            } else { // Vertical Wall
                if (height == 1)
                    return;
                else {
                    int half = x + ((width + 1) / 2) - 1;
                    for (int i = y; i <= height + y - 1; i++) {
                        maze.SetNode(half, i, true);
                    }
                    int gap = rand.Next(1, height / 2 + 2) * 2 - 2 + y;
                    maze.SetNode(half, gap, false);

                    GenerateMaze(maze, width / 2, height, x, y, !horizontal);
                    GenerateMaze(maze, width / 2, height, x + (width / 2) + 1, y, !horizontal);
                }
            }
        }
    }
}
