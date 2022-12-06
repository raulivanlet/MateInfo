using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace _2DShooter {

   public static class Engine {
      public static Form1 form;
      public static Random random = new Random();
      public static List<Enemy> enemyes = new List<Enemy>(), wave = new List<Enemy>();
      public static Graphics graphics;
      public static Bitmap bitmap;

      public static int horizon = 100, time =0;

      public static void Init(Form1 f1) {
         form = f1;
         bitmap = new Bitmap(form.Width, form.Height);
         graphics = Graphics.FromImage(bitmap);

         wave.Add(new Enemy(100, 5, 0, 50, 100, 0));
         wave.Add(new Enemy(100, 5, 0, 50, 100, 2));
         wave.Add(new Enemy(100, 5, 0, 50, 100, 5));
         wave.Add(new Enemy(100, 5, 0, 50, 100, 55)); 
      }

      public static void Tick() {
         time++;
         if (wave[0].spawnTime <= time) {
            enemyes.Add(wave[0]);
            wave.RemoveAt(0);
         }
         foreach (Enemy enemy in enemyes) {
            enemy.Move();
         }
         UpdateDisplay();
      }

      public static Point GetRandomPoint(int sizeX, int sizeY) {
         return new Point(random.Next(form.Width - sizeX), horizon - sizeY);
      }

      public static void UpdateDisplay() {
         graphics.DrawImage(form.backgroung, 0, 0, form.Width, form.Height);
         foreach (Enemy enemy in enemyes) {

            graphics.DrawImage(form.normalZombie, enemy.position.X, enemy.position.Y, (int)enemy.sizeX, (int)enemy.sizeY);
            form.pictureBox1.Image = bitmap;
         }
      }

      public static void Shoot(Point click) {
         // parcurgem toti inamicii pentru a verifica daca toti dintre ei sunt impuscati
         // astfel, avem efectul unui piercing shot (in viitor, vom avea arme cu sau fara)
         for (int i = 0; i < enemyes.Count; i++) {
            enemyes[i].GetShot(click);
            // daca inamicul nu mai are viata, il scoatem din lista de inamici
            if (enemyes[i].health <= 0) {
               enemyes.Remove(enemyes[i]);
               i--;
            }
         }

         // daca nu mai exista inamici, inseamna ca ai castigat
         if (enemyes.Count == 0) {
            form.timer1.Enabled = false;
            MessageBox.Show("You defeated all the enemies!", "You Win!");
            form.Close();
         }
      }
   }
}