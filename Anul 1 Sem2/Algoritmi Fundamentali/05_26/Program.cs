namespace _05_26 {
	internal class Program {

		static void BackTracking(int k, int n, int[] s) {
			if (k == n) {
				for (int i = 0; i < n; i++) {
					System.Console.WriteLine("");
				}
				System.Console.WriteLine("");
			}
			else {
				for (int i = 0; i < n; i++) {
					s[k] = i;
					BackTracking(k + 1, n, s);
				}
			}
		}

		static void Main() {
			int n = 7;
			int[] s = new int[n];
			BackTracking(0, n, s);
			System.Console.WriteLine("Done");
		}
	}
}
