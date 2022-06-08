using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Zoom_Image {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		static string file1 = @"../../Default1.jpg";
		static string file2 = @"../../Default2.jpg";
		Bitmap source1;
		Bitmap source2;
		Bitmap sourceTmp = new Bitmap(Image.FromFile(file1));

		private void Form1_Load(object sender, EventArgs e) {
			RebuildImg1();
			RebuildImg2();
		}

		private void button1_Click(object sender, EventArgs e) {
			OpenFileDialog dialogFIle = new OpenFileDialog();
			dialogFIle.Filter = "All Files (*.*)|*.*";
			dialogFIle.FilterIndex = 1;
			dialogFIle.Multiselect = false;
			if (dialogFIle.ShowDialog() == DialogResult.OK) {
				file1 = dialogFIle.FileName;
				string[] arrAllFiles = dialogFIle.FileNames; //used when Multiselect = true
				RebuildImg1();
			}
		}

		private void button2_Click(object sender, EventArgs e) {
			OpenFileDialog dialogFIle = new OpenFileDialog();
			dialogFIle.Filter = "All Files (*.*)|*.*";
			dialogFIle.FilterIndex = 1;
			dialogFIle.Multiselect = false;
			if (dialogFIle.ShowDialog() == DialogResult.OK) {
				file2 = dialogFIle.FileName;
				string[] arrAllFiles = dialogFIle.FileNames; //used when Multiselect = true     
				RebuildImg2();
			}
		}

		private void button3_Click(object sender, EventArgs e) {
			for (int i = 0; i < source1.Width; i++) {
				for (int j = 0; j < source1.Height; j++) {
					Color pixelColor1 = source1.GetPixel(i, j);
					Color pixelColor2 = source2.GetPixel(i, j);
					int pixR = (pixelColor1.R + pixelColor2.R) / 2;
					int pixG = (pixelColor1.G + pixelColor2.G) / 2;
					int pixB = (pixelColor1.B + pixelColor2.B) / 2;
					Color newColor = Color.FromArgb(pixR, pixG, pixB);
					sourceTmp.SetPixel(i, j, newColor);
				}
			}
			pictureBox3.Image = sourceTmp;

			ImageCodecInfo myImageCodecInfo = GetEncoderInfo("image/jpeg");
			Encoder myEncoder = Encoder.Quality;
			EncoderParameter myEncoderParameter;
			EncoderParameters myEncoderParameters = new EncoderParameters(1);

         // Save the bitmap as a JPEG file with quality level 100
         myEncoderParameter = new EncoderParameter(myEncoder, 100L);
         myEncoderParameters.Param[0] = myEncoderParameter;
         sourceTmp.Save("Shapes100.jpg", myImageCodecInfo, myEncoderParameters);
      }

		private static ImageCodecInfo GetEncoderInfo(String mimeType) {
			int j;
			ImageCodecInfo[] encoders;
			encoders = ImageCodecInfo.GetImageEncoders();
			for (j = 0; j < encoders.Length; ++j) {
				if (encoders[j].MimeType == mimeType)
					return encoders[j];
			}
			return null;
		}

		void RebuildImg1() {
			source1 = new Bitmap(Image.FromFile(file1));
			pictureBox1.Image = source1;
		}

		void RebuildImg2() {
			source2 = new Bitmap(Image.FromFile(file2));
			pictureBox2.Image = source2;
		}

		/*

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
 
namespace Curs_07_04_
{   
    public partial class Form1 : Form
    {
 
        private void btnDirect_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < sursa.Width; i++)
            {
                for(int j = 0; j < sursa.Height; j++)
                {
                    Color Ts = sursa.GetPixel(i, j);
                    Color Td;
                    int r = Ts.R;
                    int g = Ts.G;
                    int b = Ts.B;
                    Td = Color.FromArgb(r, g, b);
                    destinatie.SetPixel(i, j, Td);                   
                }
            }
            pictureBox2.Image = destinatie;
        }
 
        private void greyScale_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sursa.Width; i++)
            {
                for (int j = 0; j < sursa.Height; j++)
                {
                    Color Ts = sursa.GetPixel(i, j);
                    Color Td;
                    int r = Ts.R;
                    int g = Ts.G;
                    int b = Ts.B;
                    int t = (r + g + b) / 3;
                    Td = Color.FromArgb(t);
                    destinatie.SetPixel(i, j, Td);
                }
            }
            pictureBox2.Image = destinatie;
        }
 
        private void button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sursa.Width; i++)
            {
                for (int j = 0; j < sursa.Height; j++)
                {
                    Color Ts = sursa.GetPixel(i, j);
                    Color Td;
                    int r = Ts.R;
                    int g = Ts.G;
                    int b = Ts.B;
                    int t = (r + g + b) / 3;
                    if (t < 128)
                    {
                        Td = Color.FromArgb(0,0,0);
                    }
                    else
                    {
                        Td = Color.FromArgb(255,255,255);
                    }                    
                    destinatie.SetPixel(i, j, Td);
                }
            }
            pictureBox2.Image = destinatie;
        }
 
        private void filterPhotoshop_Click(object sender, EventArgs e)
        {
            int K = 50;
            for (int i = 0; i < sursa.Width; i++)
            {
                for (int j = 0; j < sursa.Height; j++)
                {
                    Color Ts = sursa.GetPixel(i, j);
                    Color Td;
                    int r = (Ts.R+K)%256;
                    int g = (Ts.G+K)% 256;
                    int b = (Ts.B+K) % 256;
                    Td = Color.FromArgb(r, g, b);
                    destinatie.SetPixel(i, j, Td);
                }
            }
            pictureBox2.Image = destinatie;
        }
 
        public int min(int a,int b)
        {
            if (a > b)
                return b;
            else
                return a; //a<b:a?b         
        }
        public int max(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
 
        private void filtru2_Click(object sender, EventArgs e)
        {
            int K = 20;
            for (int i = 0; i < sursa.Width; i++)
            {
                for (int j = 0; j < sursa.Height; j++)
                {
                    Color Ts = sursa.GetPixel(i, j);
                    Color Td;
                    int r = min(Ts.R + K, 255);
                    int g = min(Ts.G + K, 255);
                    int b = min(Ts.B + K, 255);
                    Td = Color.FromArgb(r, g, b);
                    destinatie.SetPixel(i, j, Td);
                }
            }
            pictureBox2.Image = destinatie;
        }
 
        private void filitru2max_Click(object sender, EventArgs e)
        {
            int K = 20;
            for (int i = 0; i < sursa.Width; i++)
            {
                for (int j = 0; j < sursa.Height; j++)
                {
                    Color Ts = sursa.GetPixel(i, j);
                    Color Td;
                    int r = max((Ts.R - K), 0);
                    int g = max((Ts.G - K), 0);
                    int b = max((Ts.B - K), 0);
                    Td = Color.FromArgb(r, g, b);
                    destinatie.SetPixel(i, j, Td);
                }
            }
            pictureBox2.Image = destinatie;
        }
 
        private void Contrast_Click(object sender, EventArgs e)
        {
            int K = 20;
            int t;
            for (int i = 0; i < sursa.Width; i++)
            {
                for (int j = 0; j < sursa.Height; j++)
                {
                    Color Ts = sursa.GetPixel(i, j);
                    Color Td;
                    int r = Ts.R;
                    int g = Ts.G;
                    int b = Ts.B;
                    t = (r + g + b);
                    if (t < 128)
                    {
                        r = max((Ts.R - K), 0);
                        g = max((Ts.G - K), 0);
                        b = max((Ts.B - K), 0);
                    }
                    else
                    {
                        r = min(Ts.R + K, 255);
                        g = min(Ts.G + K, 255);
                        b = min(Ts.B + K, 255);
                    }
                    Td = Color.FromArgb(r, g, b);
                    destinatie.SetPixel(i, j, Td);
                }
            }
            pictureBox2.Image = destinatie;
        }
 
    }
}

		*/

	}
}