using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeSolvingAlgoritm.MazeMain {
    public abstract class Node {
        public bool isWall;

        public int distance = int.MaxValue;
        public Node previous;

        public int x;
        public int y;

        public int weight;

        protected Node(int x, int y) : this(x, y, false, 1) { }

        protected Node(int x, int y, bool isWall, int weight) {
            this.x = x;
            this.y = y;
            this.isWall = isWall;
            this.weight = weight;
        }

        public override string ToString() {
            return "{" + x + ", " + y + "}";
        }

        public virtual void Draw(Graphics g) {
            if (Global.showDistance)
                g.DrawString((distance == int.MaxValue ? "" : distance.ToString()), new Font("Arial", (int)((float)Global.mazeSize * 0.6f)), new SolidBrush(Color.Black), x * Global.mazeSize, y * Global.mazeSize);
            else
                g.FillRectangle(new SolidBrush(Color.Black), getConnectingRectangle(this));
        }

        protected Rectangle getConnectingRectangle(Node current) {
            if (current == null || current.previous == null)
                return new Rectangle();

            int x = current.x > current.previous.x ? current.previous.x : current.x;
            int y = current.y > current.previous.y ? current.previous.y : current.y;

            int width = current.x == current.previous.x ? (int)((float)Global.mazeSize * 0.4f) : (int)((float)Global.mazeSize * 1.4f);
            int heigth = current.y == current.previous.y ? (int)((float)Global.mazeSize * 0.4f) : (int)((float)Global.mazeSize * 1.4f);

            Rectangle r = new Rectangle(x * Global.mazeSize + (int)((float)Global.mazeSize * 0.3f), y * Global.mazeSize + (int)((float)Global.mazeSize * 0.3f), width, heigth);

            return r;
        }

        protected void DrawPath(Graphics g) {
            if (this is StartNode)
                return;
            g.FillRectangle(new SolidBrush(Color.Green), getConnectingRectangle(this));

            previous.DrawPath(g);
        }
    }
}
