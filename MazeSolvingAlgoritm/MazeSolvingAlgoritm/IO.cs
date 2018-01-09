using MazeSolvingAlgoritm.MazeMain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeSolvingAlgoritm {
    public static class IO {
        public static void SaveMaze(Maze maze) {
            Image img = new Bitmap(maze.width * Global.mazeSize, maze.height * Global.mazeSize);
            Graphics drawing = Graphics.FromImage(img);

            drawing.Clear(Color.White);

            maze.Draw(drawing);

            img.Save("C:\\Users\\Daans\\Desktop\\maze.png");
        }
    }
}
