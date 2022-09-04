using System;
using System.Drawing;

namespace GameOfLife
{
    public class Cell
    {
        private Point cLocation;
        private Rectangle cCellDisplay;
        private Size cCellSize;
        private int cXPos;
        private int cYPos;
        private Boolean cIsAlive;
        private Boolean cNext;

        public Cell(int CellSize)
        {
            Grid.gridCells.Add(this);
            this.CellSize = new Size(CellSize, CellSize);
        }
        public Cell(Point location, int X, int Y)
        {
            int cellSize;
            Location = location;
            YPos = Y;
            XPos = X;
            Grid.gridCells.Add(this);
            cellSize = (X == 0) ? 0 : location.X / X;
        }

        public Cell(int X, int Y, int CellSize)
        {
            Location = new Point(X * CellSize, Y * CellSize);
            XPos = X;
            YPos = Y;
            this.CellSize = new Size(CellSize, CellSize);
            Grid.gridCells.Add(this);
        }

        public Rectangle CellDisplay
        {
            get { return cCellDisplay; }
            set { cCellDisplay = value; }
        }

        public Size CellSize
        {
            get { return cCellSize; }
            set
            {
                cCellSize = value;
                CellDisplay = new Rectangle(Location, new Size(value.Width - 1, value.Height - 1));
            }
        }

        public Point Location
        {
            get { return cLocation; }
            set { cLocation = value; }
        }

        public int XPos
        {
            get { return cXPos; }
            set { cXPos = value; }
        }

        public int YPos
        {
            get { return cYPos; }
            set { cYPos = value; }
        }

        public Boolean IsAlive
        {
            get { return cIsAlive; }
            set { cIsAlive = value; }
        }

        public Boolean NextStatus
        {
            get { return cNext; }
            set { cNext = value; }
        }

        public override string ToString()
        {
            return $"GridX:{XPos}  GridY:{YPos}  Alive:{IsAlive}  Next:{NextStatus}";
        }



    }
}
