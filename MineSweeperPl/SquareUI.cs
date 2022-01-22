using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using minesweeper;

namespace MineSweeperUI
{
    class SquareUI : Button
    {
        #region data members
        public event EventHandler RightClick;
        public event EventHandler LeftClick;
        private squareStatus status;
        private int i;
        private int j;
        #endregion

        #region properties
        public int I
        {
            get { return i; }
            set { i = value; }
        }
        public int J
        {
            get { return j; }
            set { j = value; }
        }
        public squareStatus Status
        {
            get { return status; }
            set { status = value; }
        }
        protected override Size DefaultSize
        {
            get
            {
                return new Size(40, 40);
            }
        }
       public override Size MaximumSize
        {
            get
            {
                return this.Size;
            }
        }
        public override Size MinimumSize
        {
            get
            {
                return this.Size;
            }

        }
        public SquareUI()
        {
            this.Status = squareStatus.original;
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {

            if ((e as MouseEventArgs).Button == MouseButtons.Right)
                OnRightClick(this, e);
            else
                if ((e as MouseEventArgs).Button == MouseButtons.Left)
                OnLeftClick(this, e);

        }
        protected virtual void OnRightClick(object sender, EventArgs e)
        {
            if (RightClick != null && Status != squareStatus.pressed)
                RightClick(sender, e);
        }
        protected virtual void OnLeftClick(object sender, EventArgs e)
        {
            if (LeftClick != null && (status == squareStatus.original || status == squareStatus.qMark))
                LeftClick(sender, e);
        }

        #endregion
    }
}
