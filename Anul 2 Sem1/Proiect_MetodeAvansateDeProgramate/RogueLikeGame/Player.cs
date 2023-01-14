using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RogueLikeGame {
   static public class Player {

      static public Image image;
      static public int health;
      static public int damage;
      static public int posX;
      static public int posY;


      static public void InitializePlayer(Image img) {
         InitStaticPosition();
         image = img;
         health = 100;
         damage = 50;
      }

      static private void InitStaticPosition() {
         posX= 1;
         posY= 1;
         Map.mapCoordonates[posX, posY] = 2;
      }

      static private void InitPosition() {
         Random rnd = new Random();
         do {
            posX = rnd.Next(Map.size);
            posX = rnd.Next(Map.size);
         }
         while (Map.mapCoordonates[posX, posY] != 0);
         Map.mapCoordonates[posX, posY] = 2;
      }

      
      static public void Fight(int x, int y) {
         
         if (Map.mapCoordonates[posX, posY] == 2) {
            Map.enemys[0].Attack(damage);
         }
         
      }
      


      //Player Movement
      static public void MoveRight(ref PictureBox player) {
         if (posX < Map.size) {
            if (Map.mapCoordonates[posX + 1, posY] == 0) {
               Map.mapCoordonates[posX, posY] = 0;
               player.Location = new Point(player.Location.X + Map.gridSize, player.Location.Y);
               posX++;
               Map.mapCoordonates[posX, posY] = 2;
            }
            if (Map.mapCoordonates[posX + 1, posY] == 2) {
               Fight(posX + 1, posY);
            }
         }
      }

      static public void MoveLeft(ref PictureBox player) {
         //Move Player only in the grid bounds
         if (Map.mapCoordonates[posX - 1, posY] == 0) {
            Map.mapCoordonates[posX, posY] = 0;
            player.Location = new Point(player.Location.X - Map.gridSize, player.Location.Y);
            posX--;
            Map.mapCoordonates[posX, posY] = 2;
         }
         if (Map.mapCoordonates[posX - 1, posY] == 2) {
            Fight(posX - 1, posY);
         }
      }

      static public void MoveUp(ref PictureBox player) {
         //Move Player only in the grid bounds
         if (Map.mapCoordonates[posX, posY - 1] == 0) {
            Map.mapCoordonates[posX, posY] = 0;
            player.Location = new Point(player.Location.X, player.Location.Y - Map.gridSize);
            posY--;
            Map.mapCoordonates[posX, posY] = 2;
         }
         if (Map.mapCoordonates[posX, posY - 1] == 2) {
            Fight(posX, posY - 1);
         }
      }

      static public void MoveDown(ref PictureBox player) {
         //Move Player only in the grid bounds
         if (Map.mapCoordonates[posX, posY + 1] == 0) {
            Map.mapCoordonates[posX, posY] = 0;
            player.Location = new Point(player.Location.X, player.Location.Y + Map.gridSize);
            posY++;
            Map.mapCoordonates[posX, posY] = 2;
         }
         if (Map.mapCoordonates[posX, posY + 1] == 2) {
            Fight(posX, posY + 1);
         }
      }



   }
}
