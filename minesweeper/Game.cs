using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace minesweeper
{    
    public class Game
    {
        //const for:beginner,intermediate,expert
        #region const
        public const int beginnerNumBombs = 10;
        public const int beginnerRows = 9;
        public const int beginnerColumns = 9;
           
        public const int intermediateNumBombs = 40;
        public const int intermediateRows = 16;
        public const int intermediateColumns = 16;

        public const int expertNumBombs = 99;
        public const int expertRows = 16;
        public const int expertColumns = 30;
        
        #endregion

        #region data members 
        private Board myBoard;
        private int numCurrentBombs;//number of reall bomobs thet left over to mark
        private int numBombsToSign;//number of bombs that left over to mark -for show
        private string myLevel;        
        #endregion

        #region properties
        public Board MyBoard
        {
             get { return myBoard; }
             set { myBoard = value; }
        }
        public int NumCurrentBombs
        {
            get { return numCurrentBombs; }
            set { numCurrentBombs = value; }
        }
        public int NumBombsToSign
        {
            get { return numBombsToSign; }
            set { numBombsToSign = value; }
        }        
        public string MyLevel
        {
            get { return myLevel; }
            set { myLevel = value; }
        }
        #endregion

        #region constractors

        public Game(string level)//init the logic game
        {
           
            MyLevel = level;
            switch (level)
            {
                case "beginner":
                    NumCurrentBombs = NumBombsToSign = beginnerNumBombs;
                    MyBoard = new Board(beginnerRows, beginnerColumns, beginnerNumBombs);
                    break;
                case "intermediate":
                    NumCurrentBombs = NumBombsToSign = intermediateNumBombs;
                    MyBoard = new Board(intermediateRows, intermediateColumns, intermediateNumBombs);
                    break;
                case "expert":
                    NumCurrentBombs = NumBombsToSign = expertNumBombs;
                    MyBoard = new Board(expertRows, expertColumns, expertNumBombs);
                    break;
            }
        }

        public Game(int customRows, int customColumns, int customBombs)//init the logic of custom game
        {
            MyLevel = "custom";            
            NumCurrentBombs = NumBombsToSign = customBombs;
            MyBoard = new Board(customRows, customColumns, customBombs);
        }

        #endregion

        #region functions
        public void SignBombs(int i,int j)//change the squate status and uppdate the number of the bombs accordingly(on right click)
          
        {
            MyBoard[i, j].ChangeStatus();
            if (MyBoard[i, j].Status == squareStatus.bomb)
            {
                NumBombsToSign--;
                if (MyBoard[i, j].IsBomb == true)
                    NumCurrentBombs--;
            }
            if (MyBoard[i, j].Status == squareStatus.qMark)
            {
                NumBombsToSign++;
                if (MyBoard[i, j].IsBomb == true)
                    NumCurrentBombs++;
            }

        }     
        public bool GameOver(int i,int j)//check if the game over - clicked on bomb
        {
            if (MyBoard[i, j].IsBomb == true)
                return true;
            return false;
        }
        public bool IsWin()//check is win
        {
            if (NumCurrentBombs == 0 && NumBombsToSign == 0)//if all the reall bombs marked 
                return true;
            for(int i=0,j;i<myBoard.Rows;i++)
                for (j = 0; j < myBoard.Columns; j++)
                {
                    if (myBoard[i, j].IsBomb == false && myBoard[i, j].Status != squareStatus.pressed)
                        return false;
                }
            //if all the squares that is not a bomb pressed
            return true;
        }
        //recursive function to opet all the squares around the clicked square
        public void SignPress(int i, int j)
        {
            if (i == -1 || j == -1 || i == MyBoard.Rows || j == MyBoard.Columns || MyBoard[i, j].Status == squareStatus.bomb|| MyBoard[i, j].Status == squareStatus.pressed)
                return;          
            MyBoard[i, j].Press();
            if (MyBoard[i, j].Neighbours > 0)
                return;
            SignPress(i + 1, j);
            SignPress(i + 1, j+1);
            SignPress(i - 1, j);
            SignPress(i - 1, j-1);
            SignPress(i -1 , j+1);
            SignPress(i, j + 1);
            SignPress(i , j - 1);
            SignPress(i+1,j-1);            
        }
        #endregion
    }
}
