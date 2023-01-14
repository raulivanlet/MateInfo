using System;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RogueLikeGame {
   public class Enemy {

      public Image img;
      public int health = 100;
      public int damage = 100;
      public int id;
      public int posX ;
      public int posY ;


      public Enemy(Image img) {
         //id = Map.enemys.Count;
         this.img = img;
      }

      
      public void InitializeEnemy() {
         InitStaticPosition();
         health = 100;
      }

      private void InitStaticPosition() {
         posX = 2;
         posY = 2;
         Map.mapCoordonates[posX, posY] = 3;
      }

      private void InitPosition() {
         Random rnd = new Random();

         do {
            posX = rnd.Next(Map.size);
            posX = rnd.Next(Map.size);
         }
         while (Map.mapCoordonates[posX, posY] != 0);

         Map.mapCoordonates[posX, posY] = 3;
      }

      public void Draw() {
         Map.graphics.DrawImage(img, 0, 0, Map.gridSize, Map.gridSize);
      }


      public void Attack(int dmg) {
         //===============================
         //======Fix this
         //===============================
         if (dmg >= health) {

            Map.mapCoordonates[Map.enemys[0].posX, Map.enemys[0].posY] = 0;
         }
         else {
            health -= dmg;
         }
      }


   }
}
