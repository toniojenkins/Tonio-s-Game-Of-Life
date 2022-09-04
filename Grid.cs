using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;

namespace GameOfLife
{
    public class Grid
    {
        public static List<Cell> gridCells = new List<Cell>();

        private int cRows;
        private int cCols;

        public Grid(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
        }

        public int Rows
        {
            get { return cRows; }
            set { cRows = value; }
        }

        public int Columns
        {
            get { return cCols; }
            set { cCols = value; }
        }

        public int LiveAdjacent(Cell cell)
        {

            int liveAdjacent = 0;

            int cellIndex = (cell.YPos * Columns) + cell.XPos;
            int startIndex = cellIndex - Columns - 2;
            int endIndex = cellIndex + Columns + 2;

            startIndex = (startIndex < 0) ? 0 : startIndex;
            endIndex = (endIndex > (Grid.gridCells.Count - 1)) ? Grid.gridCells.Count - 1 : endIndex;

            for (int x = startIndex; x < endIndex; x++)
            {
                if (Math.Abs(cell.XPos - gridCells[x].XPos) < 2 && Math.Abs(cell.YPos - gridCells[x].YPos) < 2)
                {
                    if (Grid.gridCells[x].Location != cell.Location)
                    {
                        if (gridCells[x].IsAlive)
                        {
                            liveAdjacent++;
                        }
                    }
                }
            }

            return liveAdjacent;
        }

        public void LoadGrid(string filePath, Size displaySize)
        {
            string lineText;
            string startText = "", gridString = "";
            int cellSize = 10, rows, cols, maxSize, cellCount;
            Cell newCell;

            try
            {
                gridCells.Clear();

                using (StreamReader loadFile = new StreamReader(filePath))
                {
                    while (!loadFile.EndOfStream)
                    {
                        lineText = loadFile.ReadLine();

                        if (lineText != null)
                        {
                            startText = lineText.Substring(0, 1);

                            if (lineText.Substring(0, 4) == "Cell")
                            {
                                int.TryParse(lineText.Substring(lineText.IndexOf(":") + 1), out int result);
                                cellSize = result;
                            }
                            else if (startText == "0" || startText == "1")
                            {
                                gridString += lineText;
                            }
                        }
                    }
                }

                maxSize = (int)Math.Sqrt((displaySize.Width * displaySize.Height) / gridString.Length);
                maxSize = maxSize > 25 ? 25 : maxSize;
                cellSize = (maxSize < cellSize) ? maxSize : cellSize;

                rows = displaySize.Height / cellSize;
                cols = displaySize.Width / cellSize;

                Rows = rows;
                Columns = cols;

                cellCount = 0;
                for (int y = 0; y < rows; y++)
                {
                    for (int x = 0; x < cols; x++)
                    {
                        newCell = new Cell(x, y, cellSize);

                        if (cellCount < gridString.Length)
                            newCell.IsAlive = (gridString[cellCount]) == '1' ? true : false;
                        else
                            newCell.IsAlive = false;

                        cellCount++;
                    }
                }

                Grid.gridCells = Grid.gridCells.OrderBy(c => c.XPos).OrderBy(c => c.YPos).ToList();
            }
            catch (Exception)
            {
                throw;
            }


        }

        public void SaveGrid(string filePath)
        {
            string rowString = "";
            int cellIndex = 0;

            try
            {
                using (StreamWriter saveFile = new StreamWriter(filePath))
                {
                    saveFile.WriteLine($"Cell size: {gridCells[0].CellSize.Width.ToString()} ");
                    saveFile.WriteLine("-- BEGIN GRID --");
                    for (int y = 0; y < Rows; y++)
                    {
                        for (int x = 0; x < Columns; x++)
                        {
                            rowString += gridCells[cellIndex].IsAlive ? "1" : "0";
                            cellIndex++;
                        }
                        saveFile.WriteLine(rowString);
                        rowString = "";
                    }
                    saveFile.WriteLine("-- END GRID --");
                    saveFile.Flush();
                    saveFile.Close();

                }
            }
            catch (Exception)
            {
                throw;
            }

        }

    }
}
