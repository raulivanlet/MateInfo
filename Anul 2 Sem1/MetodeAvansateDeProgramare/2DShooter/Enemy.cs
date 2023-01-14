using System;
using System.Windows.Forms;
using System.Drawing;
using static System.Windows.Forms.LinkLabel;

namespace _2DShooter {

   public class Enemy {
      public double health, speed, damage, sizeX, sizeY, positionX;
      public int spawnTime;
      public Point position;

      public Enemy(double health, double speed, double damage, double sizeX, double sizeY, int spawnTime) {
         this.health = health;
         this.speed = speed;
         this.damage = damage;
         this.sizeX = sizeX;
         this.sizeY = sizeY;
         this.spawnTime = spawnTime;
         position = Engine.GetRandomPoint((int)sizeX, (int)sizeY);
         positionX = position.X;
      }

      public void Move() {
         position.Y += (int)speed;
         sizeX += 1.0 / 16;
         sizeY += 1.0/ 8;
         positionX = 1.0 / 16;
         position.X = (int)positionX;
      }
      public void GetShot(Point click) {
         if (click.X > position.X && click.X < position.X + sizeX && click.Y > position.Y && click.Y < position.Y + sizeY){
            health -= 20;
         }
      }

   }
}