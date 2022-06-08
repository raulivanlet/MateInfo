namespace Tema10_TriangularePoligonMonoton {
   partial class Form1 {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing) {
         if (disposing && (components != null)) {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent() {
         this.panel1 = new System.Windows.Forms.Panel();
         this.button1 = new System.Windows.Forms.Button();
         this.buttonFinishUp = new System.Windows.Forms.Button();
         this.buttonPartiton = new System.Windows.Forms.Button();
         this.buttonSavePolygons = new System.Windows.Forms.Button();
         this.buttonTriangulate = new System.Windows.Forms.Button();
         this.listBoxPoligoane = new System.Windows.Forms.ListBox();
         this.SuspendLayout();
         // 
         // panel1
         // 
         this.panel1.Location = new System.Drawing.Point(13, 13);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(728, 546);
         this.panel1.TabIndex = 0;
         this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
         this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(747, 13);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(127, 56);
         this.button1.TabIndex = 1;
         this.button1.Text = "Draw";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // buttonFinishUp
         // 
         this.buttonFinishUp.Location = new System.Drawing.Point(747, 75);
         this.buttonFinishUp.Name = "buttonFinishUp";
         this.buttonFinishUp.Size = new System.Drawing.Size(127, 60);
         this.buttonFinishUp.TabIndex = 2;
         this.buttonFinishUp.Text = "Finish";
         this.buttonFinishUp.UseVisualStyleBackColor = true;
         this.buttonFinishUp.Click += new System.EventHandler(this.buttonFinishUp_Click);
         // 
         // buttonPartiton
         // 
         this.buttonPartiton.Location = new System.Drawing.Point(748, 141);
         this.buttonPartiton.Name = "buttonPartiton";
         this.buttonPartiton.Size = new System.Drawing.Size(126, 55);
         this.buttonPartiton.TabIndex = 3;
         this.buttonPartiton.Text = "Partition";
         this.buttonPartiton.UseVisualStyleBackColor = true;
         this.buttonPartiton.Click += new System.EventHandler(this.buttonPartiton_Click);
         // 
         // buttonSavePolygons
         // 
         this.buttonSavePolygons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.buttonSavePolygons.Location = new System.Drawing.Point(747, 202);
         this.buttonSavePolygons.Name = "buttonSavePolygons";
         this.buttonSavePolygons.Size = new System.Drawing.Size(126, 59);
         this.buttonSavePolygons.TabIndex = 4;
         this.buttonSavePolygons.Text = "Save Polygons";
         this.buttonSavePolygons.UseVisualStyleBackColor = true;
         this.buttonSavePolygons.Click += new System.EventHandler(this.buttonSavePolygons_Click);
         // 
         // buttonTriangulate
         // 
         this.buttonTriangulate.Location = new System.Drawing.Point(746, 267);
         this.buttonTriangulate.Name = "buttonTriangulate";
         this.buttonTriangulate.Size = new System.Drawing.Size(127, 48);
         this.buttonTriangulate.TabIndex = 5;
         this.buttonTriangulate.Text = "Triangulate";
         this.buttonTriangulate.UseVisualStyleBackColor = true;
         this.buttonTriangulate.Click += new System.EventHandler(this.buttonTriangulate_Click);
         // 
         // listBoxPoligoane
         // 
         this.listBoxPoligoane.FormattingEnabled = true;
         this.listBoxPoligoane.Location = new System.Drawing.Point(748, 322);
         this.listBoxPoligoane.Name = "listBoxPoligoane";
         this.listBoxPoligoane.Size = new System.Drawing.Size(120, 95);
         this.listBoxPoligoane.TabIndex = 6;
         // 
         // Form1
         // 
         this.ClientSize = new System.Drawing.Size(886, 571);
         this.Controls.Add(this.listBoxPoligoane);
         this.Controls.Add(this.buttonTriangulate);
         this.Controls.Add(this.buttonSavePolygons);
         this.Controls.Add(this.buttonPartiton);
         this.Controls.Add(this.buttonFinishUp);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.panel1);
         this.Name = "Form1";
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Button buttonFinishUp;
      private System.Windows.Forms.Button buttonPartiton;
      private System.Windows.Forms.Button buttonSavePolygons;
      private System.Windows.Forms.Button buttonTriangulate;
      private System.Windows.Forms.ListBox listBoxPoligoane;
   }
}

