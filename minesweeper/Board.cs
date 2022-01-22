using System;
using System.Collections.Generic;
using System.Text;

namespace minesweeper
{
    public class Board
    {
        #region data members
        private Square[,] squareBoard; //status,isbomb,neighbours      
        private readonly int rows, columns;
        private readonly int numBombs;       
        #endregion

        #region properties
        public Square this[int x,int y]
        {
            get {return SquareBoard[x,y] ;}
            set {SquareBoard[x, y]=value; }
        }
        public Square[,] SquareBoard
        {
            get { return squareBoard; }
            set { squareBoard = value; }
        }
        public int Columns
        {
            get { return columns; }            
        }
        public int Rows
        {
            get { return rows; }           
        }
        public int NumBombs
        {
            get { return numBombs; }
        } 
        #endregion

        #region constractors
        public Board(int rows, int columns, int numBombs)///מקצה לוח לוגי ומאתחל אותו
        {            
            this.rows = rows;
            this.columns = columns;
            SquareBoard = new Square[Rows, Columns];
            this.numBombs = numBombs;
            for (int i = 0, j; i < Rows; i++)
                for (j = 0; j < Columns; j++)
                    SquareBoard[i, j] = new Square();
            SetBombs();            
        }
        #endregion

        #region functions
        private void SetBombs()//assign randomal bombs and init the neibors around them
        {
            int i, j;
            Random r = new Random();
            for (int index = 0; index < NumBombs; index++)
            {
                do//rand the bomb place and mark it
                {
                    i = r.Next(Rows - 1);
                    j = r.Next(Columns - 1);
                }
                while (SquareBoard[i, j].IsBomb == true);
                SquareBoard[i, j].IsBomb = true;
                //init all the neighbours
                if (i < Rows)
                {
                    squareBoard[i + 1, j].Neighbours++;
                    if (j < Columns)
                        squareBoard[i + 1, j + 1].Neighbours++;
                    if (j > 0)
                        squareBoard[i + 1, j - 1].Neighbours++;
                }
                if (i > 0)
                {
                    squareBoard[i - 1, j].Neighbours++;
                    if (j > 0)
                        squareBoard[i - 1, j - 1].Neighbours++;
                    if (j < Columns)
                        squareBoard[i - 1, j + 1].Neighbours++;
                }
                if (j < Columns)
                    squareBoard[i, j + 1].Neighbours++;
                if (j > 0)
                    squareBoard[i, j - 1].Neighbours++;
            }
        }
        #endregion
    }
}
