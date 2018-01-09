namespace MazeSolvingAlgoritm {
    partial class MazeSolver {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.mazePictureBox = new System.Windows.Forms.PictureBox();
            this.solveMazeButton = new System.Windows.Forms.Button();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.solvingBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.showDistanceCheckBox = new System.Windows.Forms.CheckBox();
            this.generateMazeButton = new System.Windows.Forms.Button();
            this.solvingAlgorithmsComboBox = new System.Windows.Forms.ComboBox();
            this.generationBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.timerIntervalNumeric = new System.Windows.Forms.NumericUpDown();
            this.mazeSizeNumeric = new System.Windows.Forms.NumericUpDown();
            this.generationAlgorithmComboBox = new System.Windows.Forms.ComboBox();
            this.pauseCheckBox = new System.Windows.Forms.CheckBox();
            this.generationLabel = new System.Windows.Forms.Label();
            this.solvingLabel = new System.Windows.Forms.Label();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.mazeSizeLabel = new System.Windows.Forms.Label();
            this.mazePanel = new System.Windows.Forms.Panel();
            this.mazeWidthLabel = new System.Windows.Forms.Label();
            this.mazeWidthNumeric = new System.Windows.Forms.NumericUpDown();
            this.mazeHeightLabel = new System.Windows.Forms.Label();
            this.mazeHeightNumeric = new System.Windows.Forms.NumericUpDown();
            this.createMazeButton = new System.Windows.Forms.Button();
            this.noDelayCheckbox = new System.Windows.Forms.CheckBox();
            this.nextStepButton = new System.Windows.Forms.Button();
            this.newMazePanel = new System.Windows.Forms.Panel();
            this.numericOptionsPanel = new System.Windows.Forms.Panel();
            this.algorithmSelectionPanel = new System.Windows.Forms.Panel();
            this.checkboxPanel = new System.Windows.Forms.Panel();
            this.mazeButtonsPanel = new System.Windows.Forms.Panel();
            this.resetMazeButton = new System.Windows.Forms.Button();
            this.exportMazeImageButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mazePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerIntervalNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mazeSizeNumeric)).BeginInit();
            this.mazePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mazeWidthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mazeHeightNumeric)).BeginInit();
            this.newMazePanel.SuspendLayout();
            this.numericOptionsPanel.SuspendLayout();
            this.algorithmSelectionPanel.SuspendLayout();
            this.checkboxPanel.SuspendLayout();
            this.mazeButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mazePictureBox
            // 
            this.mazePictureBox.BackColor = System.Drawing.Color.White;
            this.mazePictureBox.Location = new System.Drawing.Point(0, 0);
            this.mazePictureBox.Name = "mazePictureBox";
            this.mazePictureBox.Size = new System.Drawing.Size(1033, 536);
            this.mazePictureBox.TabIndex = 0;
            this.mazePictureBox.TabStop = false;
            this.mazePictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.mazePictureBox_Paint);
            this.mazePictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mazePictureBox_MouseDown);
            this.mazePictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mazePictureBox_MouseUp);
            // 
            // solveMazeButton
            // 
            this.solveMazeButton.Enabled = false;
            this.solveMazeButton.Location = new System.Drawing.Point(3, 29);
            this.solveMazeButton.Name = "solveMazeButton";
            this.solveMazeButton.Size = new System.Drawing.Size(75, 23);
            this.solveMazeButton.TabIndex = 1;
            this.solveMazeButton.Text = "Solve Maze";
            this.solveMazeButton.UseVisualStyleBackColor = true;
            this.solveMazeButton.Click += new System.EventHandler(this.solveMazeButton_click);
            // 
            // mainTimer
            // 
            this.mainTimer.Enabled = true;
            this.mainTimer.Interval = 1;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // solvingBackgroundWorker
            // 
            this.solvingBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.solvingBackgroundWorker_DoWork);
            this.solvingBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.solvingBackgroundWorker_RunWorkerCompleted);
            // 
            // showDistanceCheckBox
            // 
            this.showDistanceCheckBox.AutoSize = true;
            this.showDistanceCheckBox.Location = new System.Drawing.Point(3, 0);
            this.showDistanceCheckBox.Name = "showDistanceCheckBox";
            this.showDistanceCheckBox.Size = new System.Drawing.Size(98, 17);
            this.showDistanceCheckBox.TabIndex = 2;
            this.showDistanceCheckBox.Text = "Show Distance";
            this.showDistanceCheckBox.UseVisualStyleBackColor = true;
            this.showDistanceCheckBox.CheckedChanged += new System.EventHandler(this.showDistanceCheckBox_CheckedChanged);
            // 
            // generateMazeButton
            // 
            this.generateMazeButton.Location = new System.Drawing.Point(3, 0);
            this.generateMazeButton.Name = "generateMazeButton";
            this.generateMazeButton.Size = new System.Drawing.Size(75, 23);
            this.generateMazeButton.TabIndex = 3;
            this.generateMazeButton.Text = "Generate Maze";
            this.generateMazeButton.UseVisualStyleBackColor = true;
            this.generateMazeButton.Click += new System.EventHandler(this.generateMazeButton_Click);
            // 
            // solvingAlgorithmsComboBox
            // 
            this.solvingAlgorithmsComboBox.FormattingEnabled = true;
            this.solvingAlgorithmsComboBox.Location = new System.Drawing.Point(5, 60);
            this.solvingAlgorithmsComboBox.Name = "solvingAlgorithmsComboBox";
            this.solvingAlgorithmsComboBox.Size = new System.Drawing.Size(119, 21);
            this.solvingAlgorithmsComboBox.TabIndex = 4;
            this.solvingAlgorithmsComboBox.SelectedIndexChanged += new System.EventHandler(this.algorithmsComboBox_SelectedIndexChanged);
            // 
            // generationBackgroundWorker
            // 
            this.generationBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.generationBackgroundWorker_DoWork);
            this.generationBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.generationBackgroundWorker_RunWorkerCompleted);
            // 
            // timerIntervalNumeric
            // 
            this.timerIntervalNumeric.Location = new System.Drawing.Point(72, 3);
            this.timerIntervalNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.timerIntervalNumeric.Name = "timerIntervalNumeric";
            this.timerIntervalNumeric.Size = new System.Drawing.Size(52, 20);
            this.timerIntervalNumeric.TabIndex = 5;
            this.timerIntervalNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timerIntervalNumeric.ValueChanged += new System.EventHandler(this.timerIntervalNumeric_ValueChanged);
            // 
            // mazeSizeNumeric
            // 
            this.mazeSizeNumeric.Location = new System.Drawing.Point(88, 30);
            this.mazeSizeNumeric.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.mazeSizeNumeric.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.mazeSizeNumeric.Name = "mazeSizeNumeric";
            this.mazeSizeNumeric.Size = new System.Drawing.Size(36, 20);
            this.mazeSizeNumeric.TabIndex = 6;
            this.mazeSizeNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.mazeSizeNumeric.ValueChanged += new System.EventHandler(this.mazeSizeNumeric_ValueChanged);
            // 
            // generationAlgorithmComboBox
            // 
            this.generationAlgorithmComboBox.FormattingEnabled = true;
            this.generationAlgorithmComboBox.Location = new System.Drawing.Point(5, 16);
            this.generationAlgorithmComboBox.Name = "generationAlgorithmComboBox";
            this.generationAlgorithmComboBox.Size = new System.Drawing.Size(119, 21);
            this.generationAlgorithmComboBox.TabIndex = 7;
            this.generationAlgorithmComboBox.SelectedIndexChanged += new System.EventHandler(this.generationAlgorithmComboBox_SelectedIndexChanged);
            // 
            // pauseCheckBox
            // 
            this.pauseCheckBox.AutoSize = true;
            this.pauseCheckBox.Location = new System.Drawing.Point(3, 23);
            this.pauseCheckBox.Name = "pauseCheckBox";
            this.pauseCheckBox.Size = new System.Drawing.Size(56, 17);
            this.pauseCheckBox.TabIndex = 8;
            this.pauseCheckBox.Text = "Pause";
            this.pauseCheckBox.UseVisualStyleBackColor = true;
            this.pauseCheckBox.CheckedChanged += new System.EventHandler(this.pauseCheckBox_CheckedChanged);
            // 
            // generationLabel
            // 
            this.generationLabel.AutoSize = true;
            this.generationLabel.Location = new System.Drawing.Point(13, 0);
            this.generationLabel.Name = "generationLabel";
            this.generationLabel.Size = new System.Drawing.Size(98, 13);
            this.generationLabel.TabIndex = 9;
            this.generationLabel.Text = "Generation Method";
            // 
            // solvingLabel
            // 
            this.solvingLabel.AutoSize = true;
            this.solvingLabel.Location = new System.Drawing.Point(16, 44);
            this.solvingLabel.Name = "solvingLabel";
            this.solvingLabel.Size = new System.Drawing.Size(81, 13);
            this.solvingLabel.TabIndex = 10;
            this.solvingLabel.Text = "Solving Method";
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.Location = new System.Drawing.Point(4, 5);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(64, 13);
            this.intervalLabel.TabIndex = 11;
            this.intervalLabel.Text = "Interval (ms)";
            // 
            // mazeSizeLabel
            // 
            this.mazeSizeLabel.AutoSize = true;
            this.mazeSizeLabel.Location = new System.Drawing.Point(4, 32);
            this.mazeSizeLabel.Name = "mazeSizeLabel";
            this.mazeSizeLabel.Size = new System.Drawing.Size(76, 13);
            this.mazeSizeLabel.TabIndex = 12;
            this.mazeSizeLabel.Text = "Maze Size (px)";
            // 
            // mazePanel
            // 
            this.mazePanel.AutoScroll = true;
            this.mazePanel.Controls.Add(this.mazePictureBox);
            this.mazePanel.Location = new System.Drawing.Point(12, 12);
            this.mazePanel.Name = "mazePanel";
            this.mazePanel.Size = new System.Drawing.Size(1033, 536);
            this.mazePanel.TabIndex = 13;
            // 
            // mazeWidthLabel
            // 
            this.mazeWidthLabel.AutoSize = true;
            this.mazeWidthLabel.Location = new System.Drawing.Point(3, 4);
            this.mazeWidthLabel.Name = "mazeWidthLabel";
            this.mazeWidthLabel.Size = new System.Drawing.Size(104, 13);
            this.mazeWidthLabel.TabIndex = 14;
            this.mazeWidthLabel.Text = "Maze Width (Nodes)";
            // 
            // mazeWidthNumeric
            // 
            this.mazeWidthNumeric.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.mazeWidthNumeric.Location = new System.Drawing.Point(4, 20);
            this.mazeWidthNumeric.Maximum = new decimal(new int[] {
            513,
            0,
            0,
            0});
            this.mazeWidthNumeric.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.mazeWidthNumeric.Name = "mazeWidthNumeric";
            this.mazeWidthNumeric.Size = new System.Drawing.Size(120, 20);
            this.mazeWidthNumeric.TabIndex = 15;
            this.mazeWidthNumeric.Value = new decimal(new int[] {
            33,
            0,
            0,
            0});
            this.mazeWidthNumeric.ValueChanged += new System.EventHandler(this.mazeWidthNumeric_ValueChanged);
            // 
            // mazeHeightLabel
            // 
            this.mazeHeightLabel.AutoSize = true;
            this.mazeHeightLabel.Location = new System.Drawing.Point(3, 43);
            this.mazeHeightLabel.Name = "mazeHeightLabel";
            this.mazeHeightLabel.Size = new System.Drawing.Size(107, 13);
            this.mazeHeightLabel.TabIndex = 16;
            this.mazeHeightLabel.Text = "Maze Height (Nodes)";
            // 
            // mazeHeightNumeric
            // 
            this.mazeHeightNumeric.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.mazeHeightNumeric.Location = new System.Drawing.Point(4, 59);
            this.mazeHeightNumeric.Maximum = new decimal(new int[] {
            513,
            0,
            0,
            0});
            this.mazeHeightNumeric.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.mazeHeightNumeric.Name = "mazeHeightNumeric";
            this.mazeHeightNumeric.Size = new System.Drawing.Size(120, 20);
            this.mazeHeightNumeric.TabIndex = 17;
            this.mazeHeightNumeric.Value = new decimal(new int[] {
            33,
            0,
            0,
            0});
            this.mazeHeightNumeric.ValueChanged += new System.EventHandler(this.mazeHeightNumeric_ValueChanged);
            // 
            // createMazeButton
            // 
            this.createMazeButton.Location = new System.Drawing.Point(6, 86);
            this.createMazeButton.Name = "createMazeButton";
            this.createMazeButton.Size = new System.Drawing.Size(110, 23);
            this.createMazeButton.TabIndex = 18;
            this.createMazeButton.Text = "Create New Maze";
            this.createMazeButton.UseVisualStyleBackColor = true;
            this.createMazeButton.Click += new System.EventHandler(this.createMazeButton_Click);
            // 
            // noDelayCheckbox
            // 
            this.noDelayCheckbox.AutoSize = true;
            this.noDelayCheckbox.Location = new System.Drawing.Point(3, 46);
            this.noDelayCheckbox.Name = "noDelayCheckbox";
            this.noDelayCheckbox.Size = new System.Drawing.Size(70, 17);
            this.noDelayCheckbox.TabIndex = 19;
            this.noDelayCheckbox.Text = "No Delay";
            this.noDelayCheckbox.UseVisualStyleBackColor = true;
            this.noDelayCheckbox.CheckedChanged += new System.EventHandler(this.noDelayCheckbox_CheckedChanged);
            // 
            // nextStepButton
            // 
            this.nextStepButton.Enabled = false;
            this.nextStepButton.Location = new System.Drawing.Point(1070, 466);
            this.nextStepButton.Name = "nextStepButton";
            this.nextStepButton.Size = new System.Drawing.Size(75, 23);
            this.nextStepButton.TabIndex = 20;
            this.nextStepButton.Text = "Next Step";
            this.nextStepButton.UseVisualStyleBackColor = true;
            this.nextStepButton.Click += new System.EventHandler(this.nextStepButton_Click);
            // 
            // newMazePanel
            // 
            this.newMazePanel.Controls.Add(this.mazeWidthLabel);
            this.newMazePanel.Controls.Add(this.mazeWidthNumeric);
            this.newMazePanel.Controls.Add(this.createMazeButton);
            this.newMazePanel.Controls.Add(this.mazeHeightLabel);
            this.newMazePanel.Controls.Add(this.mazeHeightNumeric);
            this.newMazePanel.Location = new System.Drawing.Point(1048, 341);
            this.newMazePanel.Name = "newMazePanel";
            this.newMazePanel.Size = new System.Drawing.Size(128, 114);
            this.newMazePanel.TabIndex = 1;
            // 
            // numericOptionsPanel
            // 
            this.numericOptionsPanel.Controls.Add(this.intervalLabel);
            this.numericOptionsPanel.Controls.Add(this.timerIntervalNumeric);
            this.numericOptionsPanel.Controls.Add(this.mazeSizeNumeric);
            this.numericOptionsPanel.Controls.Add(this.mazeSizeLabel);
            this.numericOptionsPanel.Location = new System.Drawing.Point(1048, 273);
            this.numericOptionsPanel.Name = "numericOptionsPanel";
            this.numericOptionsPanel.Size = new System.Drawing.Size(130, 56);
            this.numericOptionsPanel.TabIndex = 1;
            // 
            // algorithmSelectionPanel
            // 
            this.algorithmSelectionPanel.Controls.Add(this.generationLabel);
            this.algorithmSelectionPanel.Controls.Add(this.solvingAlgorithmsComboBox);
            this.algorithmSelectionPanel.Controls.Add(this.generationAlgorithmComboBox);
            this.algorithmSelectionPanel.Controls.Add(this.solvingLabel);
            this.algorithmSelectionPanel.Location = new System.Drawing.Point(1048, 178);
            this.algorithmSelectionPanel.Name = "algorithmSelectionPanel";
            this.algorithmSelectionPanel.Size = new System.Drawing.Size(132, 89);
            this.algorithmSelectionPanel.TabIndex = 1;
            // 
            // checkboxPanel
            // 
            this.checkboxPanel.Controls.Add(this.pauseCheckBox);
            this.checkboxPanel.Controls.Add(this.showDistanceCheckBox);
            this.checkboxPanel.Controls.Add(this.noDelayCheckbox);
            this.checkboxPanel.Location = new System.Drawing.Point(1057, 109);
            this.checkboxPanel.Name = "checkboxPanel";
            this.checkboxPanel.Size = new System.Drawing.Size(101, 63);
            this.checkboxPanel.TabIndex = 1;
            // 
            // mazeButtonsPanel
            // 
            this.mazeButtonsPanel.Controls.Add(this.resetMazeButton);
            this.mazeButtonsPanel.Controls.Add(this.generateMazeButton);
            this.mazeButtonsPanel.Controls.Add(this.solveMazeButton);
            this.mazeButtonsPanel.Location = new System.Drawing.Point(1067, 12);
            this.mazeButtonsPanel.Name = "mazeButtonsPanel";
            this.mazeButtonsPanel.Size = new System.Drawing.Size(82, 91);
            this.mazeButtonsPanel.TabIndex = 1;
            // 
            // resetMazeButton
            // 
            this.resetMazeButton.Enabled = false;
            this.resetMazeButton.Location = new System.Drawing.Point(4, 59);
            this.resetMazeButton.Name = "resetMazeButton";
            this.resetMazeButton.Size = new System.Drawing.Size(75, 23);
            this.resetMazeButton.TabIndex = 4;
            this.resetMazeButton.Text = "Reset Maze";
            this.resetMazeButton.UseVisualStyleBackColor = true;
            this.resetMazeButton.Click += new System.EventHandler(this.resetMazeButton_Click);
            // 
            // exportMazeImageButton
            // 
            this.exportMazeImageButton.Enabled = false;
            this.exportMazeImageButton.Location = new System.Drawing.Point(1071, 505);
            this.exportMazeImageButton.Name = "exportMazeImageButton";
            this.exportMazeImageButton.Size = new System.Drawing.Size(75, 23);
            this.exportMazeImageButton.TabIndex = 21;
            this.exportMazeImageButton.Text = "Export Maze";
            this.exportMazeImageButton.UseVisualStyleBackColor = true;
            this.exportMazeImageButton.Click += new System.EventHandler(this.exportMazeImageButton_Click);
            // 
            // MazeSolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.exportMazeImageButton);
            this.Controls.Add(this.mazeButtonsPanel);
            this.Controls.Add(this.checkboxPanel);
            this.Controls.Add(this.algorithmSelectionPanel);
            this.Controls.Add(this.numericOptionsPanel);
            this.Controls.Add(this.newMazePanel);
            this.Controls.Add(this.nextStepButton);
            this.Controls.Add(this.mazePanel);
            this.Name = "MazeSolver";
            this.Text = "Maze Solver";
            ((System.ComponentModel.ISupportInitialize)(this.mazePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerIntervalNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mazeSizeNumeric)).EndInit();
            this.mazePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mazeWidthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mazeHeightNumeric)).EndInit();
            this.newMazePanel.ResumeLayout(false);
            this.newMazePanel.PerformLayout();
            this.numericOptionsPanel.ResumeLayout(false);
            this.numericOptionsPanel.PerformLayout();
            this.algorithmSelectionPanel.ResumeLayout(false);
            this.algorithmSelectionPanel.PerformLayout();
            this.checkboxPanel.ResumeLayout(false);
            this.checkboxPanel.PerformLayout();
            this.mazeButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox mazePictureBox;
        private System.Windows.Forms.Button solveMazeButton;
        private System.Windows.Forms.Timer mainTimer;
        private System.ComponentModel.BackgroundWorker solvingBackgroundWorker;
        private System.Windows.Forms.CheckBox showDistanceCheckBox;
        private System.Windows.Forms.Button generateMazeButton;
        private System.Windows.Forms.ComboBox solvingAlgorithmsComboBox;
        private System.ComponentModel.BackgroundWorker generationBackgroundWorker;
        private System.Windows.Forms.NumericUpDown timerIntervalNumeric;
        private System.Windows.Forms.NumericUpDown mazeSizeNumeric;
        private System.Windows.Forms.ComboBox generationAlgorithmComboBox;
        private System.Windows.Forms.CheckBox pauseCheckBox;
        private System.Windows.Forms.Label generationLabel;
        private System.Windows.Forms.Label solvingLabel;
        private System.Windows.Forms.Label intervalLabel;
        private System.Windows.Forms.Label mazeSizeLabel;
        private System.Windows.Forms.Panel mazePanel;
        private System.Windows.Forms.Label mazeWidthLabel;
        private System.Windows.Forms.NumericUpDown mazeWidthNumeric;
        private System.Windows.Forms.Label mazeHeightLabel;
        private System.Windows.Forms.NumericUpDown mazeHeightNumeric;
        private System.Windows.Forms.Button createMazeButton;
        private System.Windows.Forms.CheckBox noDelayCheckbox;
        private System.Windows.Forms.Button nextStepButton;
        private System.Windows.Forms.Panel newMazePanel;
        private System.Windows.Forms.Panel numericOptionsPanel;
        private System.Windows.Forms.Panel algorithmSelectionPanel;
        private System.Windows.Forms.Panel checkboxPanel;
        private System.Windows.Forms.Panel mazeButtonsPanel;
        private System.Windows.Forms.Button resetMazeButton;
        private System.Windows.Forms.Button exportMazeImageButton;
    }
}

