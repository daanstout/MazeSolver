using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MazeSolvingAlgoritm.MazeMain;

namespace MazeSolvingAlgoritm.MazeGeneratingAlgorithm {
    public class PrimsMazeGeneration : IMazeGeneratingAlgorithm {
        Random rand = new Random();



        public void GenerateMaze(Maze maze) {
            if (maze == null)
                return;
            else {
                maze.MakeWalls();
                SetupMaze(maze);
            }
        }

        private void SetupMaze(Maze maze) {
            List<Node> toAdd = new List<Node>();
            List<Node> added = new List<Node>();

            for (int i = 1; i < maze.width; i += 2) {
                for (int j = 1; j < maze.height; j += 2) {
                    if (i == 1 && j == 1)
                        continue;
                    if (maze.GetNode(i, j) == null)
                        continue;
                    toAdd.Add(maze.GetNode(i, j));
                }
            }

            maze.SetNode(1, 1, false);
            added.Add(maze.GetNode(1, 1));

            GenerateMaze(maze, toAdd, added);
        }

        private void GenerateMaze(Maze maze, List<Node> addable, List<Node> added) {
            if (addable.Count == 0)
                return;
            while (addable.Count > 0) {
                if (!Global.noDelay)
                    while (!MazeSolver.doStep) { }
                MazeSolver.doStep = false;

                Node current = added[rand.Next(0, added.Count)];

                List<Node> tempList = new List<Node>();

                if (maze.GetNode(current.x + 2, current.y) != null)
                    if (addable.Contains(maze.GetNode(current.x + 2, current.y)))
                        tempList.Add(maze.GetNode(current.x + 2, current.y));

                if (maze.GetNode(current.x, current.y + 2) != null)
                    if (addable.Contains(maze.GetNode(current.x, current.y + 2)))
                        tempList.Add(maze.GetNode(current.x, current.y + 2));

                if (maze.GetNode(current.x - 2, current.y) != null)
                    if (addable.Contains(maze.GetNode(current.x - 2, current.y)))
                        tempList.Add(maze.GetNode(current.x - 2, current.y));

                if (maze.GetNode(current.x, current.y - 2) != null)
                    if (addable.Contains(maze.GetNode(current.x, current.y - 2)))
                        tempList.Add(maze.GetNode(current.x, current.y - 2));

                if (tempList.Count == 0) {
                    added.Remove(current);
                    continue;
                }

                Node next = tempList[rand.Next(0, tempList.Count)];

                Node middle = maze.GetNode((current.x + next.x) / 2, (current.y + next.y) / 2);

                next.previous = middle;
                middle.previous = current;

                next.distance = current.distance + 2;
                middle.distance = current.distance + 1;

                maze.SetNode(middle.x, middle.y, false);
                maze.SetNode(next.x, next.y, false);

                added.Add(next);
                addable.Remove(next);

                //Console.WriteLine(next);
            }
        }
    }
}
