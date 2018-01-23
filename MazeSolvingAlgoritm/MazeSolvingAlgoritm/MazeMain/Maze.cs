using MazeSolvingAlgoritm.MazeGeneratingAlgorithm;
using MazeSolvingAlgoritm.MazeSolvingAlgorithm;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeSolvingAlgoritm.MazeMain {
    public class Maze {
        private Node[,] maze;

        private Node _startNode;

        public Node startNode {
            get {
                return _startNode;
            }
        }

        private Node _endNode;

        public Node endNode {
            get {
                return _endNode;
            }
        }

        public int width { get; private set; }
        public int height { get; private set; }

        public static bool solved;

        public Maze(int width, int height) {
            if (width % 2 == 0 || height % 2 == 0)
                throw new WrongMazeSizeException("Error! Width or Height not odd!");

            this.width = width;
            this.height = height;
            initMaze();
        }

        private void initMaze() {
            Node start = maze == null ? new StartNode(1, 0) : new StartNode(_startNode.x, _startNode.y);
            Node end = maze == null ? new EndNode(width - 2, height - 1) : new EndNode(_endNode.x, _endNode.y);
            solved = false;
            maze = new Node[width, height];

            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                    if (i == start.x && j == start.y) {
                        maze[i, j] = new StartNode(i, j);
                        _startNode = maze[i, j];
                    } else if (i == end.x && j == end.y) {
                        maze[i, j] = new EndNode(i, j);
                        _endNode = maze[i, j];
                    } else if (i == 0 || j == 0 || i == width - 1 || j == height - 1)
                        maze[i, j] = new Wall(i, j);
                    else
                        maze[i, j] = new Path(i, j, 1);
        }

        public void Draw(Graphics g) {
            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                    if (GetNode(i, j) != null)
                        GetNode(i, j).Draw(g);
        }

        public Node GetNode(int x, int y) {
            if (x < 0 || y < 0 || x > width - 1 || y > height - 1)
                return null;
            return maze[x, y];
        }

        public bool isWall(int x, int y) {
            return maze[x, y].isWall;
        }

        public void SetNode(int x, int y, bool wall) {
            maze[x, y] = wall ? (Node)new Wall(x, y) : new Path(x, y, 1);
        }

        public void Empty() {
            initMaze();
        }

        public void MakeWalls() {
            initMaze();

            for (int i = 1; i < width - 1; i++)
                for (int j = 1; j < height - 1; j++)
                    maze[i, j] = new Wall(i, j);
        }

        public void ResetMaze() {
            solved = false;

            for (int i = 0; i < width; i++) {
                for (int j = 0; j < height; j++) {
                    maze[i, j].distance = int.MaxValue;
                    maze[i, j].previous = null;
                }
            }
        }

        public void ToggleNode(int x, int y) {
            if (x < 0 || x > width - 1 || y < 0 || y > height - 1)
                return;

            Node n = maze[x, y];

            if (n is Wall)
                maze[x, y] = new Path(x, y, 1);
            else if (n is Path)
                maze[x, y] = new Wall(x, y);
        }

        public void ToggleNode(int x1, int y1, int x2, int y2) {
            for (int i = x1; x1 < x2 ? i <= x2 : i >= x2; i += x1 < x2 ? 1 : -1)
                for (int j = y1; y1 < y2 ? j <= y2 : j >= y2; j += y1 < y2 ? 1 : -1)
                    ToggleNode(i, j);
        }

        public void MoveStartNode(int x, int y) {
            //if ((x % 2 == 0 || y % 2 == 0) && !(x == 0 || x == width - 1 || y == 0 || y == height - 1))
            //    return;

            if (_startNode.x == 0 || _startNode.x == width - 1 || _startNode.y == 0 || _startNode.y == height - 1)
                maze[_startNode.x, _startNode.y] = new Wall(_startNode.x, _startNode.y);
            else
                maze[_startNode.x, _startNode.y] = new Path(_startNode.x, _startNode.y, 1);

            _startNode = maze[x, y] = new StartNode(x, y);
        }
    }
}
