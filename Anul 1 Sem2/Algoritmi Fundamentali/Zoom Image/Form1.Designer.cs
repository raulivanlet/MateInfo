﻿namespace Zoom_Image
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.button2 = new System.Windows.Forms.Button();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.button3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 334);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(128, 48);
			this.button1.TabIndex = 0;
			this.button1.Text = "Source";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(400, 300);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(501, 12);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(400, 300);
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(648, 334);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(128, 48);
			this.button2.TabIndex = 3;
			this.button2.Text = "Source";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Location = new System.Drawing.Point(985, 12);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(400, 299);
			this.pictureBox3.TabIndex = 4;
			this.pictureBox3.TabStop = false;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(1114, 334);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(128, 48);
			this.button3.TabIndex = 5;
			this.button3.Text = "Merge";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1542, 783);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Button button3;
	}
}

