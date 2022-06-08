using System;

namespace _16_5_1
{
    internal class Program
    {
        static void Main()
        {
            Random rand = new Random();

            int nr = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[nr, nr];
            for (int i = 0; i < nr; i++)
            {
                for (int j = 0; j < nr; j++)
                {
                    if ( j == i)
                    {
                        arr[i, j] = 0;
                    }
                    else if ( i == 0 || j == 0)
                    {
                        arr[i, j] = i + j;
                    }
                    else
                    {
                        arr[i, j] = 9;
                    }
                }
            }


            for (int i = 0; i < nr; i++)
            {
                for (int j = 0; j < nr; j++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
