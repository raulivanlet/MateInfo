using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tema2_TriunghiArieMinima {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
		}

		private void Form1_Paint(object sender, PaintEventArgs e) {
			Pen pixNegru = new Pen(Color.Black, 1);
			Pen pixRosu = new Pen(Color.Red, 4);
			List<Point> pct = new List<Point>();
			Random rnd = new Random();
			for (int i = 0; i < rnd.Next(5, 15); i++) {
				int x = rnd.Next(10, 500), y = rnd.Next(10, 500);
				pct.Add(new Point(x, y));
				e.Graphics.DrawEllipse(pixRosu, x, y, 2, 2);
			}
			Point minPct1 = pct[0], minPct2 = pct[1], minPct3 = pct[2];
			double area, semiP, lat1, lat2, lat3, minArea = 999999.9;
			for (int i = 0; i < pct.Count; i++)
				for (int j = 0; j < pct.Count; j++)
					for (int k = 0; k < pct.Count; k++)
						if (i != j && i != k && j != k) {
							lat1 = Math.Sqrt(Math.Pow((pct[j].Y - pct[i].Y), 2) + Math.Pow((pct[j].X - pct[i].X), 2));
							lat2 = Math.Sqrt(Math.Pow((pct[k].Y - pct[j].Y), 2) + Math.Pow((pct[k].X - pct[j].X), 2));
							lat3 = Math.Sqrt(Math.Pow((pct[i].Y - pct[k].Y), 2) + Math.Pow((pct[i].X - pct[k].X), 2));
							semiP = Convert.ToDouble((lat1 + lat2 + lat3) / 2);
							area = Math.Sqrt(semiP * (semiP - lat1) * (semiP - lat2) * (semiP - lat3));
							if (area < minArea) {
								minArea = area;
								minPct1 = pct[i];
								minPct2 = pct[j];
								minPct3 = pct[k];
							}
						}

			e.Graphics.DrawLine(pixNegru, minPct1.X, minPct1.Y, minPct2.X, minPct2.Y);
			e.Graphics.DrawLine(pixNegru, minPct2.X, minPct2.Y, minPct3.X, minPct3.Y);
			e.Graphics.DrawLine(pixNegru, minPct3.X, minPct3.Y, minPct1.X, minPct1.Y);
		}
	}
}
