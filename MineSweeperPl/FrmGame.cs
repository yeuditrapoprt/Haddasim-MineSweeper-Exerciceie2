using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using minesweeper;


namespace MineSweeperUI
{
    public partial class FrmGame : Form
    {
        #region data members
        private bool color;
        private Game myGame;
        private int rows;
        private int columns;
        private int numBombs;
        private SquareUI[,] squareBoard;
        bool firstLeftClick = false;
        #endregion       
        public FrmGame()
        {
            InitializeComponent();
            InitGame("beginner");
            menuBeginner.Checked = true;
            color = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //init the logic and UI games
        private void InitGame(string level)
        {
            btnSmile.BackgroundImage = new Bitmap("..\\..\\resources\\smile.bmp");
            btnSmile.BackgroundImageLayout = ImageLayout.Stretch;
            firstLeftClick = true;
            timer1.Enabled = false;
            if (level != "custom")
                Clear();
            //init the logic game
            switch (level)
            {
                case "beginner":
                    rows = Game.beginnerRows;
                    columns = Game.beginnerColumns;
                    numBombs = Game.beginnerNumBombs;
                    myGame = new Game(level);
                    break;
                case "intermediate":
                    rows = Game.intermediateRows;
                    columns = Game.intermediateColumns;
                    numBombs = Game.intermediateNumBombs;
                    myGame = new Game(level);
                    break;
                case "expert":
                    rows = Game.expertRows;
                    columns = Game.expertColumns;
                    numBombs = Game.expertNumBombs;
                    myGame = new Game(level);
                    break;
                case "custom":
                    myGame = new Game(rows, columns, numBombs);
                    break;
            }
            numBombsTxt.Text = Convert.ToString(myGame.NumBombsToSign);
            //init the UI game
            squareBoard = new SquareUI[rows, columns];
            for (int i = 0, j; i < rows; i++)
                for (j = 0; j < columns; j++)
                {
                    squareBoard[i, j] = new SquareUI();
                    squareBoard[i, j].Location = new Point(j * Convert.ToInt32(squareBoard[i, j].Size.Height) + 10, i * Convert.ToInt32(squareBoard[i, j].Size.Width) + 55);
                    squareBoard[i, j].LeftClick += new EventHandler(Form1_LeftClick);
                    squareBoard[i, j].RightClick += new EventHandler(Form1_RightClick);
                    squareBoard[i, j].MouseUp += new MouseEventHandler(FrmGame_MouseUp);
                    squareBoard[i, j].Parent = this;
                    squareBoard[i, j].I = i;
                    squareBoard[i, j].J = j;
                }
            this.Size = new Size(Convert.ToInt32(squareBoard[0, 0].Size.Width) * columns + 30, Convert.ToInt32(squareBoard[0, 0].Size.Height) * rows + 100);
            btnSmile.Location = new Point(this.Size.Width / 2 - btnSmile.Size.Width / 2, 25);
            Clocktxt.Text = "0";
            timer1.Interval = 1000;
        }
        void Form1_RightClick(object sender, EventArgs e)
        {
            int indexI;
            int indexJ;
            indexI = ((SquareUI)sender).I;
            indexJ = ((SquareUI)sender).J;
            myGame.SignBombs(indexI, indexJ);
            squareBoard[indexI, indexJ].Status = myGame.MyBoard[indexI, indexJ].Status;
            if (squareBoard[indexI, indexJ].Status == squareStatus.bomb)
                squareBoard[indexI, indexJ].Text = "!";
            else
                if (squareBoard[indexI, indexJ].Status == squareStatus.qMark)
                squareBoard[indexI, indexJ].Text = "?";
            else
                    if (squareBoard[indexI, indexJ].Status == squareStatus.original)
                squareBoard[indexI, indexJ].Text = "";
            numBombsTxt.Text = Convert.ToString(myGame.NumBombsToSign);
            if (myGame.IsWin())
                Win();

        }
        void Form1_LeftClick(object sender, EventArgs e)
        {
            //change the image - onClick
            btnSmile.BackgroundImage = new Bitmap("..\\..\\resources\\smileClick.bmp");
            btnSmile.BackgroundImageLayout = ImageLayout.Stretch;

            if (firstLeftClick == true)
            {
                timer1.Enabled = true;
                firstLeftClick = false;
            }
            int indexI = ((SquareUI)sender).I;
            int indexJ = ((SquareUI)sender).J;
            if (myGame.GameOver(indexI, indexJ) == true)
            {
                GameOver(indexI, indexJ);
                return;
            }
            myGame.SignPress(indexI, indexJ);
            for (int i = 0, j; i < rows; i++)
                for (j = 0; j < columns; j++)
                {
                    if (myGame.MyBoard[i, j].Status == squareStatus.pressed)
                    {
                        if (myGame.MyBoard[i, j].Neighbours > 0)
                        {
                            int num = myGame.MyBoard[i, j].Neighbours;
                            if (color == true)
                            {
                                switch (num)
                                {
                                    case 1:
                                        squareBoard[i, j].ForeColor = Color.Blue;
                                        break;
                                    case 2:
                                        squareBoard[i, j].ForeColor = Color.Green;
                                        break;
                                    case 3:
                                        squareBoard[i, j].ForeColor = Color.Red;
                                        break;
                                    case 4:
                                        squareBoard[i, j].ForeColor = Color.Orange;
                                        break;
                                    case 5:
                                        squareBoard[i, j].ForeColor = Color.Yellow;
                                        break;

                                    default:
                                        squareBoard[i, j].ForeColor = Color.Lime;
                                        break;
                                }
                            }
                            squareBoard[i, j].Text = Convert.ToString(myGame.MyBoard[i, j].Neighbours);
                        }
                        //mark the pressed squere or the neighber to be popUp
                        squareBoard[i, j].FlatStyle = FlatStyle.Popup;
                    }
                }
        }

        //call to InitGame with the choosen level
        private void MenuNew_Click(object sender, EventArgs e)
        {
            if (menuBeginner.Checked)
                InitGame("beginner");
            else
                if (menuIntermediate.Checked)
                InitGame("intermediate");

            else
                    if (menuExpert.Checked)
                InitGame("expert");
            else
                        if (menuCustom.Checked)
            {
                Clear();
                InitGame("custom");
            }
        }
      
        //check if clicked Beginner level
        private void MenuBeginner_Click(object sender, EventArgs e)
        {
            menuBeginner.Checked = true;
            menuIntermediate.Checked = false;
            menuExpert.Checked = false;
            menuCustom.Checked = false;
            InitGame("beginner");
        }
        //check if clicked Intermediate level
        private void MenuIntermediate_Click(object sender, EventArgs e)
        {
            menuIntermediate.Checked = true;
            menuExpert.Checked = false;
            menuBeginner.Checked = false;
            menuCustom.Checked = false;
            InitGame("intermediate");
        }
        //check if clicked Expert level
        private void MenuExpert_Click(object sender, EventArgs e)
        {
            menuExpert.Checked = true;
            menuIntermediate.Checked = false;
            menuBeginner.Checked = false;
            menuCustom.Checked = false;
            InitGame("expert");
        }
        private void MenuExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        //clean all the values from the ui board
        private void Clear()
        {
            for (int i = 0, j; i < rows; i++)
                for (j = 0; j < columns; j++)
                {

                    this.Controls.Remove(squareBoard[i, j]);
                }
        }
        //timer
        private void Timer1_Tick(object sender, EventArgs e)
        {
            Clocktxt.Text = Convert.ToString(Convert.ToInt32(Clocktxt.Text) + 1);
        }
        //check if - custom game, else - the default level
        private void MenuCustom_Click(object sender, EventArgs e)
        {
            //init form 1
            FrmCustom f1 = new FrmCustom();
            //show the menue
            f1.ShowDialog();
            if (f1.OkPressed == true)
            {
                int r;
                int c;
                int b;
                //check values validation and normal to play               
                if (!(int.TryParse(f1.HeightTxt.Text, out r) && int.TryParse(f1.WidthTxt.Text, out c) && int.TryParse(f1.MinesTxt.Text, out b)) ||
                    (!(r > 5 && r <= 25 && c > 5 && c <= 35 && b > 1 && b < (r * c) / 2)))
                {
                    MenuBeginner_Click(sender, e);
                }
                else//normal values
                {
                    Clear();
                    rows = r;
                    columns = c;
                    numBombs = b;
                    InitGame("custom");
                    menuBeginner.Checked = false; ;
                    menuIntermediate.Checked = false;
                    menuExpert.Checked = false;
                    menuCustom.Checked = true;
                }
                //close the menu
                f1.Close();
            }
        }
        //checked if win
        private void FrmGame_MouseUp(object sender, MouseEventArgs e)
        {
            if (myGame.IsWin())
            {
                Win();
                return;
            }
            btnSmile.BackgroundImage = new Bitmap("..\\..\\resources\\smile.bmp");
            btnSmile.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void Win()
        {
            timer1.Enabled = false;
            btnSmile.BackgroundImage = new Bitmap("..\\..\\resources\\smileWin.bmp");
            btnSmile.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void GameOver(int indexI, int indexJ)
        {
            timer1.Enabled = false;
            for (int i = 0, j; i < rows; i++)
                for (j = 0; j < columns; j++)
                {
                    squareBoard[i, j].Enabled = false;
                    if (squareBoard[i, j].Status != squareStatus.bomb && myGame.MyBoard[i, j].IsBomb == true)
                    {
                        squareBoard[i, j].Text = "*";
                        squareBoard[i, j].FlatStyle = FlatStyle.Popup;
                    }
                    else
                        if (squareBoard[i, j].Status == squareStatus.bomb && myGame.MyBoard[i, j].IsBomb == false)
                    {
                        squareBoard[i, j].Text = "X";
                        if (color == true)
                            squareBoard[i, j].ForeColor = Color.Red;
                        squareBoard[i, j].FlatStyle = FlatStyle.Popup;
                    }
                }
            if (color == true)
                squareBoard[indexI, indexJ].BackColor = Color.Red;
            timer1.Enabled = false;
            btnSmile.BackgroundImage = new Bitmap("..\\..\\resources\\smile1.bmp");
            btnSmile.BackgroundImageLayout = ImageLayout.Stretch;
            return;
        }
    }
}