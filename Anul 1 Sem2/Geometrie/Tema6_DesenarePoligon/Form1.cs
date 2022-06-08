using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PunctNou {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		Graphics g;
		Pen pen;
		List<Point> points = new List<Point>();

		private void panel1_MouseUp(object sender, MouseEventArgs e) {
			Graphics g = panel1.CreateGraphics();
			pen = new Pen(Color.Black, 3);
			Point p = new Point(e.X, e.Y);
			g.DrawEllipse(pen, p.X, p.Y, 4, 4);
			if (points.Count != 0) {
				g.DrawLine(pen, p, points[points.Count - 1]);
			}
			points.Add(p);
		}

		private void button1_Click(object sender, EventArgs e) {
			panel1.Paint += Panel1_Paint;
			panel1.Refresh();
		}

		private void Panel1_Paint(object sender, PaintEventArgs e) {
			g = e.Graphics;
			points.Add(points[0]);
			for (int i =0; i< points.Count -1; i++) {
				g.DrawLine(pen ,points[i] , points[i+1]);
			}
		}
	}
}
