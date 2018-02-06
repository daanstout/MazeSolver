using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MazeSolvingAlgoritm.MazeMain;

namespace MazeSolvingAlgoritm.MazeSolvingAlgorithm {
    public class WallRunnerSolvingAlgorithm : IMazeSolvingAlgorithm {
        Queue<Node> q;

        public void SolveMaze(Maze maze) {
            if (maze == null)
                return;
            else {
                //maze.GetNode(1, 0).distance = 0;
                maze.startNode.distance = 0;

                q = new Queue<Node>();

                //q.Enqueue(maze.GetNode(1, 0));
                q.Enqueue(maze.startNode);

                while (!q.isEmpty) {
                    Node current = q.Dequeue();

                    if (current == null)
                        continue;

                    if (!Global.noDelay)
                        while (!MazeSolver.doStep) { }
                    MazeSolver.doStep = false;

                    if (current is EndNode) {
                        Maze.solved = true;
                        if (Global.earlyExit)
                            return;
                    }

                    if (current.y > 0) {
                        if (maze.GetNode(current.x, current.y - 1).distance > current.distance + maze.GetNode(current.x, current.y - 1).weight) {
                            Node next = maze.GetNode(current.x, current.y - 1);
                            next.previous = current;
                            next.distance = current.distance + next.weight;
                            q.Enqueue(next);
                        }
                    }
                    if (current.x < maze.width - 1) {
                        if (maze.GetNode(current.x + 1, current.y).distance > current.distance + maze.GetNode(current.x + 1, current.y).weight) {
                            Node next = maze.GetNode(current.x + 1, current.y);
                            next.previous = current;
                            next.distance = current.distance + next.weight;
                            q.Enqueue(next);
                        }
                    }
                    if (current.y < maze.height - 1) {
                        if (maze.GetNode(current.x, current.y + 1).distance > current.distance + maze.GetNode(current.x, current.y + 1).weight) {
                            Node next = maze.GetNode(current.x, current.y + 1);
                            next.previous = current;
                            next.distance = current.distance + next.weight;
                            q.Enqueue(next);
                        }
                    }
                    if (current.x > 0) {
                        if (maze.GetNode(current.x - 1, current.y).distance > current.distance + maze.GetNode(current.x - 1, current.y).weight) {
                            Node next = maze.GetNode(current.x - 1, current.y);
                            next.previous = current;
                            next.distance = current.distance + next.weight;
                            q.Enqueue(next);
                        }
                    }
                }
            }
        }
    }
}
