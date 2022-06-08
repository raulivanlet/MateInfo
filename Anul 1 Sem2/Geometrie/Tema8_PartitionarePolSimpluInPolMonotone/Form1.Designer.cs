namespace Tema8_PartitionarePolSimpluInPolMonotone {
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
         this.components = new System.ComponentModel.Container();
         this.panel1 = new System.Windows.Forms.Panel();
         this.buttonDrawMode = new System.Windows.Forms.Button();
         this.buttonFinishUp = new System.Windows.Forms.Button();
         this.buttonTriang = new System.Windows.Forms.Button();
         this.buttonThreeColor = new System.Windows.Forms.Button();
         this.buttonArie = new System.Windows.Forms.Button();
         this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.labelArie = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // panel1
         // 
         this.panel1.Location = new System.Drawing.Point(12, 12);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(671, 497);
         this.panel1.TabIndex = 9;
         this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
         this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
         // 
         // buttonDrawMode
         // 
         this.buttonDrawMode.Location = new System.Drawing.Point(692, 12);
         this.buttonDrawMode.Name = "buttonDrawMode";
         this.buttonDrawMode.Size = new System.Drawing.Size(92, 57);
         this.buttonDrawMode.TabIndex = 8;
         this.buttonDrawMode.Text = "Draw";
         this.buttonDrawMode.Click += new System.EventHandler(this.buttonDrawMode_Click);
         // 
         // buttonFinishUp
         // 
         this.buttonFinishUp.Location = new System.Drawing.Point(689, 75);
         this.buttonFinishUp.Name = "buttonFinishUp";
         this.buttonFinishUp.Size = new System.Drawing.Size(95, 51);
         this.buttonFinishUp.TabIndex = 2;
         this.buttonFinishUp.Text = "Finish";
         this.buttonFinishUp.UseVisualStyleBackColor = true;
         this.buttonFinishUp.Click += new System.EventHandler(this.buttonFinishUp_Click);
         // 
         // buttonTriang
         // 
         this.buttonTriang.Location = new System.Drawing.Point(690, 133);
         this.buttonTriang.Name = "buttonTriang";
         this.buttonTriang.Size = new System.Drawing.Size(94, 49);
         this.buttonTriang.TabIndex = 3;
         this.buttonTriang.Text = "Triangulate";
         this.buttonTriang.UseVisualStyleBackColor = true;
         this.buttonTriang.Click += new System.EventHandler(this.buttonTriang_Click);
         // 
         // buttonThreeColor
         // 
         this.buttonThreeColor.Location = new System.Drawing.Point(690, 188);
         this.buttonThreeColor.Name = "buttonThreeColor";
         this.buttonThreeColor.Size = new System.Drawing.Size(94, 52);
         this.buttonThreeColor.TabIndex = 4;
         this.buttonThreeColor.Text = "3 Color";
         this.buttonThreeColor.UseVisualStyleBackColor = true;
         this.buttonThreeColor.Click += new System.EventHandler(this.buttonThreeColor_Click);
         // 
         // buttonArie
         // 
         this.buttonArie.Location = new System.Drawing.Point(690, 247);
         this.buttonArie.Name = "buttonArie";
         this.buttonArie.Size = new System.Drawing.Size(94, 52);
         this.buttonArie.TabIndex = 5;
         this.buttonArie.Text = "Calculate Area";
         this.buttonArie.UseVisualStyleBackColor = true;
         this.buttonArie.Click += new System.EventHandler(this.buttonArie_Click);
         // 
         // contextMenuStrip1
         // 
         this.contextMenuStrip1.Name = "contextMenuStrip1";
         this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
         // 
         // labelArie
         // 
         this.labelArie.AutoSize = true;
         this.labelArie.Location = new System.Drawing.Point(689, 325);
         this.labelArie.Name = "labelArie";
         this.labelArie.Size = new System.Drawing.Size(29, 13);
         this.labelArie.TabIndex = 7;
         this.labelArie.Text = "Area";
         // 
         // Form1
         // 
         this.ClientSize = new System.Drawing.Size(796, 521);
         this.Controls.Add(this.labelArie);
         this.Controls.Add(this.buttonArie);
         this.Controls.Add(this.buttonThreeColor);
         this.Controls.Add(this.buttonTriang);
         this.Controls.Add(this.buttonFinishUp);
         this.Controls.Add(this.buttonDrawMode);
         this.Controls.Add(this.panel1);
         this.Name = "Form1";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Button buttonDrawMode;
      private System.Windows.Forms.Button buttonFinishUp;
      private System.Windows.Forms.Button buttonTriang;
      private System.Windows.Forms.Button buttonThreeColor;
      private System.Windows.Forms.Button buttonArie;
      private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
      private System.Windows.Forms.Label labelArie;
   }
}

