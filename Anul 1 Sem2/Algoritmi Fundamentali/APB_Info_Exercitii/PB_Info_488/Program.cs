using System;

namespace PB_Info_488
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string[] data = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 1)
                    Console.Write(data[i] + " ");
            }
            Console.WriteLine();

            for (int i =n-1; i>= 0; i--)
            {
                if(i%2 == 0)
                    Console.Write(data[i]+ " ");
            }
            Console.WriteLine();
        }
    }
}
