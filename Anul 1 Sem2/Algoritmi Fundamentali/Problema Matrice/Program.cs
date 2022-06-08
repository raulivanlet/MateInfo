using System;

namespace Problema_Matrice {
	internal class Program {

		static Random rnd = new Random();

		static void Main() {
			int n = 7;
			int m = 12;
			int[,] a = new int[n, m];
			for ( int i = 0; i < n; i++ ) {
				for ( int j = 0; j < m; j++ ) {
					a[i, j] = rnd.Next(10);
				}
			}

			for ( int i = 0; i < n; i++ ) {
				for ( int j = 0; j < m; j++ ) {
					Console.Write(a[i, j] + " ");
				}
				Console.WriteLine();
			}

			Console.ReadKey();

			for ( int i = 0; i < m; i++ ) {
				Console.Write(a[0, i]);
			}
			Console.WriteLine();

			for ( int i = 0; i < n; i++ ) {
				Console.Write(a[i, n - i]);
			}
		}
	}
}
