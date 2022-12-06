using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4ColorTheorem {
   public partial class Form1 : Form {
      public Form1() {
         InitializeComponent();
      }

      private void pictureBox1_Click(object sender, EventArgs e) {
         Engine.initGraph(pictureBox1);
         Engine.demo = new Graf();
         Engine.demo.LoadFromFile(@"..\..\..\TextFile1.txt");
         Engine.demo.Draw(Engine.grp);
         Engine.Refresh();
      }
   }
}
