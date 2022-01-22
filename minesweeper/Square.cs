using System;
using System.Collections.Generic;
using System.Text;

namespace minesweeper
{
    public enum squareStatus {pressed, original, bomb, qMark }
    public class Square
    {
        #region data members           
        private squareStatus status;//pressed, original, bomb, qMark 
        private bool isBomb;//true / false
        private int neighbours; //   
        #endregion

        #region properties     
        public bool IsBomb
        {
            get { return isBomb; }
            set { isBomb = value; }
        }
        public squareStatus Status
        {
            get { return status; }
            set { status = value; }
        }
        public int Neighbours
        {
            get { return neighbours; }
            set
            {
                if (value >= 0 && value <= 8)
                    neighbours = value;
            }
        }
        #endregion

        #region constractors
        public Square()
        {
            this.IsBomb = false;            
            this.Status = squareStatus.original;
            this.Neighbours = 0;
        }
        #endregion

        #region functions
        public void ChangeStatus()
        {
            if(this.Status==squareStatus.original)
                this.Status = squareStatus.bomb;
            else
                if (this.Status == squareStatus.bomb)
                    this.Status = squareStatus.qMark;
                else
                    this.Status = squareStatus.original;

        }       
        public void Press()
        {
            this.Status = squareStatus.pressed;
        }
        #endregion
    }
}
