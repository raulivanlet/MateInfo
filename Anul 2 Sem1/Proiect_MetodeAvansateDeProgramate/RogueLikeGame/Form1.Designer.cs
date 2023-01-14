namespace RogueLikeGame {
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
         this.bbackground = new System.Windows.Forms.PictureBox();
         this.bplayer = new System.Windows.Forms.PictureBox();
         this.benemy = new System.Windows.Forms.PictureBox();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         ((System.ComponentModel.ISupportInitialize)(this.bbackground)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bplayer)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.benemy)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // bbackground
         // 
         this.bbackground.Location = new System.Drawing.Point(84, 106);
         this.bbackground.Name = "bbackground";
         this.bbackground.Size = new System.Drawing.Size(100, 50);
         this.bbackground.TabIndex = 0;
         this.bbackground.TabStop = false;
         // 
         // bplayer
         // 
         this.bplayer.Location = new System.Drawing.Point(84, 310);
         this.bplayer.Name = "bplayer";
         this.bplayer.Size = new System.Drawing.Size(50, 50);
         this.bplayer.TabIndex = 1;
         this.bplayer.TabStop = false;
         // 
         // benemy
         // 
         this.benemy.Location = new System.Drawing.Point(284, 310);
         this.benemy.Name = "benemy";
         this.benemy.Size = new System.Drawing.Size(100, 50);
         this.benemy.TabIndex = 2;
         this.benemy.TabStop = false;
         // 
         // pictureBox1
         // 
         this.pictureBox1.Location = new System.Drawing.Point(0, 0);
         this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(100, 50);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox1.TabIndex = 3;
         this.pictureBox1.TabStop = false;
         this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1429, 609);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.benemy);
         this.Controls.Add(this.bplayer);
         this.Controls.Add(this.bbackground);
         this.Name = "Form1";
         this.Text = "Form1";
         this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
         this.Load += new System.EventHandler(this.Form1_Load);
         this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
         ((System.ComponentModel.ISupportInitialize)(this.bbackground)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bplayer)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.benemy)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.PictureBox bbackground;
      private System.Windows.Forms.PictureBox bplayer;
      private System.Windows.Forms.PictureBox benemy;
      private System.Windows.Forms.PictureBox pictureBox1;
   }
}

