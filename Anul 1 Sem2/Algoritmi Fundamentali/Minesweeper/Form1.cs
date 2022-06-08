using System;
using System.Drawing;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        iButton[,] T;

        private void Form1_Load(object sender, EventArgs e)
        {
            int n = 20;
            int m = 14;
            T = new iButton[n, m];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    T[i, j] = new iButton();
                    T[i, j].Size = new Size(20, 20);
                    T[i, j].Parent = this;
                    T[i, j].Location = new Point(120 + i * 22, 120 + j * 22);
                    T[i, j].Click += Form1_Click;
                    T[i, j].line += i;
                    T[i, j].column += j;
                }

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            int l = (sender as iButton).line;
            int c = (sender as iButton).line;
            MessageBox.Show("line " + l + " column " + c);
        }
    }
}
