namespace Tema7_TriangularePoligonSimplu {
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
         this.buttonDrawMode = new System.Windows.Forms.Button();
         this.buttonFinishUp = new System.Windows.Forms.Button();
         this.buttonTriang = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // panel1
         // 
         this.panel1.Location = new System.Drawing.Point(11, 11);
         this.panel1.Margin = new System.Windows.Forms.Padding(2);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(979, 519);
         this.panel1.TabIndex = 0;
         this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
         this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(0, 0);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(75, 23);
         this.button1.TabIndex = 0;
         // 
         // buttonDrawMode
         // 
         this.buttonDrawMode.AllowDrop = true;
         this.buttonDrawMode.Location = new System.Drawing.Point(995, 12);
         this.buttonDrawMode.Name = "buttonDrawMode";
         this.buttonDrawMode.Size = new System.Drawing.Size(75, 60);
         this.buttonDrawMode.TabIndex = 0;
         this.buttonDrawMode.Text = "Draw";
         this.buttonDrawMode.UseVisualStyleBackColor = true;
         this.buttonDrawMode.Click += new System.EventHandler(this.buttonDrawMode_Click);
         // 
         // buttonFinishUp
         // 
         this.buttonFinishUp.Location = new System.Drawing.Point(994, 79);
         this.buttonFinishUp.Name = "buttonFinishUp";
         this.buttonFinishUp.Size = new System.Drawing.Size(75, 55);
         this.buttonFinishUp.TabIndex = 1;
         this.buttonFinishUp.Text = "Finish";
         this.buttonFinishUp.UseVisualStyleBackColor = true;
         this.buttonFinishUp.Click += new System.EventHandler(this.buttonFinishUp_Click);
         // 
         // buttonTriang
         // 
         this.buttonTriang.Location = new System.Drawing.Point(995, 140);
         this.buttonTriang.Name = "buttonTriang";
         this.buttonTriang.Size = new System.Drawing.Size(73, 63);
         this.buttonTriang.TabIndex = 2;
         this.buttonTriang.Text = "Triangulate";
         this.buttonTriang.UseVisualStyleBackColor = true;
         this.buttonTriang.Click += new System.EventHandler(this.buttonTriang_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1082, 541);
         this.Controls.Add(this.buttonTriang);
         this.Controls.Add(this.buttonFinishUp);
         this.Controls.Add(this.buttonDrawMode);
         this.Controls.Add(this.panel1);
         this.Margin = new System.Windows.Forms.Padding(2);
         this.Name = "Form1";
         this.Text = "Form1";
         this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Button buttonDrawMode;
      private System.Windows.Forms.Button buttonFinishUp;
      private System.Windows.Forms.Button buttonTriang;
   }
}

