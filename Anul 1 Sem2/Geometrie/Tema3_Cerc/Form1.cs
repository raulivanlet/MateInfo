namespace Cercul_Minim;

public partial class Form1 : Form {
	public Form1() {
		InitializeComponent();
	}

	private void Form1_Paint(object sender, PaintEventArgs e) {
		Random random = new Random();
		Pen pen = new Pen(Color.Black, 3);
		Pen pen1 = new Pen(Color.Red, 3);

		List<Point> pct = new List<Point>();
		for ( int i = 0, n = random.Next(8, 15); i < n; i++ ) {
			int x = random.Next(200, 500);
			int y = random.Next(200, 500);
			pct.Add(new Point(x, y));
			e.Graphics.DrawEllipse(pen1, x, y, 3, 3);
		}
		Point p1, p2;
		int distance;

		Point minx = pct[0];
		Point miny = pct[0];
		Point maxx = pct[0];
		Point maxy = pct[0];
		for ( int i = 1; i < pct.Count; i++ ) {
			Point point = pct[i];
			if ( minx.X > point.X )
				minx = point;
			if ( maxx.X < point.X )
				maxx = point;
			if ( miny.Y > point.Y )
				miny = point;
			if ( maxy.Y < point.Y )
				maxy = point;
		}
		p1 = minx;
		p2 = maxx;
		distance = (int)Math.Sqrt(Math.Pow((p1.X - p2.X), 2) + Math.Pow((p1.Y - p2.Y), 2));
		int distance_minx_maxx = distance;

		p1 = miny;
		p2 = maxy;
		distance = (int)Math.Sqrt(Math.Pow((p1.X - p2.X), 2) + Math.Pow((p1.Y - p2.Y), 2));
		int distance_miny_maxy = distance;

		p1 = minx;
		p2 = maxy;
		distance = (int)Math.Sqrt(Math.Pow((p1.X - p2.X), 2) + Math.Pow((p1.Y - p2.Y), 2));
		int distance_minx_maxy = distance;

		p1 = miny;
		p2 = maxx;
		distance = (int)Math.Sqrt(Math.Pow((p1.X - p2.X), 2) + Math.Pow((p1.Y - p2.Y), 2));
		int distance_miny_maxx = distance;

		if ( distance_minx_maxx > distance_miny_maxy || distance_minx_maxx > distance_minx_maxy || distance_minx_maxx > distance_miny_maxx ) {
			distance = distance_minx_maxx;
			p1 = minx;
			p2 = maxx;
		}
		else if ( distance_miny_maxy > distance_minx_maxx || distance_miny_maxy > distance_minx_maxy || distance_miny_maxy > distance_miny_maxx ) {
			distance = distance_miny_maxy;
			p1 = miny;
			p2 = maxy;
		}
		else if ( distance_minx_maxy > distance_minx_maxx || distance_minx_maxy > distance_miny_maxy || distance_minx_maxy > distance_miny_maxx ) {
			distance = distance_minx_maxy;
			p1 = minx;
			p2 = maxy;
		}
		else if ( distance_miny_maxx > distance_minx_maxx || distance_minx_maxy > distance_miny_maxy || distance_miny_maxx > distance_minx_maxy ) {
			distance = distance_miny_maxx;
			p1 = miny;
			p2 = maxx;
		}

		Point midpoint = new Point((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2);
		e.Graphics.DrawEllipse(pen, p1.X, p1.Y, 3, 3);
		e.Graphics.DrawEllipse(pen, p2.X, p2.Y, 3, 3);
		e.Graphics.DrawEllipse(pen, midpoint.X - distance, midpoint.Y - distance, distance*2, distance*2);
	}
}
