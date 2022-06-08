using System;

namespace _05_24 {
	internal class Program {
		static void Main() {
			Algoritm a = new PrimaCifraMininmaAlgoritm();

		}

	}

	abstract class Algoritm {
		public void Initiate() {
			ReadInput();
			Compute();
			WriteInput();
		}

		abstract protected void ReadInput();
		abstract protected void Compute();
		abstract protected void WriteInput();

	}

	class PrimaCifraMininmaAlgoritm : Algoritm {
		int n;
		int[] data;
		int rezult;
		protected override void ReadInput() {
			n = Convert.ToInt32(Console.ReadLine());
			data = new int[n];
			for (int i = 0; i < n; i++) {
				data[i] = Convert.ToInt32(Console.ReadLine());
			}
		}

		protected override void Compute() {
			rezult = data[0];
			for (int i = 0; i < n; i++) {
				//if (GetFirstDigit(result) > GetFirstDigit()) {
					result++;
				//}
			}
		}

		protected override void WriteInput() {

		}

	}

	class Maxim2Algoritm : Algoritm {
		int x ,y;
		int n;
		int[] data;

		protected override void ReadInput() {
			n = Convert.ToInt32(Console.ReadLine());
			data = new int[n];
			for (int i=0; i< n; i ++) {
				if (data[i] >= x) {
					y = x;
					x = data[i];
				}
				 else if (data[i] > y) {
					x = data[i];
				}
			}
		}

		protected override void Compute() {
			throw new NotImplementedException();
		}

		protected override void WriteInput() {

		}

	}
}