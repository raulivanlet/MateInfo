using RogueLikeGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RogueLikeGame {
   public partial class Form1 : Form {

      public Form1() {
         InitializeComponent();
      }

      static public Image tile = Image.FromFile("../../resources/background.jpg");
      static public Image player = Image.FromFile("../../resources/knight.png");
      static public Image enemy = Image.FromFile("../../resources/Rat_infobox.jpg");


      static public Form1 form;
      static public Graphics graphics;
      static public Bitmap bitmap;

      private void Form1_Load(object sender, EventArgs e) {
         pictureBox1.Size = new Size(Width, Height);
         pictureBox1.BackColor= Color.Gray;

         //Generate Map
         Map.GenerateCubeMap();

         Player.InitializePlayer(player);
         bplayer.Location = new Point(Player.posX * Map.gridSize, Player.posY * Map.gridSize);
         bplayer.Size = new Size(50, 50);
         bplayer.SizeMode = PictureBoxSizeMode.StretchImage;
         bplayer.Load("../../resources/knight.png");
         bplayer.BringToFront();

         Enemy rat = new Enemy(Image.FromFile("../../resources/Rat_infobox.jpg"));
         rat.InitializeEnemy();
         Map.enemys.Add(rat);

         benemy.Location = new Point(rat.posX * Map.gridSize, rat.posY * Map.gridSize);
         benemy.Size = new Size(50, 50);
         benemy.SizeMode = PictureBoxSizeMode.StretchImage;
         benemy.Load("../../resources/Rat_infobox.jpg");
         benemy.BringToFront();
         
      }




      public void KillEnemy(int val) {
         benemy.Hide();
      }


      private void Form1_KeyDown(object sender, KeyEventArgs e) {
         if(e.KeyCode == Keys.Escape)
            Application.Exit();

         if (e.KeyCode == Keys.Right)
            Player.MoveRight(ref bplayer);

         if (e.KeyCode == Keys.Left)
            Player.MoveLeft(ref bplayer);

         if (e.KeyCode == Keys.Up)
            Player.MoveUp(ref bplayer);

         if (e.KeyCode == Keys.Down)
            Player.MoveDown(ref bplayer);

      }

      private void pictureBox1_Paint(object sender, PaintEventArgs e) {
         Map.Draw(ref e);
      }

   }
}
