using System;
using System.Drawing;
using System.Windows.Forms;

namespace _2DShooter {
   public partial class Form1 : Form {

      public Image backgroung = Image.FromFile(@"../../Images/Background.png");
      public Image normalZombie = Image.FromFile(@"../../Images/Enemy1.png");

      public Form1() {
         InitializeComponent();
      }
      private void Form1_KeyDown(object sender, KeyEventArgs e) {
         if(e.KeyCode == Keys.Escape)
            Close();
      }

      private void Form1_Load(object sender, EventArgs e) {
         pictureBox1.Height = this.Height;
         pictureBox1.Width = this.Width;

         Engine.Init(this);
      }
      private void timer1_Tick(object sender, EventArgs e) {
         foreach (Enemy enemy in Engine.enemyes) {
            enemy.Move();
            Engine.UpdateDisplay();
         }
         
      }
      private void Form1_MouseClick(object sender, MouseEventArgs e) {
         Engine.Shoot(e.Location);
      }
   }
}
