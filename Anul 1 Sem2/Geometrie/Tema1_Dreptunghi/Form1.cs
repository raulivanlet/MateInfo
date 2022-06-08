﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Problema_Dreptunghi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Random random = new Random();
            Pen pen = new Pen(Color.Black, 3);
            Pen pen1 = new Pen(Color.Red, 3);

            List<Point> pct = new List<Point>();
            for (int i = 0 , n = random.Next(5,15); i < n; i++)
            {
                int x = random.Next(300);
                int y = random.Next(300);
                pct.Add(new Point(x, y));
                e.Graphics.DrawEllipse(pen1, x, y, 1, 1);
            }
            Point minx = pct[0];
            Point miny = pct[0];
            Point maxx = pct[0];
            Point maxy = pct[0];
            for (int i = 1; i < pct.Count; i++)
            {
                Point point = pct[i];
                if (minx.X > point.X)
                    minx = point;
                if (maxx.X < point.X)
                    maxx = point;
                if (miny.Y > point.Y)
                    miny = point;
                if (maxy.Y < point.Y)
                    maxy = point;
            }
            Rectangle dreptunghi = new Rectangle(minx.X - 1, miny.Y - 1, maxx.X - minx.X + 2, maxy.Y - miny.Y + 2);
            e.Graphics.DrawRectangle(pen, dreptunghi);
        }
    }
}
