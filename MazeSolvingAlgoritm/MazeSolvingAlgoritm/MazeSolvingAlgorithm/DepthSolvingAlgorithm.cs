using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MazeSolvingAlgoritm.MazeMain;

namespace MazeSolvingAlgoritm.MazeSolvingAlgorithm {
    public class DepthSolvingAlgorithm : IMazeSolvingAlgorithm {
        public void SolveMaze(Maze maze) {
            if (maze == null)
                return;
            else {
                maze.GetNode(1, 0).distance = 0;
                SolveMaze(maze, 1, 0);
                //SolveMaze(maze, maze.GetNode(1, 0));
            }
        }

        private void SolveMaze(Maze maze, int x, int y) {
            if (x < 0 || x == maze.width || y < 0 || y == maze.height)
                return;

            if (!Global.noDelay)
                while (!MazeSolver.doStep) { }
            MazeSolver.doStep = false;

            if (maze.GetNode(x, y) is EndNode)
                Maze.solved = true;

            if (y > 0) {
                if (!maze.isWall(x, y - 1) && maze.GetNode(x, y - 1).distance > maze.GetNode(x, y).distance + maze.GetNode(x, y - 1).weight) {
                    maze.GetNode(x, y - 1).previous = maze.GetNode(x, y);
                    maze.GetNode(x, y - 1).distance = maze.GetNode(x, y).distance + maze.GetNode(x, y - 1).weight;
                    SolveMaze(maze, x, y - 1);
                }
            }
            if (x < maze.width - 1) {
                if (!maze.isWall(x + 1, y) && maze.GetNode(x + 1, y).distance > maze.GetNode(x, y).distance + maze.GetNode(x + 1, y).weight) {
                    maze.GetNode(x + 1, y).previous = maze.GetNode(x, y);
                    maze.GetNode(x + 1, y).distance = maze.GetNode(x, y).distance + maze.GetNode(x + 1, y).weight;
                    SolveMaze(maze, x + 1, y);
                }
            }
            if (y < maze.height - 1) {
                if (!maze.isWall(x, y + 1) && maze.GetNode(x, y + 1).distance > maze.GetNode(x, y).distance + maze.GetNode(x, y + 1).weight) {
                    maze.GetNode(x, y + 1).previous = maze.GetNode(x, y);
                    maze.GetNode(x, y + 1).distance = maze.GetNode(x, y).distance + maze.GetNode(x, y + 1).weight;
                    SolveMaze(maze, x, y + 1);
                }
            }
            if (x > 0) {
                if (!maze.isWall(x - 1, y) && maze.GetNode(x - 1, y).distance > maze.GetNode(x, y).distance + maze.GetNode(x - 1, y).weight) {
                    maze.GetNode(x - 1, y).previous = maze.GetNode(x, y);
                    maze.GetNode(x - 1, y).distance = maze.GetNode(x, y).distance + maze.GetNode(x - 1, y).weight;
                    SolveMaze(maze, x - 1, y);
                }
            }
        }
    }
}
