using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MineSweeperUI
{
    public partial class FrmCustom : Form
    {
        private bool okPressed;
        public FrmCustom()
        {
            InitializeComponent();
            OkPressed = false;
        }
        public bool OkPressed
        {
            get { return okPressed; }
            set { okPressed = value; }
        }
        private void OkBtn_Click(object sender, EventArgs e)
        {
            OkPressed = true;
            this.Hide();
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {            
            this.Close();
        }
    }
}