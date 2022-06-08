namespace _06_02 {
   internal class Program {

      //Aranjamente de numere dinstincte

      static void bk(int k, int n, int[] s, bool[] b) {
         if (k >= n) {
            for (int i = 0; i < n; i++) {
               System.Console.Write(s[i] + " ");
            }
            System.Console.WriteLine();
         }
         else {
            for (int i = 0; i < n; i++) {
               b[i] = true;
               s[k] = i;
               bk(k + 1, n, s, b);
               b[i] = false;
            }
         }
      }

      static void Main() {
         int[] arr = new int[5];
         bool[] b = new bool[5];
         bk(0, 5, arr, b);
      }
   }
}
