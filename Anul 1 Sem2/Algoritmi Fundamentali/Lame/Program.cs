using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lame {
	internal class Program {
		static void Main() {


			Console.Write("N =");
			int n = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();
			int tmp;

			for (int i = n-1; i >= 0; i--) {
				for (int j = 0; j < n; j++) {
					if (i - j < 0)
						tmp = (i - j) * -1;
					else
						tmp = i - j;
					Console.Write(tmp + " ");
				}
				Console.WriteLine();
			}


		}
	}
}
