using System;

namespace PB_Info_553
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] nr = Console.ReadLine().Split(' ');

            int max=0, maxIndex=0, min= 10000, minIndex = 10000;

            for (int i = 0; i < n; i++)
            {
                if(Convert.ToInt32(nr[i]) >= max)
                {
                    max = Convert.ToInt32(nr[i]);
                    maxIndex = i;
                }
                if (Convert.ToInt32(nr[i]) <= min)
                {
                    min = Convert.ToInt32(nr[i]);
                    minIndex = i;
                }
            }
            minIndex++;
            maxIndex++;
            Console.WriteLine(minIndex + " " + maxIndex);
        }
    }
}
