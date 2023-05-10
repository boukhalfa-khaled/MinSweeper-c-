namespace minSweeper
{
    partial class Form1
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
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.boombNumberShow = new System.Windows.Forms.TextBox();
            this.hard = new System.Windows.Forms.Button();
            this.meduim = new System.Windows.Forms.Button();
            this.easy = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtshowtime = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pGame = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(754, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.NewGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.boombNumberShow);
            this.panel1.Controls.Add(this.hard);
            this.panel1.Controls.Add(this.meduim);
            this.panel1.Controls.Add(this.easy);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 50);
            this.panel1.TabIndex = 1;
            // 
            // boombNumberShow
            // 
            this.boombNumberShow.Location = new System.Drawing.Point(193, 9);
            this.boombNumberShow.Name = "boombNumberShow";
            this.boombNumberShow.Size = new System.Drawing.Size(40, 20);
            this.boombNumberShow.TabIndex = 3;
            // 
            // hard
            // 
            this.hard.BackColor = System.Drawing.Color.Blue;
            this.hard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hard.ForeColor = System.Drawing.Color.White;
            this.hard.Location = new System.Drawing.Point(263, 9);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(75, 23);
            this.hard.TabIndex = 2;
            this.hard.Text = "hard";
            this.hard.UseVisualStyleBackColor = false;
            this.hard.Click += new System.EventHandler(this.hardClick);
            // 
            // meduim
            // 
            this.meduim.BackColor = System.Drawing.Color.Blue;
            this.meduim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.meduim.ForeColor = System.Drawing.Color.White;
            this.meduim.Location = new System.Drawing.Point(344, 9);
            this.meduim.Name = "meduim";
            this.meduim.Size = new System.Drawing.Size(75, 23);
            this.meduim.TabIndex = 2;
            this.meduim.Text = "medium";
            this.meduim.UseVisualStyleBackColor = false;
            this.meduim.Click += new System.EventHandler(this.mediumClick);
            // 
            // easy
            // 
            this.easy.BackColor = System.Drawing.Color.Red;
            this.easy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.easy.ForeColor = System.Drawing.Color.White;
            this.easy.Location = new System.Drawing.Point(425, 9);
            this.easy.Name = "easy";
            this.easy.Size = new System.Drawing.Size(75, 23);
            this.easy.TabIndex = 2;
            this.easy.Text = "easy";
            this.easy.UseVisualStyleBackColor = false;
            this.easy.Click += new System.EventHandler(this.easyClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(520, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtshowtime);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 50);
            this.panel2.TabIndex = 0;
            // 
            // txtshowtime
            // 
            this.txtshowtime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtshowtime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtshowtime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtshowtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtshowtime.ForeColor = System.Drawing.Color.White;
            this.txtshowtime.Location = new System.Drawing.Point(32, 9);
            this.txtshowtime.Name = "txtshowtime";
            this.txtshowtime.ReadOnly = true;
            this.txtshowtime.Size = new System.Drawing.Size(100, 29);
            this.txtshowtime.TabIndex = 0;
            this.txtshowtime.Text = "00:00:00";
            this.txtshowtime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(3, 97);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 2;
            // 
            // pGame
            // 
            this.pGame.BackColor = System.Drawing.Color.Wheat;
            this.pGame.Location = new System.Drawing.Point(3, 80);
            this.pGame.Name = "pGame";
            this.pGame.Size = new System.Drawing.Size(200, 100);
            this.pGame.TabIndex = 2;
            this.pGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PGame_Paint);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 831);
            this.Controls.Add(this.pGame);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(770, 870);
            this.MinimumSize = new System.Drawing.Size(770, 870);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pGame;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtshowtime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button hard;
        private System.Windows.Forms.Button meduim;
        private System.Windows.Forms.Button easy;
        private System.Windows.Forms.TextBox boombNumberShow;
    }
}

