using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MazeSolvingAlgoritm.MazeMain;

namespace MazeSolvingAlgoritm.MazeGeneratingAlgorithm {
    public class OddRecursiveMazeGeneration : IMazeGeneratingAlgorithm {
        Random rand = new Random();

        public void GenerateMaze(Maze maze) {
            if (maze == null)
                return;
            else {
                maze.Empty();
                GenerateMaze(maze, maze.width - 2, maze.height - 2, 1, 1, rand.Next(1, 3) % 2 == 0);
            }
        }

        public void GenerateMaze(Maze maze, int width, int height, int x, int y, bool horizontal) {
            if (!Global.noDelay)
                while (!MazeSolver.doStep) { }
            MazeSolver.doStep = false;

            if (horizontal) { // Horizontal Wall
                if (width == 1 || height == 1)
                    return;
                else {
                    int half = rand.Next(1, height / 2 + 1) * 2;
                    for (int i = x; i <= width + x - 1; i++)
                        maze.SetNode(i, half + y - 1, true);
                    int gap = rand.Next(1, width / 2 + 2) * 2 - 2 + x;
                    maze.SetNode(gap, half + y - 1, false);
                    
                    GenerateMaze(maze, width, height - half, x, half + y, !horizontal);
                    GenerateMaze(maze, width, half - 1, x, y, !horizontal);
                }
            } else { // vertical Wall
                if (height == 1 || width == 1)
                    return;
                else {
                    int half = rand.Next(1, width / 2 + 1) * 2;
                    for (int i = y; i <= height + y - 1; i++)
                        maze.SetNode(half + x - 1, i, true);
                    int gap = rand.Next(1, height / 2 + 2) * 2 - 2 + y;
                    maze.SetNode(half + x - 1, gap, false);
                    
                    GenerateMaze(maze, width - half, height, half + x, y, !horizontal);
                    GenerateMaze(maze, half - 1, height, x, y, !horizontal);
                }
            }
        }
    }
}
