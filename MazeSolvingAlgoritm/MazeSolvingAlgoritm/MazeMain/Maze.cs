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
            solved = false;
            maze = new Node[width, height];

            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                    if (i == 1 && j == 0)
                        maze[i, j] = new StartNode(i, j);
                    else if (i == width - 2 && j == height - 1)
                        maze[i, j] = new EndNode(i, j);
                    else if (i == 0 || j == 0 || i == width - 1 || j == height - 1)
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

            for(int i = 0; i < width; i++) {
                for(int j = 0; j < height; j++) {
                    maze[i, j].distance = int.MaxValue;
                    maze[i, j].previous = null;
                }
            }
        }
    }
}
