using System;
using System.IO;

namespace Matrix {
	internal class Program {

		static void ViewMatrix(int[,] mat) {
			for ( int i = 0; i < mat.GetLength(0); i++ ) {
				for ( int j = 0; j < mat.GetLength(1); j++ )
					Console.Write(mat[i, j] + " ");
				Console.WriteLine();
			}
		}

		static int[,] MatrixRead(string filename) {
			TextReader load = new StreamReader(filename);
			string[] t = load.ReadLine().Split(' ');
			int n = int.Parse(t[0]);
			int m = int.Parse(t[1]);
			int[,] a = new int[n, m];
			for ( int i = 0; i < n; i++ ) {
				string[] buffer = load.ReadLine().Split(' ');
				for ( int j = 0; j < m; j++ ) {
					a[i, j] = Convert.ToInt32(buffer[j]);
				}
			}
			return a;
		}

		static int[,] MatrixZoom(int[,] mat) {
			int n = mat.GetLength(0), m = mat.GetLength(1);
			int[,] matExt = new int[n * 2 - 1, m * 2 - 1];

			for ( int i = 0; i < n; i++ ) {
				for ( int j = 0; j < m; j++ ) {
					matExt[i * 2, j * 2] = mat[i, j];
				}
			}
			for ( int i = 0; i < n * 2 - 1; ++i ) {
				for ( int j = 1; j < m * 2 - 2; j += 2 ) {
					int tmp1 = j, tmp2 = j, tmp3;
					tmp1--; tmp2++;
					tmp3 = matExt[i, tmp1] + matExt[i, tmp2];
					tmp3 /= 2;
					matExt[i, j] = (tmp3);
				}
			}

			for ( int i = 1; i < n * 2 - 1; i += 2 ) {
				for ( int j = 0; j < m * 2 - 1; ++j ) {
					int tmp1 = i, tmp2 = i, tmp3;
					tmp1--; tmp2++;
					tmp3 = matExt[tmp1, j] + matExt[tmp2, j];
					tmp3 /= 2;
					matExt[i, j] = (tmp3);
				}
			}
			return matExt;
		}

		static void Main() {
			int[,] nr = MatrixRead(@"../../input.txt");


			ViewMatrix(nr);
			Console.WriteLine();

			int[,] nr1 = MatrixZoom(nr);
			Console.WriteLine();

			ViewMatrix(nr1);
			Console.WriteLine();
		}
	}
}
