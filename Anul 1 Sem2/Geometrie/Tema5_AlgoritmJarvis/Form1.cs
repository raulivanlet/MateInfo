using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tema5_AlgoritmJarvis {
   public partial class Form1 : Form {
      public Form1() {
         InitializeComponent();
      }

      Random rnd = new Random();
      Graphics g;
      List<Point> points;
      Brush brush = new SolidBrush(Color.Black);
      Pen redPen = new Pen(Color.Red, 3);

      private void panel1_Paint(object sender, PaintEventArgs e) {
         g = e.Graphics;
         g.Clear(SystemColors.GradientInactiveCaption);

         points = new List<Point>();
         for (int i = 0; i < rnd.Next(10, 40); i++) {
            Point p = new Point(rnd.Next(50, this.panel1.Width - 50), rnd.Next(50, this.panel1.Height - 50));
            points.Add(p);
            g.FillEllipse(brush, p.X - 2, p.Y - 2, 5, 5);
         }
      }

      private void button1_Click(object sender, EventArgs e) {
         g = panel1.CreateGraphics();

         List<int> hull = new List<int>();
         bool goOn;
         int iMin = 0;
         for (int i = 0; i < points.Count; i++) {
            if (points[i].Y < points[iMin].Y) {
               iMin = i;
            }
         }
         hull.Add(iMin);
         do {
            goOn = true;
            int pArbitrar = (hull[hull.Count - 1] + 1) % points.Count;
            for (int i = 0; i < points.Count; i++) {
               if (DetSensTrigonometric(points[hull[hull.Count - 1]].X, points[hull[hull.Count - 1]].Y, points[i].X, points[i].Y, points[pArbitrar].X, points[pArbitrar].Y) > 0) {
                  pArbitrar = i;
               }
            }
            hull.Add(pArbitrar);
            if (pArbitrar == iMin) {
               goOn = false;
            }
         } while (goOn);

         for (int i = 0; i < hull.Count - 1; i++) {
            g.DrawLine(redPen, points[hull[i]].X, points[hull[i]].Y, points[hull[i + 1]].X, points[hull[i + 1]].Y);
         }
      }

      private double DetSensTrigonometric(double pX, double pY, double qX, double qY, double rX, double rY) {
         return (pX * qY) + (qX * rY) + (pY * rX) - (rX * qY) - (pX * rY) - (qX * pY);
      }

   }
}
