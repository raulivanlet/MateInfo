using System.IO;

namespace LeeAlgorithm
{
    internal class Program
    {
        static int[,] ReadMatrix(string file)
        {
            TextReader reader = new StreamReader(file);
            string[] buffer = reader.ReadLine().Split(' ');
            int n = int.Parse(buffer[0]);
            int m = int.Parse(buffer[1]);
            int[,] arr = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                buffer = reader.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = int.Parse(buffer[j]);
                }
            }
            return arr;
        }

        static void Main()
        {
            int[,] arr = ReadMatrix("../../matrix.txt");
            for (int i =0 ; i<arr.GetLength(0) ; i++)
            {
                for (int j=0; j<arr.GetLength(1); j++)
                {
                    System.Console.Write($" {arr[i,j]} ");
                }
                System.Console.WriteLine();
            }

        }
    }
}
