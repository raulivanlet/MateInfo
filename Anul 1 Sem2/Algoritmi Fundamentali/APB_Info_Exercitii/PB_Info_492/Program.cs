using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB_Info_492
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //6
            //50 18 15 28 35 40
            int n = 6;
            //n = Convert.ToInt32(Console.ReadLine());

            int[] nr = new int[] {50, 18, 15, 28, 35, 40};
            //nr = Convert.ToInt32(Console.ReadLine().Split(' '));

            int c = 0;
            for (int i = 0; i < n; i++)
            {

            }
        }
    }
}

/*
using System;

namespace _492
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,perechi=0;
            n=int.Parse(Console.ReadLine());
            int []v=new int[n];
            string[] data = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(data[i]);
            for (int i=0;i<n/2;i++)
                if (cmmdc(v[i],v[n-i-1])==1)
                    perechi++;
            Console.WriteLine(perechi);
        }

        static int cmmdc (int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                    a -= b;
                if (b > a)
                    b -= a;
            }
            return a;   
        }
    }
}
*/