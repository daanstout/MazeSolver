using MazeSolvingAlgoritm.MazeGeneratingAlgorithm;
using MazeSolvingAlgoritm.MazeMain;
using MazeSolvingAlgoritm.MazeSolvingAlgorithm;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeSolvingAlgoritm {
    public partial class MazeSolver : Form {
        public static MazeSolver instance;

        private Maze maze = new Maze(33, 33);

        private IMazeGeneratingAlgorithm generation = new BinaryRecursiveMazeGeneration();
        private IMazeSolvingAlgorithm solving = new DepthSolvingAlgorithm();

        public static volatile bool doStep = false;

        private int[] validDimensions = new int[7] { 9, 17, 33, 65, 129, 257, 513 };

        private Point mouseDown;

        public MazeSolver() {
            InitializeComponent();

            generationAlgorithmComboBox.Items.Add("Binary Recursive Algorithm");
            generationAlgorithmComboBox.Items.Add("Odd Recursive Algorithm");
            generationAlgorithmComboBox.Items.Add("Prim's Algorithm");

            solvingAlgorithmsComboBox.Items.Add("Depth First");
            solvingAlgorithmsComboBox.Items.Add("Breadth First");
            solvingAlgorithmsComboBox.Items.Add("Breadth First Early Exit");
            solvingAlgorithmsComboBox.Items.Add("Wall Runner (Breadth Variant)");
            solvingAlgorithmsComboBox.Items.Add("A*");
            solvingAlgorithmsComboBox.Items.Add("A* Early Exit");

            instance = this;

            //PriorityQueue q = new PriorityQueue();

            //q.Insert(new Path(1, 1, 1), 5);
            //q.Insert(new Path(1, 1, 1), 10);
            //q.Insert(new Path(1, 1, 1), 3);
            //q.Insert(new Path(1, 1, 1), 1);
            //q.Insert(new Path(1, 1, 1), 2);

            //q.PrintHeap();

            //Console.WriteLine("\n" + q.GetHighestPriority() + "\n");

            //q.PrintHeap();
        }

        private void mazePictureBox_Paint(object sender, PaintEventArgs e) {
            base.OnPaint(e);
            {
                if (maze != null)
                    maze.Draw(e.Graphics);
            }
        }

        private void solveMazeButton_click(object sender, EventArgs e) {
            if (maze == null)
                return;
            solvingBackgroundWorker.RunWorkerAsync();

            generateMazeButton.Enabled = createMazeButton.Enabled = solveMazeButton.Enabled = resetMazeButton.Enabled = false;
            nextStepButton.Enabled = true;
        }

        private void mainTimer_Tick(object sender, EventArgs e) {
            doStep = true;
            mazePictureBox.Invalidate();
        }

        private void solvingBackgroundWorker_DoWork(object sender, DoWorkEventArgs e) {
            solving.SolveMaze(maze);
        }

        private void showDistanceCheckBox_CheckedChanged(object sender, EventArgs e) {
            Global.showDistance = showDistanceCheckBox.Checked;

            mazePictureBox.Invalidate();
        }

        private void generateMazeButton_Click(object sender, EventArgs e) {
            if (generation is BinaryRecursiveMazeGeneration) {
                if (!validDimensions.Contains(maze.width) || !validDimensions.Contains(maze.height)) {
                    DialogResult result = MessageBox.Show("Width or height are not valid numbers for Binary Recursive Generation. Please only use [9, 17, 33, 65, 129, 257, 513]. Want to use the nearest number(s) instead of the given one?", "Incorrect Width/Height", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.Cancel)
                        return;
                    else {
                        int tempWidth, tempHeight;
                        tempWidth = tempHeight = int.MaxValue;
                        foreach (int i in validDimensions) {
                            if (Math.Abs(i - maze.width) < Math.Abs(tempWidth - maze.width))
                                tempWidth = i;

                            if (Math.Abs(i - maze.height) < Math.Abs(tempHeight - maze.height))
                                tempHeight = i;
                        }
                        mazeWidthNumeric.Value = tempWidth;
                        mazeHeightNumeric.Value = tempHeight;
                        Node start = maze.startNode;
                        maze = new Maze(tempWidth, tempHeight);
                        maze.MoveStartNode(start.x, start.y);
                    }
                }
            }
            Console.WriteLine(maze.startNode);

            solveMazeButton.Enabled = createMazeButton.Enabled = generateMazeButton.Enabled = resetMazeButton.Enabled = false;

            nextStepButton.Enabled = true;

            generationBackgroundWorker.RunWorkerAsync();

            mazePictureBox.Invalidate();
        }

        private void algorithmsComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            switch (solvingAlgorithmsComboBox.SelectedIndex) {
                case 0:
                    solving = new DepthSolvingAlgorithm();
                    break;
                case 1:
                    solving = new BreadthSolvingAlgorithm();
                    break;
                case 2:
                    solving = new EarlyExitSolvingAlgorithm();
                    break;
                case 3:
                    solving = new WallRunnerSolvingAlgorithm();
                    break;
                case 4:
                    solving = new AStarSolvingAlgorithm();
                    break;
                case 5:
                    solving = new AStarEarlyExitSolvingAlgorithm();
                    break;
            }
        }

        private void solvingBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            generateMazeButton.Enabled = createMazeButton.Enabled = resetMazeButton.Enabled = true;

            nextStepButton.Enabled = false;
        }

        private void generationBackgroundWorker_DoWork(object sender, DoWorkEventArgs e) {
            generation.GenerateMaze(maze);
        }

        private void timerIntervalNumeric_ValueChanged(object sender, EventArgs e) {
            if (timerIntervalNumeric.Value == 0) {
                Global.noDelay = true;
            } else {
                Global.noDelay = false;
                mainTimer.Interval = (int)timerIntervalNumeric.Value;
            }
        }

        private void mazeSizeNumeric_ValueChanged(object sender, EventArgs e) {
            Global.mazeSize = (int)mazeSizeNumeric.Value;

            mazePictureBox.Invalidate();
        }

        private void generationAlgorithmComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            switch (generationAlgorithmComboBox.SelectedIndex) {
                case 0:
                    generation = new BinaryRecursiveMazeGeneration();
                    break;
                case 1:
                    generation = new OddRecursiveMazeGeneration();
                    break;
                case 2:
                    generation = new PrimsMazeGeneration();
                    break;
            }
        }

        private void pauseCheckBox_CheckedChanged(object sender, EventArgs e) {
            if (pauseCheckBox.Checked)
                mainTimer.Stop();
            else
                mainTimer.Start();
        }

        private void mazeWidthNumeric_ValueChanged(object sender, EventArgs e) {
            if (mazeWidthNumeric.Value % 2 == 0)
                if (mazeWidthNumeric.Value > mazeWidthNumeric.Maximum)
                    mazeWidthNumeric.Value = mazeWidthNumeric.Maximum;
                else
                    mazeWidthNumeric.Value++;
        }

        private void mazeHeightNumeric_ValueChanged(object sender, EventArgs e) {
            if (mazeHeightNumeric.Value % 2 == 0)
                if (mazeHeightNumeric.Value > mazeHeightNumeric.Maximum)
                    mazeHeightNumeric.Value = mazeWidthNumeric.Maximum;
                else
                    mazeHeightNumeric.Value++;
        }

        private void createMazeButton_Click(object sender, EventArgs e) {
            maze = new Maze((int)mazeWidthNumeric.Value, (int)mazeHeightNumeric.Value);

            int width = maze.width * Global.mazeSize;
            int height = maze.height * Global.mazeSize;

            mazePictureBox.Width = width > mazePanel.Width ? width : mazePanel.Width;
            mazePictureBox.Height = height > mazePanel.Height ? height : mazePanel.Height;

            nextStepButton.Enabled = resetMazeButton.Enabled = exportMazeImageButton.Enabled = false;
        }

        private void generationBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            solveMazeButton.Enabled = createMazeButton.Enabled = generateMazeButton.Enabled = exportMazeImageButton.Enabled = true;

            nextStepButton.Enabled = false;
        }

        private void noDelayCheckbox_CheckedChanged(object sender, EventArgs e) {
            Global.noDelay = noDelayCheckbox.Checked;
        }

        private void nextStepButton_Click(object sender, EventArgs e) {
            doStep = true;

            mazePictureBox.Invalidate();
        }

        private void resetMazeButton_Click(object sender, EventArgs e) {
            maze.ResetMaze();

            solveMazeButton.Enabled = true;

            resetMazeButton.Enabled = false;
        }

        private void exportMazeImageButton_Click(object sender, EventArgs e) {
            IO.SaveMaze(maze);
        }

        private void mazePictureBox_MouseDown(object sender, MouseEventArgs e) {
            mouseDown = e.Location;
        }

        private void mazePictureBox_MouseUp(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left)
                maze.ToggleNode(mouseDown.X / Global.mazeSize, mouseDown.Y / Global.mazeSize, e.Location.X / Global.mazeSize, e.Location.Y / Global.mazeSize);
            else if (e.Button == MouseButtons.Right)
                maze.MoveStartNode(e.Location.X / Global.mazeSize, e.Location.Y / Global.mazeSize);

            mazePictureBox.Invalidate();
        }
    }
}
