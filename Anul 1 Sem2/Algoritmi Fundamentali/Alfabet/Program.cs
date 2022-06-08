using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfabet {
	internal class Program {
		static void Main(string[] args) {

			Console.Write("N =");
			int n = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();
			Console.Write("M =");
			int m = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();

			for (int i=0; i< n; i++) {
				for (int j = 0; j < m; j++) {
					if(j %2 == 1)
						Console.Write(Convert.ToChar(i + 65));//41
					else
						Console.Write(Convert.ToChar(i + 97));//61
					Console.Write(" ");
				}
				Console.WriteLine();
			}

		}
	}
}
