namespace MineSweeperUI
{
    partial class FrmGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuBeginner = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIntermediate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExpert = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCustom = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuColor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBestTimes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Clocktxt = new System.Windows.Forms.TextBox();
            this.numBombsTxt = new System.Windows.Forms.TextBox();
            this.btnSmile = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(292, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNew,
            this.toolStripSeparator1,
            this.menuBeginner,
            this.menuIntermediate,
            this.menuExpert,
            this.menuCustom,
            this.toolStripSeparator2,
            this.menuColor,
            this.menuBestTimes,
            this.toolStripSeparator3,
            this.menuExit});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.toolStripMenuItem1.Text = "משחק";
            // 
            // menuNew
            // 
            this.menuNew.Name = "menuNew";
            this.menuNew.Size = new System.Drawing.Size(150, 22);
            this.menuNew.Text = "חדש";
            this.menuNew.Click += new System.EventHandler(this.MenuNew_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(147, 6);
            // 
            // menuBeginner
            // 
            this.menuBeginner.Name = "menuBeginner";
            this.menuBeginner.Size = new System.Drawing.Size(150, 22);
            this.menuBeginner.Text = "מתחיל";
            this.menuBeginner.Click += new System.EventHandler(this.MenuBeginner_Click);
            // 
            // menuIntermediate
            // 
            this.menuIntermediate.Name = "menuIntermediate";
            this.menuIntermediate.Size = new System.Drawing.Size(150, 22);
            this.menuIntermediate.Text = "בינוני";
            this.menuIntermediate.Click += new System.EventHandler(this.MenuIntermediate_Click);
            // 
            // menuExpert
            // 
            this.menuExpert.Name = "menuExpert";
            this.menuExpert.Size = new System.Drawing.Size(150, 22);
            this.menuExpert.Text = "מומחה";
            this.menuExpert.Click += new System.EventHandler(this.MenuExpert_Click);
            // 
            // menuCustom
            // 
            this.menuCustom.Name = "menuCustom";
            this.menuCustom.Size = new System.Drawing.Size(150, 22);
            this.menuCustom.Text = "התאמה אישית";
            this.menuCustom.Click += new System.EventHandler(this.MenuCustom_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(147, 6);
            // 
            // menuColor
            // 
            this.menuColor.Name = "menuColor";
            this.menuColor.Size = new System.Drawing.Size(150, 22);
            // 
            // menuBestTimes
            // 
            this.menuBestTimes.Name = "menuBestTimes";
            this.menuBestTimes.Size = new System.Drawing.Size(150, 22);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(147, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(150, 22);
            this.menuExit.Text = "יציאה";
            this.menuExit.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(12, 20);
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(32, 19);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Clocktxt
            // 
            this.Clocktxt.BackColor = System.Drawing.SystemColors.ControlText;
            this.Clocktxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.Clocktxt.Dock = System.Windows.Forms.DockStyle.Right;
            this.Clocktxt.Font = new System.Drawing.Font("Goudy Stout", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Clocktxt.ForeColor = System.Drawing.Color.Red;
            this.Clocktxt.Location = new System.Drawing.Point(259, 24);
            this.Clocktxt.Name = "Clocktxt";
            this.Clocktxt.ReadOnly = true;
            this.Clocktxt.Size = new System.Drawing.Size(33, 26);
            this.Clocktxt.TabIndex = 1;
            this.Clocktxt.TabStop = false;
            // 
            // numBombsTxt
            // 
            this.numBombsTxt.BackColor = System.Drawing.SystemColors.ControlText;
            this.numBombsTxt.Dock = System.Windows.Forms.DockStyle.Left;
            this.numBombsTxt.Font = new System.Drawing.Font("Goudy Stout", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.numBombsTxt.ForeColor = System.Drawing.Color.Red;
            this.numBombsTxt.Location = new System.Drawing.Point(0, 24);
            this.numBombsTxt.Name = "numBombsTxt";
            this.numBombsTxt.ReadOnly = true;
            this.numBombsTxt.Size = new System.Drawing.Size(33, 26);
            this.numBombsTxt.TabIndex = 2;
            this.numBombsTxt.TabStop = false;
            // 
            // btnSmile
            // 
            this.btnSmile.Location = new System.Drawing.Point(106, 27);
            this.btnSmile.Name = "btnSmile";
            this.btnSmile.Size = new System.Drawing.Size(30, 30);
            this.btnSmile.TabIndex = 3;
            this.btnSmile.UseVisualStyleBackColor = true;
            this.btnSmile.Click += new System.EventHandler(this.MenuNew_Click);
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.btnSmile);
            this.Controls.Add(this.numBombsTxt);
            this.Controls.Add(this.Clocktxt);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmGame";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "שולה המוקשים";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuBeginner;
        private System.Windows.Forms.ToolStripMenuItem menuIntermediate;
        private System.Windows.Forms.ToolStripMenuItem menuExpert;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuColor;
        private System.Windows.Forms.ToolStripMenuItem menuBestTimes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox Clocktxt;
        private System.Windows.Forms.TextBox numBombsTxt;
        private System.Windows.Forms.Button btnSmile;
        private System.Windows.Forms.ToolStripMenuItem menuCustom;



    }
}

