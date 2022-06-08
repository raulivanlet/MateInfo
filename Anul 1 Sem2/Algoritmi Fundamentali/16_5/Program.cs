using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_5
{
    internal class Program
    {
        static void Main()
        {
            Random rand = new Random();

            int nr = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[nr,nr];  
            for (int i =0; i < nr; i ++)
            {
                for (int j =0; j < nr; j++)
                {
                    arr[i,j] = rand.Next(10);
                    
                }
            }
        }
    }
}
