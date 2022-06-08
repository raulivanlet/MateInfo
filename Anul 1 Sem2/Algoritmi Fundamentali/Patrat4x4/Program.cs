using System;

namespace Patrat4x4 {
   internal class Program {
      static void Main() {
         /*
         string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Public\TestFolder\WriteLines2.txt");
         System.Console.WriteLine("Contents of WriteLines2.txt = ");
         foreach (string line in lines) {
            // Use a tab to indent each line of the file.
            Console.WriteLine("\t" + line);
         }

         // Keep the console window open in debug mode.
         Console.WriteLine("Press any key to exit.");
         System.Console.ReadKey();


         // Example #1
         // Read the file as one string.
         string text = System.IO.File.ReadAllText(@"C:\Users\Public\TestFolder\WriteText.txt");
         */

         string input = System.IO.File.ReadAllText(@"..\..\in.txt");
         System.Console.WriteLine(input);

         string[] fileIn = input.Split('\n');
         for (int j = 0; j < fileIn.Length; j++) {
            Console.WriteLine(fileIn[j]);
         }

         string[] tmp = fileIn[0].Split(' ');
         int[] arr = new int[tmp.Length];


         //int i = 0;

         /*
         while (Convert.ToInt32(fileIn[i]) == i)
            i++;
         */


         /*
         int[] arr = new int[i];
         for (int j = 0; j < arr.Length; j++) {
            Console.WriteLine(fileIn[j]);
         }
         */


         /*
         for (int j = 0; j < arr.Length; j++) {
            Console.Write(fileIn[j] + " ");
         }
         */

      }
   }
}
