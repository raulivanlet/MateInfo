using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4ColorTheorem {
   internal class Vertex {

      public PointF location;
      public string name;

      public Vertex(string name , PointF location) {
         name = this.name;
         location = this.location;
      }

      public Vertex(string data) {
         string[] t = data.Split(' ');
         name = t[0].Trim();
         location = new PointF(float.Parse(t[1]), float.Parse(t[2]));
      }

      public void Draw(Graphics h) {
         h.DrawEllipse(Pens.Black, location.X -5 , location.Y -5 , 11, 11);
         h.DrawString(name, new Font("Arial", 12, FontStyle.Regular), new SolidBrush(Color.Blue), location.X, location.Y);
      }

   }
}
