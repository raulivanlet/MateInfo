using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Tema1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            TextReader note = new StreamReader(@"../../TextFile1.txt");

            String t1 = note.ReadLine();
            String t2 = note.ReadLine();

            int n = int.Parse(t1);
            string[] t3 = t2.Split(' ');
            int[] v = new int[n];
            int s =0;
            for(int i =0; i< n;i++)
            {
                v[i] = int.Parse(t3[i]);
                s = s + v[i];
            }

            listBox2.Items.Add(t1);
            listBox2.Items.Add(t2);
            listBox2.Items.Add(s);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pen pen1 = new Pen(Color.Red, 3);
            
        }
    }
}
