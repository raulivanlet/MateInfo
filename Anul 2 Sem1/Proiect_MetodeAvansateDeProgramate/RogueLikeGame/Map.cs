using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace RogueLikeGame {
   static public class Map {

      //Map
      static public int gridSize = 50;
      static public int size = 10;
      static public int[,] mapCoordonates = new int[size, size];

      //Graphics
      static public Form1 form;
      static public Graphics graphics;
      static public Bitmap bitmap;

      static public List<Enemy> enemys = new List<Enemy>();

      //======================
      //===---Map-Legend---===
      //======================
      // i = 0 -> Walkable Spot
      // i = 1 -> Wall
      // i = 2 -> Player
      // i = 3 -> Enemy
      // i = 4 -> Sword

      static public void GenerateCubeMap() {
         for (int i = 0; i < size; i++) {
            for (int j = 0; j < size; j++) {
               if (i == 0 || i == size - 1 || j == 0 || j == size - 1) {
                  mapCoordonates[i, j] = 1;
               }
            }
         }
      }

      static public void Draw(ref PaintEventArgs e) {
         //Engine.graphics.DrawImage(image, 0, 0, Map.gridSize, Map.gridSize);

        
         for (int i = 0; i < size; i++) {
            for (int j = 0; j < size; j++) {
               
               if (mapCoordonates[i, j] == 1) {
                  e.Graphics.DrawImage(Form1.tile, i * gridSize, j * gridSize, gridSize, gridSize);
               }

               else if (mapCoordonates[i, j] == 2) {
                  e.Graphics.DrawImage(Player.image, Player.posX * gridSize, Player.posY * gridSize, gridSize, gridSize);
               }

            }
         
         }

      }



   }
}
