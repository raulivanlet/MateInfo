using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace _4ColorTheorem {
   public class Edge {
      public Vertex start;
      public Vertex end;

      public Edge(string data) {
         string[] buffer = data.Split(' ');
         start = Engine.Search(buffer[0], Engine.demo);
         end = Engine.Search(buffer[1], Engine.demo);
      }
   }
}
