using System;

namespace LeftRight {
   internal class Program {

      static void Main() {
         //Provided Problem Data
         int[] arr = new int[] { 6, 3, 1, 2, 6, 10, 7, 11, 16 };
         int n = arr.Length;


         int var = arr[0];
         int[] max = new int[n];
         for (int i = 0; i < n; i++) {
            if (arr[i] >= var) {
               var = arr[i];
               max[i] = var;
            }
            else
               max[i] = var;

         }

         var = arr[n - 1];
         int[] min = new int[n];
         for (int i = n - 1; i >= 0; i--) {
            if (arr[i] <= var) {
               var = arr[i];
               min[i] = var;
            }
            else
               min[i] = var;
         }


         int c = 0;
         for (int i = 0; i < n; i++) {
            if (max[i] == min[i]) {
               c++;
            }
         }



         for (int i = 0; i < n; i++) {
            Console.Write(arr[i] + " ");
         }
         Console.WriteLine();


         for (int i = 0; i < n; i++) {
            Console.Write(max[i] + " ");
         }
         Console.WriteLine();


         for (int i = 0; i < n; i++) {
            Console.Write(min[i] + " ");
         }
         Console.WriteLine();

         Console.WriteLine();
         Console.WriteLine("Valori LR:" + c);
      }
   }
}
