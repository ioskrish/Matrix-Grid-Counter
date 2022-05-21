using System.Threading;
using System.Threading.Tasks;

namespace MatrixGridCounter
{
    partial class MatrixGridCounter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatrixGridCounter));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operate = new System.Windows.Forms.ToolStripMenuItem();
            this.start = new System.Windows.Forms.ToolStripMenuItem();
            this.Pause = new System.Windows.Forms.ToolStripMenuItem();
            this.resume = new System.Windows.Forms.ToolStripMenuItem();
            this.gridViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x3 = new System.Windows.Forms.ToolStripMenuItem();
            this.x4 = new System.Windows.Forms.ToolStripMenuItem();
            this.x5 = new System.Windows.Forms.ToolStripMenuItem();
            this.x6 = new System.Windows.Forms.ToolStripMenuItem();
            this.x7 = new System.Windows.Forms.ToolStripMenuItem();
            this.x8 = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.StartICON = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ResumeICON = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.PauseICON = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.AboutICON = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.CloseICON = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.GridPanel = new System.Windows.Forms.ToolStripDropDownButton();
            this.x3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operate,
            this.gridViewToolStripMenuItem,
            this.about,
            this.exit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(580, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operate
            // 
            this.operate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.start,
            this.Pause,
            this.resume});
            this.operate.Name = "operate";
            this.operate.Size = new System.Drawing.Size(61, 20);
            this.operate.Text = "Operate";
            // 
            // start
            // 
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(116, 22);
            this.start.Text = "Start";
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Pause
            // 
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(116, 22);
            this.Pause.Text = "Pause";
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // resume
            // 
            this.resume.Name = "resume";
            this.resume.Size = new System.Drawing.Size(116, 22);
            this.resume.Text = "Resume";
            this.resume.Click += new System.EventHandler(this.resume_Click);
            // 
            // gridViewToolStripMenuItem
            // 
            this.gridViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x3,
            this.x4,
            this.x5,
            this.x6,
            this.x7,
            this.x8});
            this.gridViewToolStripMenuItem.Name = "gridViewToolStripMenuItem";
            this.gridViewToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.gridViewToolStripMenuItem.Text = "Grid View";
            // 
            // x3
            // 
            this.x3.Name = "x3";
            this.x3.Size = new System.Drawing.Size(180, 22);
            this.x3.Text = "3 Matrix Grid";
            this.x3.Click += new System.EventHandler(this.x3_Click);
            // 
            // x4
            // 
            this.x4.Name = "x4";
            this.x4.Size = new System.Drawing.Size(180, 22);
            this.x4.Text = "4 Matrix Grid";
            this.x4.Click += new System.EventHandler(this.x4_Click);
            // 
            // x5
            // 
            this.x5.Name = "x5";
            this.x5.Size = new System.Drawing.Size(180, 22);
            this.x5.Text = "5 Matrix Grid";
            this.x5.Click += new System.EventHandler(this.x5_Click);
            // 
            // x6
            // 
            this.x6.Name = "x6";
            this.x6.Size = new System.Drawing.Size(180, 22);
            this.x6.Text = "6 Matrix Grid";
            this.x6.Click += new System.EventHandler(this.x6_Click);
            // 
            // x7
            // 
            this.x7.Name = "x7";
            this.x7.Size = new System.Drawing.Size(180, 22);
            this.x7.Text = "7 Matrix Grid";
            this.x7.Click += new System.EventHandler(this.x7_Click);
            // 
            // x8
            // 
            this.x8.Name = "x8";
            this.x8.Size = new System.Drawing.Size(180, 22);
            this.x8.Text = "8 MAtrix Grid";
            this.x8.Click += new System.EventHandler(this.x8_Click);
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(55, 20);
            this.about.Text = "About ";
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(38, 20);
            this.exit.Text = "Exit";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // StartICON
            // 
            this.StartICON.AutoSize = false;
            this.StartICON.Image = ((System.Drawing.Image)(resources.GetObject("StartICON.Image")));
            this.StartICON.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.StartICON.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StartICON.Name = "StartICON";
            this.StartICON.Size = new System.Drawing.Size(65, 67);
            this.StartICON.Text = "Start";
            this.StartICON.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.StartICON.Click += new System.EventHandler(this.StartICON_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 70);
            // 
            // ResumeICON
            // 
            this.ResumeICON.AutoSize = false;
            this.ResumeICON.Image = ((System.Drawing.Image)(resources.GetObject("ResumeICON.Image")));
            this.ResumeICON.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ResumeICON.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ResumeICON.Name = "ResumeICON";
            this.ResumeICON.Size = new System.Drawing.Size(65, 67);
            this.ResumeICON.Text = "Resume";
            this.ResumeICON.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ResumeICON.Click += new System.EventHandler(this.ResumeICON_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 70);
            // 
            // PauseICON
            // 
            this.PauseICON.AutoSize = false;
            this.PauseICON.Image = ((System.Drawing.Image)(resources.GetObject("PauseICON.Image")));
            this.PauseICON.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.PauseICON.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PauseICON.Name = "PauseICON";
            this.PauseICON.Size = new System.Drawing.Size(65, 67);
            this.PauseICON.Text = "Pause";
            this.PauseICON.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PauseICON.Click += new System.EventHandler(this.PauseICON_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 70);
            // 
            // AboutICON
            // 
            this.AboutICON.AutoSize = false;
            this.AboutICON.Image = ((System.Drawing.Image)(resources.GetObject("AboutICON.Image")));
            this.AboutICON.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AboutICON.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AboutICON.Name = "AboutICON";
            this.AboutICON.Size = new System.Drawing.Size(65, 67);
            this.AboutICON.Text = "About";
            this.AboutICON.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AboutICON.Click += new System.EventHandler(this.AboutICON_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 70);
            // 
            // CloseICON
            // 
            this.CloseICON.AutoSize = false;
            this.CloseICON.Image = ((System.Drawing.Image)(resources.GetObject("CloseICON.Image")));
            this.CloseICON.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CloseICON.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CloseICON.Name = "CloseICON";
            this.CloseICON.Size = new System.Drawing.Size(65, 67);
            this.CloseICON.Text = "Close";
            this.CloseICON.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CloseICON.Click += new System.EventHandler(this.CloseICON_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 70);
            // 
            // GridPanel
            // 
            this.GridPanel.AutoSize = false;
            this.GridPanel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x3ToolStripMenuItem,
            this.x4ToolStripMenuItem,
            this.x5ToolStripMenuItem,
            this.x6ToolStripMenuItem,
            this.x7ToolStripMenuItem,
            this.x8ToolStripMenuItem});
            this.GridPanel.Image = ((System.Drawing.Image)(resources.GetObject("GridPanel.Image")));
            this.GridPanel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.GridPanel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GridPanel.Name = "GridPanel";
            this.GridPanel.Size = new System.Drawing.Size(70, 65);
            this.GridPanel.Text = "Grid Panel";
            this.GridPanel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // x3ToolStripMenuItem
            // 
            this.x3ToolStripMenuItem.Name = "x3ToolStripMenuItem";
            this.x3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.x3ToolStripMenuItem.Text = "3 X 3";
            this.x3ToolStripMenuItem.Click += new System.EventHandler(this.x3ToolStripMenuItem_Click);
            // 
            // x4ToolStripMenuItem
            // 
            this.x4ToolStripMenuItem.Name = "x4ToolStripMenuItem";
            this.x4ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.x4ToolStripMenuItem.Text = "4 X 4";
            this.x4ToolStripMenuItem.Click += new System.EventHandler(this.x4ToolStripMenuItem_Click);
            // 
            // x5ToolStripMenuItem
            // 
            this.x5ToolStripMenuItem.Name = "x5ToolStripMenuItem";
            this.x5ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.x5ToolStripMenuItem.Text = "5 X 5";
            this.x5ToolStripMenuItem.Click += new System.EventHandler(this.x5ToolStripMenuItem_Click);
            // 
            // x6ToolStripMenuItem
            // 
            this.x6ToolStripMenuItem.Name = "x6ToolStripMenuItem";
            this.x6ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.x6ToolStripMenuItem.Text = "6 X 6";
            this.x6ToolStripMenuItem.Click += new System.EventHandler(this.x6ToolStripMenuItem_Click);
            // 
            // x7ToolStripMenuItem
            // 
            this.x7ToolStripMenuItem.Name = "x7ToolStripMenuItem";
            this.x7ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.x7ToolStripMenuItem.Text = "7 X 7";
            this.x7ToolStripMenuItem.Click += new System.EventHandler(this.x7ToolStripMenuItem_Click);
            // 
            // x8ToolStripMenuItem
            // 
            this.x8ToolStripMenuItem.Name = "x8ToolStripMenuItem";
            this.x8ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.x8ToolStripMenuItem.Text = "8 X 8";
            this.x8ToolStripMenuItem.Click += new System.EventHandler(this.x8ToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 70);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartICON,
            this.toolStripSeparator1,
            this.PauseICON,
            this.toolStripSeparator2,
            this.ResumeICON,
            this.toolStripSeparator3,
            this.AboutICON,
            this.toolStripSeparator4,
            this.CloseICON,
            this.toolStripSeparator5,
            this.GridPanel,
            this.toolStripSeparator6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(580, 70);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // MatrixGridCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(580, 481);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MatrixGridCounter";
            this.Text = "Matrix Grid Counter Window";
            this.Load += new System.EventHandler(this.OnPaint);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operate;
        private System.Windows.Forms.ToolStripMenuItem gridViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.ToolStripMenuItem start;
        private System.Windows.Forms.ToolStripMenuItem Pause;
        private System.Windows.Forms.ToolStripMenuItem resume;
        private System.Windows.Forms.ToolStripMenuItem x3;
        private System.Windows.Forms.ToolStripMenuItem x4;
        private System.Windows.Forms.ToolStripMenuItem x5;
        private System.Windows.Forms.ToolStripMenuItem x6;
        private System.Windows.Forms.ToolStripMenuItem x7;
        private System.Windows.Forms.ToolStripMenuItem x8;

        public Thread MatrixCounter;
        public bool bThreadStatus;
        private System.Windows.Forms.ToolStripButton StartICON;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ResumeICON;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton PauseICON;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton AboutICON;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton CloseICON;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripDropDownButton GridPanel;
        private System.Windows.Forms.ToolStripMenuItem x3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}

