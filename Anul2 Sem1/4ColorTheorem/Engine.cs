using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4ColorTheorem {
   public static class Engine {

      public static Graphics grp;
      public static Bitmap bmp;
      public static PictureBox display;
      public static Color color = Color.BlanchedAlmond;

      public static void initGraph(PictureBox t) {
         display = t;
         bmp = new Bitmap(t.Width, t.Height);
         grp = Graphics.FromImage(bmp);
         grp.Clear(color);
      }

      public static void Refresh() {
         display.Image = bmp;
      }

      public static void Clear() {
         grp.Clear(color);
      }

      public static Vertex Search(string name, Graf g) {
         foreach (Vertex vertex in g.Vertecies) {
            if (vertex.name == name) {
               return vertex;
            }
         }

         return null;
      }

   }
}
