using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4ColorTheorem {
   public class Graf {
      public List<Vertex> Vertecies;
      public List<Edge> Edges;

      public Graf() {
         Vertecies = new List<Vertex>();
         Edges = new List<Edge>();
      }

      public void LoadFromFile(string filename) {
         TextReader reader = new StreamReader(filename);
         int n = int.Parse(reader.ReadLine());
         string buffer;

         for (int i=0; i < n; i++) {
            buffer = reader.ReadLine();
            Vertex local = new Vertex(buffer);
            Vertecies.Add(local);
         }

         while ((buffer = reader.ReadLine()) != null) {
            Edge edge = new Edge(buffer);
         }

      }


      public void Draw(Graphics h) {
         foreach(Vertex v in Vertecies) {
            v.Draw(h);
         }
         foreach (Edge e in Edges) {
            e.Draw(h);
         }
      }

      

   }
}
