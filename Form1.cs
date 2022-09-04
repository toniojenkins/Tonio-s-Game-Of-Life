﻿using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class TonioLife : Form
    {

        Boolean InProgress;
        Grid CellGrid;

        public TonioLife()
        {
            InitializeComponent();
        }

        private void ConwayMain_Load(object sender, EventArgs e)
        {
            createGrid(true);
        }

        private void createGrid(bool RandomCells)
        {
            Cell newCell;
            Random random = new Random();

            int rows = (int)(picGrid.Height / cellSize.Value);
            int cols = (int)(picGrid.Width / cellSize.Value);

            CellGrid = new Grid(rows, cols);

            Grid.gridCells.Clear();

            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < cols; x++)
                {
                    newCell = new Cell(x, y, (int)cellSize.Value);
                    if (RandomCells)
                        newCell.IsAlive = (random.Next(100) < 15) ? true : false;
                    else
                        newCell.IsAlive = false;
                }
            }

            Grid.gridCells = Grid.gridCells.OrderBy(c => c.XPos).OrderBy(c => c.YPos).ToList();

            updateGrid(CellGrid);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            createGrid(true);
        }

        private void GetNextState()
        {
            //Method to calculate next positions of cells and update the grid.
            /*
            1.Any live cell with fewer than two live neighbours dies, 
            as if by underpopulation.
            2.Any live cell with two or three live neighbours lives on 
            to the next generation.
            3.Any live cell with more than three live neighbours dies, 
            as if by overpopulation.
            4. Any dead cell with exactly three live neighbours becomes a live cell, 
            as if by reproduction.
            */

            // Calculate next status of each cell.
            foreach (Cell cell in Grid.gridCells)
            {
                int activeCount = CellGrid.LiveAdjacent(cell);

                if (cell.IsAlive)
                {
                    if ((activeCount < 2) || (activeCount > 3))
                        cell.NextStatus = false;
                    else
                        cell.NextStatus = true;
                }
                else
                {
                    if (activeCount == 3)
                        cell.NextStatus = true;
                }

            }

            foreach (Cell cell in Grid.gridCells)
            {
                cell.IsAlive = cell.NextStatus;
            }

            updateGrid(CellGrid);


        }

        private void updateGrid(Grid GridDisplay)
        {
            Random random = new Random();

            using (Bitmap bmp = new Bitmap(picGrid.Width, picGrid.Height))
            using (Graphics g = Graphics.FromImage(bmp))
            using (SolidBrush cellBrush = new SolidBrush(Color.LightBlue))
            {
                g.Clear(Color.Black);

                foreach (Cell cell in Grid.gridCells)
                {
                    if (cell.IsAlive)
                    {
                        g.FillRectangle(cellBrush, cell.CellDisplay);
                    }
                }

                if (picGrid.Image != null)
                    picGrid.Image.Dispose();  

                picGrid.Image = (Bitmap)bmp.Clone();
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void Start()
        {
            InProgress = !InProgress;

            startBtn.Text = InProgress ? "Stop" : "Start";
            startBtnClick.Text = InProgress ? "Stop" : "Start";

            while (InProgress)
            {
                GetNextState();
                Application.DoEvents();
            }
        }

        private void tonio_Closing(object sender, FormClosingEventArgs e)
        {
            InProgress = false;
            Application.Exit();

        }

        private void grid_mouseClick(object sender, MouseEventArgs e)
        {
            int CellIndex;
            Size cellSize = Grid.gridCells[0].CellSize;

            int XLoc = e.X / cellSize.Width;
            int YLoc = e.Y / cellSize.Height;

            CellIndex = (YLoc * CellGrid.Columns) + XLoc;

            Grid.gridCells[CellIndex].IsAlive = !Grid.gridCells[CellIndex].IsAlive;

            updateGrid(CellGrid);
        }

        private void clear_btnClick(object sender, EventArgs e)
        {
            createGrid(false);
        }

        private void resetGrid_tool(object sender, EventArgs e)
        {
            createGrid(true);

        }

        private void clearGrid_Click(object sender, EventArgs e)
        {
            createGrid(false);

        }

        private void startTool_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void exitTool_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loadPattern_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog fdOpen = new OpenFileDialog())
                {
                    fdOpen.Title = "Select location of file.";
                    fdOpen.Filter = "gam files (*.gam)|*.gam|All files (*.*)|*.*";

                    if (fdOpen.ShowDialog() == DialogResult.OK)
                    {
                        CellGrid.LoadGrid(fdOpen.FileName, picGrid.Size);
                    }
                }

                updateGrid(CellGrid);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem loading the specified file.\n" + ex.Message);
            }

        }

        private void savePattern_Click(object sender, EventArgs e)
        {

            try
            {
                using (SaveFileDialog fdSave = new SaveFileDialog())
                {
                    fdSave.Title = "Select location for save file.";
                    fdSave.Filter = "gam files (*.gam)|*.gam|All files (*.*)|*.*";

                    if (fdSave.ShowDialog() == DialogResult.OK)
                    {
                        CellGrid.SaveGrid(fdSave.FileName);
                    }
                    MessageBox.Show("File saved.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem saving the specified pattern.\n" + ex.Message);
            }

        }
    }
}