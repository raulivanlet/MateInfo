using System;

namespace PB_Info_487
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] nr = Console.ReadLine().Split(' ');

            float ma =0;
            for (int i =0; i< n; i++)
            {
                ma += Convert.ToInt32(nr[i]);
            }
            ma = ma / n;

            int c = 0;
            for (int i = 0; i < n; i++)
            {
                if (Convert.ToInt32(nr[i]) >= ma)
                {
                    c++;
                }
            }
            Console.WriteLine(c);
        }
    }
}
