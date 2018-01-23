using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MazeSolvingAlgoritm.MazeMain;

namespace MazeSolvingAlgoritm.MazeSolvingAlgorithm {
    public class AStarSolvingAlgorithm : IMazeSolvingAlgorithm {
        PriorityQueue q;

        public void SolveMaze(Maze maze) {
            if (maze == null)
                return;
            else {
                q = new PriorityQueue();

                maze.startNode.distance = 0;

                q.Insert(maze.startNode, 1);

                while (!q.isEmpty) {
                    Node current = q.GetHighestPriority();

                    if (current == null)
                        continue;

                    if (!Global.noDelay)
                        while (!MazeSolver.doStep) { }
                    MazeSolver.doStep = false;

                    if (current is EndNode)
                        Maze.solved = true;

                    Node next;

                    if (current.y > 0) {
                        next = maze.GetNode(current.x, current.y - 1);
                        if (!next.isWall && next.distance > current.distance + next.weight) {
                            next.previous = current;
                            next.distance = current.distance + next.weight;
                            q.Insert(next, next.distance + Global.Heuristic(next, maze.endNode));
                        }
                    }

                    if (current.x < maze.width - 1) {
                        next = maze.GetNode(current.x + 1, current.y);
                        if (!next.isWall && next.distance > current.distance + next.weight) {
                            next.previous = current;
                            next.distance = current.distance + next.weight;
                            q.Insert(next, next.distance + Global.Heuristic(next, maze.endNode));
                        }
                    }

                    if (current.y < maze.height - 1) {
                        next = maze.GetNode(current.x, current.y + 1);
                        if (!next.isWall && next.distance > current.distance + next.weight) {
                            next.previous = current;
                            next.distance = current.distance + next.weight;
                            q.Insert(next, next.distance + Global.Heuristic(next, maze.endNode));
                        }
                    }

                    if (current.x > 0) {
                        next = maze.GetNode(current.x - 1, current.y);
                        if (!next.isWall && next.distance > current.distance + next.weight) {
                            next.previous = current;
                            next.distance = current.distance + next.weight;
                            q.Insert(next, next.distance + Global.Heuristic(next, maze.endNode));
                        }
                    }
                }
            }
        }
    }
}
