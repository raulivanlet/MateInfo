using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace RogueLikeGame {
	public partial class Form1 : Form {

		public Form1() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
			//Generate Map
			FormBorderStyle = FormBorderStyle.None;
			WindowState = FormWindowState.Maximized;
			StartPosition = FormStartPosition.CenterScreen;
			pictureBox1.Size = new Size(Width, Height);
			pictureBox1.BackColor = Color.Gray;
			Map.Init(this);
		}


		private void Form1_KeyDown(object sender, KeyEventArgs e) {
			
			
			if (e.KeyCode == Keys.Escape)
				Application.Exit();
			if (e.KeyCode == Keys.Right)
				Player.MoveRight();
			if (e.KeyCode == Keys.Left)
				Player.MoveLeft();
			if (e.KeyCode == Keys.Up)
				Player.MoveUp();
			if (e.KeyCode == Keys.Down)
				Player.MoveDown();

			
		}

		private void pictureBox1_Paint(object sender, PaintEventArgs e) {
			Map.Draw(e);
		}

	}
}
