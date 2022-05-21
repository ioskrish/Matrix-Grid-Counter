using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MatrixGridCounter
{
    public partial class MatrixGridCounter : Form
    {
        public int m_width;//Width of the grid cell
        public int m_Height;//Height of the cell
        public int m_NoOfRows;//No of Rows
        public int m_NoOfColoumns;//No of Coloumns
        public int m_XOffset;//Offset from wwhich drawing starts
        public int m_YOffset;
        public int Counter = 2;
        public int GridMaxSize = 2;


        public const int DEFAULT_X_OFFSET = 105;
        public const int DEFAULT_Y_OFFSET = 105;
        public const int DEFAULT_NO_ROWS = 3;
        public const int DEFAULT_NO_COLS = 3;
        public const int DEFAULT_WIDTH = 45;
        public const int DEFAULT_HEIGHT = 45;
        public MatrixGridCounter()
        {
            Initialize();
            InitializeComponent();
            bThreadStatus = false;
        }

        private void FormMatrixGrid_Load(object sender, EventArgs e)
        {

        }

        private void OnPaint(object sender, EventArgs e)
        {
            DrawGrid();
        }

        public void Initialize()
        {
            //put all the default values
            m_NoOfRows = DEFAULT_NO_ROWS;
            m_NoOfColoumns = DEFAULT_NO_COLS;
            m_width = DEFAULT_WIDTH;
            m_Height = DEFAULT_HEIGHT;
            m_XOffset = DEFAULT_X_OFFSET;
            m_YOffset = DEFAULT_Y_OFFSET;
        }

        private void DrawGrid()
        {
            Graphics boardLayout = this.CreateGraphics();
            Pen layoutPen = new Pen(Color.Crimson);
            layoutPen.Width = 3;
            //boardLayout.DrawLine(layoutPen,0,0,100,0);
            int X = DEFAULT_X_OFFSET;
            int Y = DEFAULT_Y_OFFSET;

            //Draw the Rows

            for (int i = 0; i <= Counter; i++)
            {
                boardLayout.DrawLine(layoutPen, X, Y, X + this.m_width * this.Counter, Y);
                Y = Y + m_Height;
            }

            X = DEFAULT_X_OFFSET;
            Y = DEFAULT_Y_OFFSET;


            //Draw the Coloums

            for (int j = 0; j <= Counter; j++)
            {
                boardLayout.DrawLine(layoutPen, X, Y, X, Y + this.m_Height * this.Counter);
                X = X + m_width;
            }
        }
        public void ThreadCounter()
        {

            try
            {
                while (true)
                {
                    Counter++;

                    if (Counter > GridMaxSize)
                    {
                        Counter = 1;
                    }
                    Invalidate();
                    Thread.Sleep(1000);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            MatrixCounter = new Thread(new ThreadStart(ThreadCounter));
            MatrixCounter.Start();
            bThreadStatus = true;
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            MatrixCounter.Suspend();
        }

        private void resume_Click(object sender, EventArgs e)
        {
            MatrixCounter.Resume();
        }

        private void StartICON_Click(object sender, EventArgs e)
        {
            MatrixCounter = new Thread(new ThreadStart(ThreadCounter));
            MatrixCounter.Start();
            bThreadStatus = true;
        }

        private void ResumeICON_Click(object sender, EventArgs e)
        {
            MatrixCounter.Resume();
        }

        private void PauseICON_Click(object sender, EventArgs e)
        {
            MatrixCounter.Suspend();
        }

        private void AboutICON_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hey! This is Matrix Grid Counter Application" + "\n" + "Built in 2022" + "\n" + "Developer: Krishna Panchal");
        }

        private void CloseICON_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hey! This is Matrix Grid Counter Application" + "\n" + "Built in 2022" + "\n" + "Developer: Krishna Panchal");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void x3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridMaxSize = 3;
            this.Refresh();
        }

        private void x4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridMaxSize = 4;
            this.Refresh();
        }

        private void x5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridMaxSize = 5;
            this.Refresh();
        }

        private void x6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridMaxSize = 6;
            this.Refresh();
        }

        private void x7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridMaxSize = 7;
            this.Refresh();
        }

        private void x8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridMaxSize = 8;
            this.Refresh();
        }

        private void x3_Click(object sender, EventArgs e)
        {
            GridMaxSize = 3;
            this.Refresh();
        }

        private void x4_Click(object sender, EventArgs e)
        {
            GridMaxSize = 4;
            this.Refresh();
        }

        private void x5_Click(object sender, EventArgs e)
        {
            GridMaxSize = 5;
            this.Refresh();
        }

        private void x6_Click(object sender, EventArgs e)
        {
            GridMaxSize = 6;
            this.Refresh();
        }

        private void x7_Click(object sender, EventArgs e)
        {
            GridMaxSize = 7;
            this.Refresh();
        }

        private void x8_Click(object sender, EventArgs e)
        {
            GridMaxSize = 8;
            this.Refresh();
        }
    }
}
